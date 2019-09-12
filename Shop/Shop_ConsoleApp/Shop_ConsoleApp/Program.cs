using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop_ClassLibrary;

namespace Shop_ConsoleApp
{
    class Program
    {
        public static List<Shop> shops = new List<Shop>();
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("1 - add new shop, 2 - add new product to the shop, 3 - show information about the shop");
                int menu = 0;
                do
                {
                    Console.Write("Menu=");
                } while (!int.TryParse(Console.ReadLine(), out menu) || menu == 0);
                switch (menu)
                {
                    case 1:
                        Console.Write("Enter name of new shop: ");
                        string shopName = Console.ReadLine();
                        Console.WriteLine("Enter size of the shop");
                        int size = 0;
                        do
                        {
                            Console.Write("Size: ");
                        } while (!int.TryParse(Console.ReadLine(), out size) || size == 0);
                        shops.Add(new Shop(shopName, size));
                        break;

                    case 2:
                        if (shops.Any())
                        {
                            Console.WriteLine("Choose one of the shops");
                            int shopNumber = 0;
                            foreach (var shop in shops)
                            {
                                Console.WriteLine($"{shopNumber} {shop.Name}");
                                shopNumber++;
                            }
                            do
                            {
                                Console.Write("Shop #: ");
                            } while (!int.TryParse(Console.ReadLine(), out shopNumber) || shopNumber == 100000);

                            Console.Write("Choose product: 1 - furniture, 2 - parts");
                            int productTypeNumber = 0;
                            do
                            {
                                Console.Write("Product: ");
                            } while (!int.TryParse(Console.ReadLine(), out productTypeNumber) || productTypeNumber == 0);
                            switch (productTypeNumber)
                            {
                                case 1:
                                    Console.Write("Furniture Type: ");
                                    string furnitureType = Console.ReadLine();
                                    Console.Write("Furniture name: ");
                                    string furnitureName = Console.ReadLine();
                                    Console.Write("Manufacturer: ");
                                    string furnitureManuf = Console.ReadLine();
                                    Console.Write("Price: ");
                                    int furniturePrice = int.Parse(Console.ReadLine());
                                    shops[shopNumber].AddNewProduct(new Furniture(furnitureManuf, furnitureType, furnitureName, 1, furniturePrice));
                                    break;
                                case 2:
                                    Console.Write("Part Type: ");
                                    string rawType = Console.ReadLine();
                                    Console.Write("Part name: ");
                                    string rawName = Console.ReadLine();
                                    Console.Write("Dimensions: ");
                                    string rawDimensions = Console.ReadLine();
                                    Console.Write("Price: ");
                                    int rawPrice = int.Parse(Console.ReadLine());
                                    shops[shopNumber].AddNewProduct(new Furniture(rawDimensions, rawType, rawName, 1, rawPrice));
                                    break;
                            }

                        }
                        else Console.WriteLine("There isn't any shop in base");
                        break;
                    case 3:
                        foreach (Shop shop in shops)
                        {
                            shop.GetAllInfoAboutShop();
                        }
                        break;
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}

