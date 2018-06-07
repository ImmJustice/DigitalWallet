using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitialWalletClassLib
{
    public class User
    {
        private string _accountNo;
        private string _firstName;
        private string _lastName;
        private string _phoneNo;
        private string _userID;
        private string _userType;

        public string AccountNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNo { get; set; }
        public string UserID { get; set; }
        public string UserType { get; set; }

        /*public CreateProjectTeam()
        {
            if (_userType == Teacher)
            {
                ProjectTeam();
            }
            else
            return MessageBox.Show("You do not have permission to do that");
            
        }

        public UpdateProjectTeam()
        {
            if (_userType == Teacher)
            {
                ProjectTeam(_teamId);
            }
            else MessageBox.Show("You do not have permission to do that");
        }*/

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
