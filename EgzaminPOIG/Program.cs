using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgzaminPOIG
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Jan", "Kowalski", "Bytom", "41-936", "Gombrowicza", 12, 5, 555666777, "f@gmail.com");
            Console.WriteLine(p);
            Console.ReadKey();
        }
    }
}
