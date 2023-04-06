using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mwt
{
    class recv_buffer
    {
        public byte[] data;
        public int size;
        public int offset;
        public int pos;

        public recv_buffer(int len)
        {
            data = new byte[len];
            size = len;
            offset = 0;
            pos = 0;
        }
    }
}
