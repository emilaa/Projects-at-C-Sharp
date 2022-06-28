using System;

namespace Check_Mail
{
    class Program
    {
        static void Main(string[] args)
        {
            Mail CheckMail = new Mail();

            string mail = "cavid@code.edu.az";
            int password = 12345;

            if (Mail.CheckMail(mail, password))
            {
                Console.WriteLine("Entered");
            }
            else
            {
                Console.WriteLine("Mail or password is incorrect");
            }

        }
    }
}
