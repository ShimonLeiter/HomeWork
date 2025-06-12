using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW49
{
    internal class Shirt
    {
       public string color {  get; set; }   

        public string pattern { get; set; }

        public Shirt(string color, string pattern)
        {
            this.color = color;
            this.pattern = pattern;
            Console.WriteLine($"{this.color}:{this.pattern} ");

        }
    }
}
