using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG     ";
            string teste = "";

            Console.WriteLine('-' + original.ToLower() + '-');
            Console.WriteLine('-' + original.ToUpper() + '-');
            string s3 = original.Trim();
            Console.WriteLine('-' + s3 + '-');
            int n1 = original.IndexOf("J");
            Console.WriteLine("IndexOf J:" + n1);
            int n2 = original.LastIndexOf("bc");
            Console.WriteLine("LastIndexOf bc: " + n2);
            string s4 = original.Substring(3);
            Console.WriteLine(s4);
            string s5 = original.Substring(3, 5);
            Console.WriteLine(s5);
            string s6 = original.Replace('a', 'x');
            Console.WriteLine(s6);
            string s7 = original.Replace("abc", "xy");
            Console.WriteLine(s7);
            bool b1 = String.IsNullOrEmpty(teste);
            Console.WriteLine(b1);
            bool b2 = String.IsNullOrWhiteSpace(teste);
            Console.WriteLine(b2);


        }
    }
}
