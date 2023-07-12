using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vazifa10_07.Classlar
{
    public class Film_actor
    {
        public int actor_id;
        public int film_id;
        public DateTime last_update;

        public override string ToString()
        {
            return $"{actor_id} | {film_id} | {last_update}";
        }
    }
}
