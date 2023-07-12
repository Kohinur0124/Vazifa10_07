using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vazifa10_07.Classlar
{
    public class Customer
    {
        public int customer_id;
        public int store_id;
        public string first_name;
        public string last_name;
        public string email;
        public int address_id;
        public bool activebool;
        public DateTime create_date;
        public DateTime last_update;
        public int active;

        public override string ToString()
        {
            return $"{customer_id} | {store_id} | {first_name} | {last_name} | {email} | {address_id} | {activebool} | {create_date} | {last_update} | {active}";
        }


    }
}
