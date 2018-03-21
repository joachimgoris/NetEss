using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening
{
    class SmallDog : Dog
    {
        public SmallDog(string name) : base(name)
        {
        }

        public override string Sound()
        {
            return "kef kef";
        }
    }
}
