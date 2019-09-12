using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_ClassLibrary
{
    public class Furniture : Product
    {
        public string Manufacturer { get; set; }
        public Furniture(string manufacturer, string type, string name, int quantity, int price) : base(type, name, quantity, price)
        {
            Manufacturer = manufacturer;
        }
        public override string GetAllInfo()
        {
            return $"{Type} {Name} (Manufacturer: {Manufacturer}): Quantity = {Quantity}, Price = {Price}$";
        }
    }
}
