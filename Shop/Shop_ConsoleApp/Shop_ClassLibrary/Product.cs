using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_ClassLibrary
{
    public abstract class Product
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

        public Product(string type, string name, int quantity, int price)
        {
            Type = type;
            Name = name;
            Quantity = quantity;
            Price = price;
        }
        public virtual string GetAllInfo()
        {
            return $"{Type} {Name}: Quantity = {Quantity}, Price = {Price}$";
        }
    }
}
