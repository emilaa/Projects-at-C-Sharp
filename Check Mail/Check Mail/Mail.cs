using System;
using System.Collections.Generic;
using System.Text;

namespace Check_Mail
{
    public class Mail
    {
        public static bool CheckMail(string m, int p)
        {
            string mail = "cavid@code.edu.az";
            int password  = 12345;

            if (mail == "cavid@code.edu.az" && password == 12345)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
