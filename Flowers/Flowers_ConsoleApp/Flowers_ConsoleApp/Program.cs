using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flowers_ClassLibrary;

namespace Flowers_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rose rose = new Rose("Rose", 45);
            Carnation carnation = new Carnation("Carnation", 30);
            Tulip tulip = new Tulip("Tulip", 28);

            Flower[] flowers = new Flower[3] { rose, carnation, tulip };

            Random rand = new Random();

            Bouquet bouquet = new Bouquet();

            Console.WriteLine("Enter number of flowers");
            int numberOfFlowers = 0;
            do
            {
                Console.Write("Amount of flowers = ");
            } while (!int.TryParse(Console.ReadLine(), out numberOfFlowers) || numberOfFlowers == 0);
            int FlowersLeft = 0;
            do
            {
                bouquet.AddFlower(flowers[rand.Next(0, 2)]);
                FlowersLeft++;
            } while (FlowersLeft < numberOfFlowers);

            Console.WriteLine(bouquet.ReturnBouquet());

            Console.ReadKey();

        }
    }
}
