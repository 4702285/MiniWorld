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
            return new sockconnection(sock);
        }


        public override bool connect(string ip, int port)
        {
            throw new NotImplementedException();
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
            connection client = conn.accept();
            if (null != client)
            {
                m_clients.Add(client);
                client.recv();
            }
            conn.begin_accept();
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
