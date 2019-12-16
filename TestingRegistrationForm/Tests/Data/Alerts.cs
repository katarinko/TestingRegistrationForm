using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingRegistrationForm.Tests.Data
{
    public class Alerts
    {
        public const string errorEmptyMessage = "Field cannot be empty";
        public const string assertEmptyMessage = "Field cannot be empty message should be displayed and registration is unavailable";
        public const string errorConfirmPasswordMessage = "The password and confirmation password do not match";
        public const string assertErrorConfirmPasswordMessage = "The password and confirmation password do not match message should be displayed and registration is unavailable";
        public const string welcomePageMessage = "WELCOME";
        public const string passwordStrengtWeakMessage = "Password strength: weak";
        public const string passwordStrengtNormalMessage = "Password strength: normal";
        public const string passwordStrengtStrongMessage = "Password strength: strong";
        public const string errorPhoneFormatMessage = "Phone field should use format: +380639992211";

    }
}
