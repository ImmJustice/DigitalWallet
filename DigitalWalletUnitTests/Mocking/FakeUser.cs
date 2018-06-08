using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalWalletClassLib;

namespace DigitalWalletUnitTests.Mocking
{
    class FakeUser : User
    {
        public FakeUser(string AccountNo, string FirstName, string LastName, string PhoneNo, string UserID, string UserType) : base (AccountNo, FirstName, LastName, PhoneNo, UserID, UserType)
        {

        }
    }
}
