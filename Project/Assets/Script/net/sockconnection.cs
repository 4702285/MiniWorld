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

        public sockconnection()
        {

        }

        public override bool bind(int port)
        {
        }

        public override connection accept()
        {
            throw new NotImplementedException();
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
    }
}
