namespace EgzaminPOIG
{
    interface IPerson
    {
        string FirstName { get; }
        string LastName { get; }
        string City { get; }
        string PostalCode { get; }
        string Street { get; }
        string HomeNumber { get; }
        ushort? FlatNumber { get; }
        uint PhoneNumber { get; }
        string Email { get; }
    }
}
