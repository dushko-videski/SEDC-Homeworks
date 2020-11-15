using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Exercise.TryBeingFit.Services.Helpers
{
    public static class ValidationHelper
    {
        public static string ValidatePassword(string password)
        {
            //andrej10  and10rej
            if (password.Length < 6) return null;

            //validacija za toa dali ima bar 1 broj vo passwordot:
            int num;
            bool isNum = false;
            foreach (char item in password)
            {
                isNum = int.TryParse(item.ToString(), out num);
            }
            if (!isNum) return null;

            return password;
        }

        public static int ValidateNumber(string number, int range)
        {
            int num = 0;
            bool isNumber = int.TryParse(number, out num);
            if (!isNumber) return -1;
            if (num <= 0 || num > range) return -1;

            return num;
        }

        public static string ValidateString(string firstOrLastName)
        {
            if (firstOrLastName.Length < 2)
                return null;

            return firstOrLastName;
        }

        public static string ValidateUserName(string username)
        {
            if (username.Length < 6) 
                return null;

           return username;
        }
    }
}
