using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class ClaPerson
    {
        private string strENumber;
        private string strFName;
        private string strSName;
        private string strUName;
        private string strPassword;

        public void createUser(string ENumber, string FName, string SName)
        {
            //assign the base value 
            strENumber = ENumber;
            strFName = FName;
            strSName = SName;
            //create the user name
            strUName = strSName.Substring(0, 3) + strENumber;
            //define the default password
            strPassword = "College1";
        }

        public void setPassword(string PWord)
        {
            strPassword = PWord;
        }

        public Boolean checkLogin(string UName, string Pword)
        {
            //check the username and password are correct
            //if true return true
            //if false return false
            if (UName == strUName && Pword == strPassword)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string saveString()
        {
            return strENumber + "," + strFName + "," + strSName+ "," + strUName + "," + strPassword; 
        }
    }

    public class ClaPet
    {
        public string strOwner { get; set; }
        public string strPetName { get; set; }
        public string strBreed { get; set; }
        public string strCategory { get; set; }
        public DateTime datDOB { get; set; }
    }
}
