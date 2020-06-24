using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgzaminPOIG
{
    interface IPerson
    {
        string FirstName { get; }
        string LastName { get; }
        string City { get; }
        string PostalCode { get; }
        string Street { get; }
        ushort HomeNumber { get; }
        ushort? FlatNumber { get; }
        uint PhoneNumber { get; }
        string Email { get; }
    }
}
