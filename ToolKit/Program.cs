using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;

namespace ToolKit
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var person = new Person()
            {
                Name = "POO",
                LastName = "UAI",
                Age = 30,
                State = new State { 
                    StateId = "1",
                    StateName = "Santa Fe"
                }
            };

            Check.NotNull(person, "person");

            Console.WriteLine(string.Format("Name:{0}\nAge:{1}\n", person.Name, person.Age));
            Console.WriteLine(string.Format("State:{0}\n", person.State.StateName));

            Console.ReadKey();
        }
    }
}
