using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vazifa10_07.Classlar
{
    public class Country
    {
        public int country_id;
        public string country;
        public DateTime last_update;

        public override string ToString()
        {
            return $"{country_id} | {country} | {last_update}";
        }
    }
}
