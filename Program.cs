using System;
using System.IO;
using System.Security.Cryptography;

namespace cryptographer
{
    class Program
    {
        static void Main(string[] args)
        {
            string plaintext;

            Console.WriteLine("CRYPTOGRAPHER (Version 1.0)\n");
            Console.Write("Type In A Message To Encrypt: ");
            plaintext = Console.ReadLine();
        }
    }
}
