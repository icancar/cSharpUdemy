using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerator
{
    internal class Weapon
    {
        private String Name;
        
        public Weapon(String name)
        {
            Name = name;
        }
        public void Label()
        {
            Console.WriteLine("This is {0}!", this.Name);
        }
    }
}
