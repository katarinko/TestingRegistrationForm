using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestingRegistrationForm.Core.entity
{
    public class Fields
    {
        private String Email;
        private String FirstName;
        private String LastName;
        private String Password;
        private String ConfirmPassword;
        private String Phone;
        private String OrgName;

        public Fields(String Email, String FirstName, String LastName, String Password, String ConfirmPassword, String Phone, String OrgName)
        {
            this.Email =Email;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Password = Password;
            this.ConfirmPassword = ConfirmPassword;
            this.Phone = Phone;
            this.OrgName = OrgName;
    }

       public String GetEmail()
        {
            return Email;
        }
        public String GetFirstName()
        {
            return FirstName;
        }
        public String GetLastName()
        {
            return LastName;
        }
        public String GetPassword()
        {
            return Password;
        }
        public String GetConfirmPassword()
        {
            return ConfirmPassword;
        }
        public String GetPhone()
        {
            return Phone;
        }
        public String GetOrgName()
        {
            return OrgName;
        }




    }
}

