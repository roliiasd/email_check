using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email
{
    public class Email_Validator
    {
        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return false;
            }
            int atIndex = email.IndexOf('@');
            if (atIndex <= 0 || atIndex != email.LastIndexOf('@'))
            {
                return false;
            }
            string localPart = email.Substring(0, atIndex);
            string domainPart = email.Substring(atIndex+1);
            if (string.IsNullOrEmpty(localPart) || string.IsNullOrEmpty(domainPart))
            {
                return false;
            }

            int dotIndex = email.LastIndexOf('.');

            if (dotIndex <= 0 || dotIndex == domainPart.Length - 1)
            {
                return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
        }
    }
}
