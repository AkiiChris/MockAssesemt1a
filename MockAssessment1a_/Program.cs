using System;

namespace MockAssessment1a_
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static bool IsTheSame(int num1, int num2)
        {
            if (num1 == num2)
            {
                return true;
            }
            else if (num1 != num2)
            {
                return false;
            }
            else
            {
                return false;
            }
        }

        public static double Subtract(double num1, double num2)
        {
            double result = num2 - num1;
            return result;
        }

        public static string FindBuldingType(int num1)
        {
            
            if (num1 >= 4 || num1 <= 10)
            {
               string sentence = "This is an office building!";
                return sentence;
            }
            else if (num1 >= 50)
            {
                string sentence = "This is a SUPER skyscraper!";
                return sentence;
            }
            else if (num1 >= 11 || num1 <= 49)
            {
                string sentence = "This is a skyscraper!";
                return sentence;
            }
            else if ( num1 >= 3)
            {
                string sentence = "This is a house!";
                return sentence;
            }
            else
            {
                string sentence = null;
                return sentence;
            }
           
        }

    }
}