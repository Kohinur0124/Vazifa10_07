using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vazifa10_07.Classlar
{
    public class inventory
    {
        public int inventory_id;
        public int film_id;
        public int store_id;
        public DateTime last_update;

        public override string ToString()
        {
            return $"{inventory_id} | {film_id} | {store_id} | {last_update}";
        }

    }
}
