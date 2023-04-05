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
        private Socket m_sock;
        private List<connection> m_clients;
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
            return new sockconnection(sock);
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

        public override bool send(byte[] data)
        {
            throw new NotImplementedException();
        }

        public override byte[] recv()
        {
            throw new NotImplementedException();
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
        }

        protected void on_received(IAsyncResult ar)
        {

        }

        protected void on_sended(IAsyncResult ar)
        {

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
    }
}
