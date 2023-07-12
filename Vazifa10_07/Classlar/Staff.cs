using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vazifa10_07.Classlar
{
    public class staff
    {
        public int staff_id;
        public string first_name;
        public string last_name;
        public int address_id;
        public string email;
        public int store_id;
        public bool active;
        public string username;
        public string password;
        public DateTime last_update;
        public string picture;

        public override string ToString()
        {
            return $"{staff_id} | {first_name} | {last_name} | {address_id} | {email} | {store_id} | {active} | " +
                $"{username} | {password} | {last_update} | {picture}";
        }

    }
}
