using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgzaminPOIG
{
    class Person : IPerson
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string City { get; }
        public string PostalCode { get; }
        public string Street { get; }
        public ushort HomeNumber { get; }
        public ushort? FlatNumber { get; }
        public uint PhoneNumber { get; }
        public string Email { get; }

        public Person(string firstName, string lastName, string city, string postalCode, string street, ushort homeNumber, uint phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            City = city;
            PostalCode = postalCode;
            Street = street;
            HomeNumber = homeNumber;
            FlatNumber = null;
            PhoneNumber = phoneNumber;
            Email = null;
        }

        public Person(string firstName, string lastName, string city, string postalCode, string street, ushort homeNumber, ushort flatNumber, uint phoneNumber) 
            : this(firstName, lastName, city, postalCode, street, homeNumber, phoneNumber)
        {
            FlatNumber = flatNumber;
        }

        public Person(string firstName, string lastName, string city, string postalCode, string street, ushort homeNumber, uint phoneNumber, string email) 
            : this(firstName, lastName, city, postalCode, street, homeNumber, phoneNumber)
        {
            Email = email;
        }

        public Person(string firstName, string lastName, string city, string postalCode, string street, ushort homeNumber, ushort flatNumber, uint phoneNumber, string email) 
            : this(firstName, lastName, city, postalCode, street, homeNumber, phoneNumber)
        {
            FlatNumber = flatNumber;
            Email = email;
        }

        public override string ToString() => $"{FirstName} {LastName} \n{Street} {HomeNumber}{(FlatNumber == null ? "" : "/")}{FlatNumber} \n{City} {PostalCode} \n{PhoneNumber} {Email}"; 
    }
}
