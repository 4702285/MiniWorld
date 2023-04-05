using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace mwt
{
    public abstract class connection
    {
        public abstract bool connect(string ip, int port);

        public abstract bool bind(string ip, int port);

        public abstract connection accept(IAsyncResult ar);

        public abstract bool send(byte[] data);

        public abstract byte [] recv();

        public abstract bool close();
    }
}
