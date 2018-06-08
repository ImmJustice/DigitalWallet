using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWalletClassLib
{
    public class ProjectTeam
    {
        private string _teamID { get; set; }
        private string _teamName { get; set; }
        private string _accountNo { get; set; }

        public string TeamID { get; set; }
        public string TeamName { get; set; }
        public string AccountNo { get; set; }

        public ProjectTeam(string TeamID, string TeamName, string AccountNo)
        {
            _teamID = TeamID;
            _teamName = TeamName;
            _accountNo = AccountNo;
        }

    }

}
