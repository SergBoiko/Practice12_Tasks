using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers_ClassLibrary
{
    public abstract class Flower
    {
        public Flower(string name, int price)
        {
            Price = price;
            Name = name;
        }
        public virtual int Price { get; set; }
        public virtual string Name { get; set; }
       
    }

    
}
