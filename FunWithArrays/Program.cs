using System;

namespace FunWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Arrays *****");
            SimpleArrays();
            Console.ReadLine();
        }

        static void SimpleArrays()
        {
            Console.WriteLine("=> Simple Array Creation.");
            //Create an array of ints containing 3 elements indexed 0, 1, 2
            int[] myInts = new int[3];
            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;

            //Now print each value.
            foreach(int i in myInts)
                Console.WriteLine(i);
            Console.WriteLine();

            //Create a 100 item string array, indexed 0 - 99
            string[] booksOnDotNet = new string[100];
            Console.WriteLine();
        }
    }
}
