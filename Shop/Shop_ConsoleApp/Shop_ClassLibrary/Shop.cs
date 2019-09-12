using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_ClassLibrary
{
    public class Shop
    {
        public string Name { get; set; }
        public int ShopSize { get; set; }
        private Product[] Products { get; set; }

        public Shop(string name, int size)
        {
            Name = name;
            ShopSize = size;
            Products = new Product[size];
        }
        public void AddNewProduct(Product product)
        {
            int nullCount = 0;
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i] == null)
                {
                    Products[i] = product;
                    break;
                }
                else
                {
                    nullCount++;
                }
            }
            if (nullCount == Products.Length)
            {
                Console.WriteLine("Choose another shop, this one is full");
            }
        }

        public void GetAllInfoAboutShop()
        {
            Console.WriteLine($"Shop {Name}");
            Console.WriteLine($"Shop size: {ShopSize}");
            Console.WriteLine($"\t{Products.Length} products:");
            foreach (var product in Products)
            {
                Console.WriteLine($"\t\t{product.GetAllInfo()}");
            }

        }
    }
}
