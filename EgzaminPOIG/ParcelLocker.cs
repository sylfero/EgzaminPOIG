using System;

namespace EgzaminPOIG
{
    class ParcelLocker : Parcel
    {
        private IParcelLockerPhysical parcelLockerPhysical;

        public ParcelLocker(IPerson sender, IPerson recipient, uint weight, uint width, uint length, uint height, IParcelLockerPhysical parcelLockerPhysical)
            : base(sender, recipient, weight, width, length, height) 
        {
            this.parcelLockerPhysical = parcelLockerPhysical;
        }

        public override decimal ObliczKoszt()
        {
            decimal weightPrice = 0;
            decimal sizePrice = 0;
            foreach (var tuple in Poczta.CenaWagi)
            {
                if (weight <= tuple.Weight)
                {
                    weightPrice = tuple.Cost;
                }
            }

            foreach (var tuple in Poczta.CenaWymiar)
            {
                if (width <= tuple.X && length <= tuple.Y && height <= tuple.Z)
                {
                    sizePrice = tuple.Cost;
                }
            }

            if (weightPrice == 0 && sizePrice == 0)
            {
                Console.WriteLine("Nieprawidłowy rozmiar i masa paczki!");
                return -1;
            }
            if (weightPrice == 0)
            {
                Console.WriteLine("Nieprawidłowa masa paczki!");
                return -1;
            }
            if (sizePrice == 0)
            {
                Console.WriteLine("Nieprawidłowy rozmiar paczki!");
                return -1;
            }

            return Math.Min(weightPrice, sizePrice);
        }

        public override string GenerujListPrzewozowy()
        {
            return $"Nadawca: \n{sender} \n\nOdbiorca: \n{recipient} \n\nAdres paczkomatu: \n{parcelLockerPhysical} \n\nDataNadania: \n{postingDate.Date}";
        }
    }
}
