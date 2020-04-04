using System;
using System.Text;
using System.Text.RegularExpressions;

namespace practice6
{
    class Program
    {
        public static bool AlmostOnlyLetters(string word)
        {
            Regex regex = new Regex(@"^[A-Za-z\s]+\.$");
            Match match = regex.Match(word);

            return match.Success;
        }
        public static bool CheckPhoneNumber(string phoneNumber)
        {
            Regex regex = new Regex(@"^\+\d{2}\s(\d{3}\-){2}(\d{3})");
            Match match = regex.Match(phoneNumber);

            return match.Success;
        }
        public static string DecimalDigitInformation(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    return "Digit " + str[i] + " at position " + i;
                }
                else
                {
                    return "No digit found!";
                }
            }
            return "";
        }
        public static double NegativeOrPositive(double a)
        {
            if (a < 0)
            {
                return a * a;
            }
            return Math.Sqrt(a);
        }
        public static void ReplaceXwithY()
        {
            string str = "yellow";
            Console.WriteLine("String : " + str);
            Console.WriteLine("NewString: " + str.Replace('y', 'x'));
            str = "mushroom";
            Console.WriteLine("String : " + str);
            Console.WriteLine("NewString: " + str.Replace('y', 'x'));
        }

        public static void ToLowerOrToUpper(string a)

        {
            string[] words = a.Split(" ");
            StringBuilder str = new StringBuilder();

            for (int i = 0; i < words.Length; i++)
            {
                if (i % 2 == 0)
                {                    
                    string word = words[i].ToUpper();
                    //Console.WriteLine(word);
                    str.Append(word + " ");
                }
                else
                {
                    string word = words[i].ToLower();
                    //Console.WriteLine(word);
                    str.Append(word + " ");
                }
            }
            Console.WriteLine(str);
                          
        }

        public static string IfStartsWithLowerCase(string word)
        {
            string[] words = word.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (Char.IsLower(words[i][0]))
                {
                    words[i] = words[i].Substring(1);
                }
            }

            return String.Join(" ", words);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------Task 1-------------------");
            Console.WriteLine("She is nice. - {0}",AlmostOnlyLetters("She is nice."));
            Console.WriteLine("true 222. - {0}", AlmostOnlyLetters("true 222."));

            Console.WriteLine("-------------------Task 2-------------------");
            Console.WriteLine("+35 392-022-194 - {0}",CheckPhoneNumber("+35 392-022-194"));    // True
            Console.WriteLine("+958 28492-503 {0}",CheckPhoneNumber("+958 28492-503")); //False

            Console.WriteLine("-------------------Task 3-------------------");
            Console.WriteLine("This is 9 {0}", DecimalDigitInformation("This is 9"));
            Console.WriteLine("ABCdef {0}", DecimalDigitInformation("ABCdef"));

            Console.WriteLine("-------------------Task 4-------------------");
            Console.WriteLine("-2 = {0}", NegativeOrPositive(-2));
            Console.WriteLine("6.25 = {0}", NegativeOrPositive(6.25));

            Console.WriteLine("-------------------Task 5-------------------");
            ReplaceXwithY();

            Console.WriteLine("-------------------Task 6-------------------");
            String text = "this is it";
            Console.Write(text + " = ");
            ToLowerOrToUpper(text);

            Console.WriteLine("-------------------Task 7-------------------");
            Console.WriteLine("Alfa Beta gamma = {0}",IfStartsWithLowerCase("Alfa Beta gamma"));
        }
    }
}
