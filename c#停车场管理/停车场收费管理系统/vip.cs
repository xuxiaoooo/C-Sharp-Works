using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 停车场收费管理系统
{
    class vip
    {
        private string cardnumber;
        private string carnumber;
        private string name;
        private string phone;
        private float money;
        private DateTime time;

        public vip(string cardnumber, string carnumber, string name, string phone, float money, DateTime time)
        {
            this.Cardnumber = cardnumber;
            this.Carnumber = carnumber;
            this.Name = name;
            this.Phone = phone;
            this.Money = money;
            this.Time = time;
        }

        public string Cardnumber { get => cardnumber; set => cardnumber = value; }
        public string Carnumber { get => carnumber; set => carnumber = value; }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public DateTime Time { get => time; set => time = value; }
        public float Money { get => money; set => money = value; }
    }
}
