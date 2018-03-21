using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening
{
    class Animal
    {
        protected string Name;

        public Animal()
        {
        }

        public Animal(string name)
        {
            this.Name = name;
        }

        public virtual string Sound()
        {
            return "huh?"; 
        }

        public string name { get; set; }
    }
}
