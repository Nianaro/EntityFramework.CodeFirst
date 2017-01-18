using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository context = new Repository();

            context.Publications.Add(new Publications { Id = 0, UserName = "Alexander", Comment = "Hello"});
            context.SaveChanges();

            var publications = context.Publications.ToList();

            foreach (var item in publications)
            {
                Console.WriteLine("{0}. {1} - {2}", item.Id, item.UserName, item.Comment);
            }
        }
    }
}
