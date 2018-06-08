using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalWalletClassLib;

namespace DigitalWalletClassLib
{
    public class User
    {
        private User usr;
        private ProjectTeam prt;

        public string _accountNo { get; set; }
        public string _firstName { get; set; }
        public string _lastName { get; set; }
        public string _phoneNo { get; set; }
        public string _userID { get; set; }
        public string _userType { get; set; }

        /*public string AccountNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNo { get; set; }
        public string UserID { get; set; }
        public string UserType { get; set; }*/

        public ProjectTeam CreateProjectTeam(string teamID, string teamName, string accountNo)
        {
            if (_userType == "Teacher")
            { 
                /*teamID = Console.ReadLine();
                teamName = Console.ReadLine();
                accountNo = Console.ReadLine();*/
                return new ProjectTeam(teamID, teamName, accountNo);
            }
            else
            {
                throw new Exception("You do not have permission to do that");
            }

        }

        public void UpdateProjectTeam(string _teamId)
        {
            if (_userType == "Teacher")
            {
                prt._teamID = Console.ReadLine();
                prt._teamName = Console.ReadLine();
                prt._accountNo = Console.ReadLine();
                //ProjectTeam(_teamId, teamName);
            }
            else
            {
                throw new Exception("You do not have permission to do that");
            }
        }

        public User(string AccountNo, string FirstName, string LastName, string PhoneNo, string UserID, string UserType)
        {
            _accountNo = AccountNo;
            _firstName = FirstName;
            _lastName = LastName;
            _phoneNo = PhoneNo;
            _userID = UserID;
            _userType = UserType;
        }

    }

}
