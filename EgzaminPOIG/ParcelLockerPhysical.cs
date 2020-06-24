namespace EgzaminPOIG
{
    class ParcelLockerPhysical : IParcelLockerPhysical
    {
        public string City { get; }
        public string PostalCode { get; }
        public string Street { get; }
        public uint Number { get; }

        public ParcelLockerPhysical(string city, string postalCode, string street, uint number)
        {
            City = city;
            PostalCode = postalCode;
            Street = street;
            Number = number;
        }

        public override string ToString()
        {
            return $"{Street} {Number} \n{City} {PostalCode}";
        }
    }
}
