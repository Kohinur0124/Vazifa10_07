using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vazifa10_07.Classlar
{
    public class payment
    {
        public int payment_id;
        public int customer_id;
        public int staff_id;
        public int rental_id;
        public float amount;
        public DateTime payment_date;

        public override string ToString()
        {
            return $"{payment_id} | {customer_id} | {staff_id} | {rental_id} | {amount} | {payment_date}";
        }
    }
}
