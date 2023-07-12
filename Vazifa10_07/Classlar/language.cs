using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vazifa10_07.Classlar
{
    public  class language
    {
        public int language_id;
        public string name;
        public DateTime last_update;

        public override string ToString()
        {
            return $"{language_id} | {name} | {last_update}";
        }
    }
}
