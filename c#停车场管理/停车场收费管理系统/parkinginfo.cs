using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 停车场收费管理系统
{
    class parkinginfo
    {
        private int total;
        private int remain;

        public int Total { get => total; set => total = value; }
        public int Remain { get => remain; set => remain = value; }

        public parkinginfo()
        {
        }

        public parkinginfo(int total, int remain)
        {
            Total = total;
            Remain = remain;
        }
    }
}
