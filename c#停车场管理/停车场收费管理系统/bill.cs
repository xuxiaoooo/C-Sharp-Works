using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 停车场收费管理系统
{
    class bill
    {
        private string cardnumber;
        private DateTime intime;
        private DateTime outtime;
        private float fees;

        public string Cardnumber { get => cardnumber; set => cardnumber = value; }
        public DateTime Intime { get => intime; set => intime = value; }
        public DateTime Outtime { get => outtime; set => outtime = value; }
        public float Fees { get => fees; set => fees = value; }

        public bill()
        {

        }

        public bill(string cardnumber, DateTime intime, DateTime outtime, float fees)
        {
            Cardnumber = cardnumber;
            Intime = intime;
            Outtime = outtime;
            Fees = fees;
        }


        public void calculation()
        {
            outtime = Convert.ToDateTime(DateTime.Now.ToString());
            TimeSpan ss = outtime - intime;
            fees = (float.Parse(ss.TotalHours.ToString()));    
        }
    }
}
