using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingRegistrationForm.Core.entity
{

    public class RegistrationData : Fields
    {
        private List<String> roles = new List<String>();
        //{
        //    Roles.CREATE, Roles.DELETE
        //};

        public RegistrationData(String Email, String FirstName, String LastName, String Password, String ConfirmPassword, String Phone, String OrgName) : base(Email, FirstName, LastName, Password, ConfirmPassword, Phone, OrgName)
        {
        }

        public static RegistrationData GetStandardData()
        {
            return new RegistrationData("test@gmail.com", "Testing", "User", "test", "test", "+380639992211", "Testing User");
        }
        public static RegistrationData GetStandardDataWithoutEmail()
        {
            return new RegistrationData("", "Testing", "User", "test", "test", "+380639992211", "Testing User");
        }
        public static RegistrationData GetStandardDataWithoutFirstName()
        {
            return new RegistrationData("test@gmail.com", "", "User", "test", "test", "+380639992211", "Testing User");
        }
        public static RegistrationData GetStandardDataWithoutLastName()
        {
            return new RegistrationData("test@gmail.com", "Testing", "", "test", "test", "+380639992211", "Testing User");
        }
        public static RegistrationData GetStandardDataWithoutPassword()
        {
            return new RegistrationData("test@gmail.com", "Testing", "User", "", "test", "+380639992211", "Testing User");
        }
        public static RegistrationData GetStandardDataWithoutConfirmPassword()
        {
            return new RegistrationData("test@gmail.com", "Testing", "User", "test", "", "+380639992211", "Testing User");
        }
        public static RegistrationData GetStandardDataWithoutPhone()
        {
            return new RegistrationData("test@gmail.com", "Testing", "User", "test", "test", "", "Testing User");
        }
        public static RegistrationData GetStandardDataWithoutOrgName()
        {
            return new RegistrationData("test@gmail.com", "Testing", "User", "test", "test", "+380639992211", "");
        }

        public static RegistrationData GetWeakPassword()
        {
            return new RegistrationData("test@gmail.com", "Testing", "User", "test", "", "+380639992211", "Testing User");
        }

        public static RegistrationData GetNormalPassword()
        {
            return new RegistrationData("test@gmail.com", "Testing", "User", "test123", "", "+380639992211", "Testing User");
        }

        public static RegistrationData GetStrongPassword()
        {
            return new RegistrationData("test@gmail.com", "Testing", "User", "test123!@#$", "", "+380639992211", "Testing User");
        }
        public static RegistrationData GetPhoneWithWrongFormat()
        {
            return new RegistrationData("test@gmail.com", "Testing", "User", "test", "test", "+38(063)999-22-11", "Testing User");
        }
        public static RegistrationData GetPhoneWithLessNumbers()
        {
            return new RegistrationData("test@gmail.com", "Testing", "User", "test", "test", "+3", "Testing User");
        }
        public static RegistrationData GetRegistrationWithSpaces()
        {
            return new RegistrationData(" ", " ", " ", " ", " ", " ", " ");
        }
    }
}

