using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers_ClassLibrary
{
    public class Bouquet
    {
        public int Price = 0;

        public Dictionary<string, int> Flowers { get; set; }

        public Bouquet()
        {
            Flowers = new Dictionary<string, int>();
        }

        public void AddFlower(Flower flower)
        {
            if (Flowers.ContainsKey(flower.Name))
            {
                this.Flowers[flower.Name]++;
                Price += flower.Price;
            }
            else
            {
                this.Flowers.Add(flower.Name, 1);
                Price += flower.Price;
            }
        }
        public string ReturnBouquet()
        {
            string result = "Bouquet contains ";
            foreach (var bouquetFlow in Flowers)
            {
                result += $"{bouquetFlow.Key} {bouquetFlow.Value}, ";
            }
            result += $" price: {Price}";
            return result;

        }
    }
}
