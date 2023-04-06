using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace mwt
{
    public class sockconnection : connection
    {
        const int RECV_BUFFER_SIZE = 32 * 1024;
        const int MAX_RECV_BUFFER_COUNT = 32;

        private Socket m_sock;
        private List<connection> m_clients;
        private List<recv_buffer> m_recvs;
        private List<recv_buffer> m_waitings;
        private AsyncCallback m_onaccept;
        private AsyncCallback m_onconnected;
        private AsyncCallback m_onreceived;
        private AsyncCallback m_onsended;

        public sockconnection()
        {

        }

        public sockconnection(Socket sock)
        {
            m_sock = sock;
        }

        public override bool bind(string ip, int port)
        {
            try
            {
                IPAddress ipa;
                if (!IPAddress.TryParse(ip, out ipa))
                {
                    Log.error("{0} : invalid ip address.", ip);
                    return false;
                }
                IPEndPoint ep = new IPEndPoint(ipa, port);
                m_sock = new Socket(ep.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                m_sock.Bind(ep);
                m_onaccept = new AsyncCallback(on_accept);
                m_clients = new List<connection>();
                begin_accept();
                return true;
            }catch(Exception ex)
            {
                Log.exception(ex);
            }
            return false;
        }

        public override connection accept(IAsyncResult ar)
        {
            Socket sock = m_sock.EndAccept(ar);
            Log.verbose("{0} : accept client connection.", sock.RemoteEndPoint.ToString());
            sockconnection client = new sockconnection(sock);
            client.m_onreceived = new AsyncCallback(client.on_received);
            client.m_onsended = new AsyncCallback(client.on_sended);
            return client;
        }


        public override bool connect(string ip, int port)
        {
            try
            {
                IPAddress ipa;
                if (!IPAddress.TryParse(ip, out ipa))
                {
                    IPHostEntry he = Dns.GetHostEntry(ip);
                    if (null == he || he.AddressList.Length == 0)
                    {
                        Log.error("{0} : invalid host name or ip address.", ip);
                        return false;
                    }
                    ipa = he.AddressList[0];
                }
                m_sock = new Socket(ipa.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint ep = new IPEndPoint(ipa, port);
                m_onconnected = new AsyncCallback(on_connected);
                m_onreceived = new AsyncCallback(on_received);
                m_onsended = new AsyncCallback(on_sended);
                m_sock.BeginConnect(ep, m_onconnected, this);
                return true;
            }catch(Exception ex)
            {
                Log.exception(ex);
            }
            return false;
        }

        public override bool close()
        {
            throw new NotImplementedException();
        }

        public override bool send(byte[] data, int offset, int len)
        {
            try
            {
                m_sock.BeginSend(data, offset, len, SocketFlags.None, on_sended, this);
                return true;
            }catch(Exception ex)
            {
                Log.exception(ex);
            }
            return false;
        }

        public override bool recv()
        {
            try
            {
                recv_buffer buf = get_receive_buf();
                if (null == buf)
                    return false;
                m_sock.BeginReceive(buf.data, buf.offset, buf.size, SocketFlags.None, m_onreceived, buf);
                return true;
            }catch(Exception ex)
            {
                Log.exception(ex);
            }
            return false;
        }

        protected void on_accept(IAsyncResult ar)
        {
            sockconnection conn = ar.AsyncState as sockconnection;
            connection client = conn.accept(ar);
            if (null != client)
            {
                m_clients.Add(client);
                client.recv();
            }
            conn.begin_accept();
        }

        protected void on_connected(IAsyncResult ar)
        {
            try
            {
                sockconnection conn = ar.AsyncState as sockconnection;
                conn.m_sock.EndConnect(ar);
                conn.recv();
            }
            catch (Exception ex)
            {
                Log.exception(ex);
            }
        }

        protected void on_received(IAsyncResult ar)
        {
            try
            {
                recv_buffer buf = ar.AsyncState as recv_buffer;
                if (buf == null)
                {
                    Log.error("无效的网络消息接收缓冲区.");
                    return;
                }
                int len = m_sock.EndReceive(ar);
                if (len > 0)
                {
                    buf.offset += len;
                    if (buf.offset >= buf.size)
                    {
                        m_waitings.Add(buf);
                        m_recvs.RemoveAt(0);
                    }
                }
                recv();
            }catch(Exception ex)
            {
                Log.exception(ex);
            }

        }

        protected void on_sended(IAsyncResult ar)
        {
            try
            {
                sockconnection conn = ar.AsyncState as sockconnection;
                int len = conn.m_sock.EndSend(ar);
            }catch(Exception ex)
            {
                Log.exception(ex);
            }
        }

        protected void begin_accept()
        {
            try
            {
                m_sock.BeginAccept(m_onaccept, this);
            }catch(Exception ex)
            {
                Log.exception(ex);
            }
        }

        private recv_buffer get_receive_buf()
        {
            if (null == m_recvs)
                m_recvs = new List<recv_buffer>();
            if (m_recvs.Count == 0)
            {
                // 等待处理的队列已经满了，不再接收消息
                if (null != m_waitings && m_waitings.Count >= MAX_RECV_BUFFER_COUNT)
                {
                    Log.error("网络消息等待队列已满，无法接收消息.");
                    return null;
                }
                m_recvs.Add(new recv_buffer(RECV_BUFFER_SIZE));
            }
            return m_recvs[0];
        }
    }
}
