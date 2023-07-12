using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vazifa10_07.Classlar
{
    public class Rental
    {
        public int rental_id;
        public DateTime rental_date;
        public int inventory_id;
        public int customer_id;
        public DateTime return_date;
        public int staff_id;
        public DateTime last_update;

        public override string ToString()
        {
            return $"{rental_id} | {rental_date} | {inventory_id} | {customer_id} | {rental_date} | {staff_id} | {last_update}";
        }
    }
}
