﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceClassLiberary.Model
{
    public class getIDProofsRequest
    {
        private string _franchUserID;


        public string franchUserID
        {
            get { return _franchUserID; }
            set { _franchUserID = value; }
        }

        private string _password;
        public string password
        {
            get { return _password; }
            set { _password = value; }
        }

        private string _userID;

        public string userID
        {
            get { return _userID; }
            set { _userID = value; }
        }

        private string _userKey;
        public string userKey
        {
            get { return _userKey; }
            set { _userKey = value; }
        }

        private string _userName;

        public string userName
        {
            get { return _userName; }
            set { _userName = value; }
        }


        private string _userRole;
        public string userRole
        {
            get { return _userRole; }
            set { _userRole = value; }
        }

        private string _userStatus;
        public string userStatus
        {
            get { return _userStatus; }
            set { _userStatus = value; }
        }
        private string _userType;

        public string userType
        {
            get { return _userType; }
            set { _userType = value; }
        }
        private string _studID;

        public string studID
        {
            get { return _studID; }
            set
            {
                _studID = value;
            }
        }
    }
}
