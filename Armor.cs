using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace srap
{
    public class Armor
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string SpecialEffect { get; set; }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Special Effect: {SpecialEffect}");
            Console.WriteLine("---------------------------");
        }




    }
}
