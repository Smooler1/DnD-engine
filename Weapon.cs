using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srap
{
    public abstract class Weapon
    {
        public string Name { get; set; }
        public string Type { get; set; }              // Light / Intermediate / Heavy
        public string Damage { get; set; }            // "2D6+3", etc.
        public string SpecialEffect { get; set; }     // "Area of effect", etc.
        public int Durability { get; set; }           // Starts at 10, 12, etc.



        public virtual void Display()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Damage: {Damage}");
            Console.WriteLine($"Special Effect: {SpecialEffect}");
            Console.WriteLine($"Durability: {Durability}");
            Console.WriteLine("---------------------------");
        }





    }
}
