using System;

namespace EmailChecker
{
    class Program
    {
        public static bool isEmailAddress(string emailAdress)
        {
            int iAt = emailAdress.IndexOf('@');
            int iDot = emailAdress.LastIndexOf('.');
            return (iAt > 0 && iDot > iAt);
        }
        static void testEmailAddress(string emailAdress, bool expected)
        {
            bool result = isEmailAddress(emailAdress);
            if (result == expected)
            {
                Console.WriteLine("SUCCESS: " + emailAdress + " result expected: " + expected + " result was: " + result);
            }
            else
            {
                Console.WriteLine("FAIL: " + emailAdress + " result expected: " + expected + " result was: " + result);
            }
        }
        static void Main(string[] args)
        {
            testEmailAddress("irgendwas@web.de", true);
            testEmailAddress("@web.de", false);
            testEmailAddress("a.b@test.de", true);
            testEmailAddress("test@eins.zwei.de", true);
            testEmailAddress("a@.e", false);
            //Console.WriteLine(isEmailAddress(""));
        }
    }
}

