using System;
using System.Linq;

namespace EFNew
{
    class Program
    {
         static FruitsContext context = new FruitsContext();
        static void Main(string[] args)
        {

            //context.Database.EnsureDeleted();
            //context.Database.EnsureCreated();
            Addfruits();
            Displyafruits();
            
        }

        private static void Displyafruits()
        {
            foreach (var item in context.Fruits.OrderBy(x => x.Name))
            {
                Console.WriteLine(item.Name + " " + item.Id + " " + item.Price);
            }

        }

        public static void Addfruits()
        {
            
            var f = new Fruit()
            {
                Name = "äpple",
                Price = 11.3m

            };
            context.Fruits.Add(new Fruit { Name = "orange", Price = 11.3m });
            context.SaveChanges();
        }
    }
}
