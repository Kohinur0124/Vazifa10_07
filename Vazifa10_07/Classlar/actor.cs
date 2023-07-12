using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vazifa10_07.Classlar
{
    public class actor
    {
        public int actor_id;
        public string first_name;
        public string last_name;
        public string last_update;

        public override string ToString()
        {
            return $"{actor_id} | {first_name} | {last_name} | {last_update}";
        }
    }
}
