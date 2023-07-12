using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vazifa10_07.Classlar
{
    public class Film_category
    {
        public int film_id;
        public int category_id;
        public DateTime last_update;
        public override string ToString()
        {
            return $"{film_id} | {category_id} | {last_update}";

        }
    }
}
