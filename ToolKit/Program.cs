using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolKit
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person()
            {
              Name = "POO",
              lastName = "UAI",
              Age = 30
            };

            Console.WriteLine(string.Format("Name:{0}\nAge:{1}", person.Name, person.Age));
            Console.ReadKey();
        }
    }
}
