using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vazifa10_07.Classlar
{
    public class Address
    {
        public int address_id;
        public string address;
        public string address2;
        public string distict;
        public int city_id;
        public string postal_code;
        public string phone;
        public DateTime last_update;

        public override string ToString()
        {
            return $"{address_id} | {address} | {address2} | {distict} | {city_id} | {postal_code} | {phone} | {last_update}"; 
        }
    }
}
