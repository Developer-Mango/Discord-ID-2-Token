using System;
using System.Text;

namespace ID_2_Token
{
    class Program
    {
        static void Main(string[] args)
        {
            string ID;
            Console.Write("\nEnter Users ID: ", "\n");
            ID = Console.ReadLine();

            var PlainBytes = Encoding.UTF8.GetBytes(ID);
            string EncodedBytes = Convert.ToBase64String(PlainBytes);

            Console.WriteLine("\nStart Of Token: {0}", EncodedBytes);
            Console.ReadLine();
        }
    }
}
