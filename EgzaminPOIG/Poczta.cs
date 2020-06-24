using System.Collections.Generic;

namespace EgzaminPOIG
{
    static class Poczta
    {
        public static List<(uint Weight, decimal Cost)> CenaWagi { get; }
        public static List<(uint X, uint Y, uint Z, decimal Cost)> CenaWymiar { get; }
        private static uint number = 0;

        static Poczta()
        {
            CenaWagi = new List<(uint Weight, decimal Cost)>();
            CenaWagi.Add((1000, 15));
            CenaWagi.Add((2000, 20));
            CenaWagi.Add((5000, 27));
            CenaWagi.Add((20000, 40));

            CenaWymiar = new List<(uint X, uint Y, uint Z, decimal Cost)>();
            CenaWymiar.Add((200, 200, 50, 15));
            CenaWymiar.Add((500, 500, 200, 20));
            CenaWymiar.Add((800, 800, 800, 27));
            CenaWymiar.Add((1500, 1500, 1500, 40));
        }

        public static void SetNumber(Parcel parcel)
        {
            parcel.Number = number;
            number++;
        }
    }
}
