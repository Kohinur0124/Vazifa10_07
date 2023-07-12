using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vazifa10_07.Classlar
{
    public class City
    {
        public int city_id;
        public string city;
        public int country_id;
        public DateTime last_update;

        public override string ToString()
        {
            return $"{city_id} | {city} | {country_id} | {last_update}";
        }
    }
}
