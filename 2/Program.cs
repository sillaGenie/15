using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };

            string jsonString = "[{\"Id\": 1,\"Name\": \"капуста\",\"Price\": 40.35},{\"Id\": 2,\"Name\": \"морковь\",\"Price\": 15.26},{\"Id\": 3,\"Name\": \"свекла\",\"Price\": 60.58},{\"Id\": 4,\"Name\": \"лук\",\"Price\": 10.95},{\"Id\": 5,\"Name\": \"чеснок\",\"Price\": 80.65}]";
  
         Product[] products = JsonSerializer.Deserialize<Product[]>(jsonString);
            int maxI = 0;
           double max = products[0].Price;
            for (int i = 0;i < products.Length; i++)
            {
                if(products[i].Price > max)
                    max = products[i].Price;
                maxI = i;
            }
            Console.WriteLine(products[maxI].Name);
        }
    }
    class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

    }
}