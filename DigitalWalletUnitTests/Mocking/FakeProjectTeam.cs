using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalWalletClassLib;

namespace DigitalWalletUnitTests.Mocking
{
    class FakeProjectTeam : ProjectTeam
    {
        public FakeProjectTeam(string TeamID, string TeamName, string AccountNo) : base (TeamID, TeamName, AccountNo)
        {

        }
    }
}
