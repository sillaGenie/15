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
            
            int n = 5;
            Product[] products = new Product[n];
            int id = 1;
            for(int i = 0; i < n; i++)
            {
                Console.Write("Название: ");
                string name = Console.ReadLine();
                Console.Write("Цена: ");
                double price = Convert.ToDouble(Console.ReadLine());
                products[i] = new Product() { Id = id, Name = name, Price = price  };
                id++;
            };
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
            };

            string jsonString1 = JsonSerializer.Serialize(products,options);
            Console.Write(jsonString1);
        }
    }
    class Product
    {
   
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    
    }
 }
    
