using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Git
{
    public abstract class Category
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }

        public void Show()
        {
            Console.WriteLine();
            Console.WriteLine(Name);
            Console.WriteLine(Weight);
            Console.WriteLine(Stock);
            Console.WriteLine(Price);
            Console.WriteLine();
        }
    }
    
}
