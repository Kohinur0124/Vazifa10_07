using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vazifa10_07.Classlar
{
    public class store
    {
        public int store_id;
        public int manager_staff_id;
        public int address_id;
        public DateTime last_update;

        public override string ToString()
        {
            return $"{store_id} | {manager_staff_id} | {address_id} | {last_update}";
        }
    }
}
