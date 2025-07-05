using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srap
{
    public class Ranged_Weapon : Weapon
    {

        public int Range;
        public int Bullets;

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Ammo: {Bullets}");
        }


    }
}
