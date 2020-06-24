using System;
using System.Collections.Generic;

namespace EgzaminPOIG
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Jan", "Kowalski", "Bytom", "41-936", "Gombrowicza", "12c", 5, 555666777, "mail@gmail.com");
            Person p2 = new Person("Andrzej", "Nowak", "Bytom", "41-933", "Tysiąclecia", "8", 12, 111222333);
            ParcelLockerPhysical l = new ParcelLockerPhysical("Bytom", "41-902", "Wrocławska", 438);
            List<Parcel> list = new List<Parcel>();
            list.Add(new Courier(p1, p2, 100, 100, 100, 100));
            list.Add(new Courier(p1, p2, 2000, 100, 100, 100));
            list.Add(new Courier(p1, p2, 100, 800, 100, 100));
            list.Add(new Courier(p1, p2, 10000000, 1000000, 100, 100));
            list.Add(new CourierExpress(p1, p2, 100, 100, 100, 100));
            list.Add(new CourierExpress(p1, p2, 2000, 100, 100, 100));
            list.Add(new CourierExpress(p1, p2, 100, 800, 100, 100));
            list.Add(new CourierExpress(p1, p2, 100, 1000000, 100, 100));
            list.Add(new ParcelLocker(p1, p2, 100, 100, 100, 100, l));
            list.Add(new ParcelLocker(p1, p2, 2000, 100, 100, 100, l));
            list.Add(new ParcelLocker(p1, p2, 100, 800, 100, 100, l));
            list.Add(new ParcelLocker(p1, p2, 10000000, 100, 100, 100, l));
            list.ForEach(x => Console.WriteLine(x.ObliczKoszt()));
            Console.WriteLine();
            list.ForEach(x => Console.WriteLine(x.Number));
            Console.WriteLine();
            Console.WriteLine(list[0].GenerujListPrzewozowy());
            Console.WriteLine("---------");
            Console.WriteLine(list[4].GenerujListPrzewozowy());
            Console.WriteLine("---------");
            Console.WriteLine(list[8].GenerujListPrzewozowy());
            Console.ReadKey();
        }
    }
}
