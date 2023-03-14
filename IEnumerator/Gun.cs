using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerator
{
    internal class Gun: Weapon, IShootable
    {
        public Gun():base("Gun"){        
        }
        public void Shoot()
        {
            Console.WriteLine("Bang!");
        }
    }
}
