using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vazifa10_07.Classlar
{
    public class category
    {
        public int category_id;
        public string name;
        public string last_update;

        public override string ToString()
        {
            return $"{category_id} | {name} | {last_update}"; 
        }
    }
}
