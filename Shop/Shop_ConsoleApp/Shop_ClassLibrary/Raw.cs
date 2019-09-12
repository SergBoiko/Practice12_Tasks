using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_ClassLibrary
{
    public class Raw : Product
    {
        public string Dimensions { get; set; }
        public Raw(string dimensions, string type, string name, int quantity, int price) : base(type, name, quantity, price)
        {
            Dimensions = dimensions;
        }
        public override string GetAllInfo()
        {
            return $"{Type} {Name} (Dimensions: {Dimensions}): Quantity = {Quantity}, Price = {Price}$";
        }
    }
}
