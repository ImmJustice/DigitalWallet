﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalWalletClassLib;

namespace DigitalWalletClassLib
{
    public class User
    {
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

        public ProjectTeam CreateProjectTeam()
        {
            if (_userType == "Teacher")
            {
                return new ProjectTeam("1111", "salt lake", "0000");
            }
            else
            {
                throw new Exception("You do not have permission to do that");
            }

        }

        /*public void UpdateProjectTeam(string _teamId)
        {
            if (_userType == Teacher)
            {
                ProjectTeam();
            }
            else
            {
                throw new Exception("You do not have permission to do that");
            }
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
