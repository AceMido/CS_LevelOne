﻿namespace problem_0_sec7_while_loop_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("putting kanka");
            Console.WriteLine("putting coffee in a cup");
            Console.Write("how many sugar spoons do u want? ");
            int sugar = int.Parse(Console.ReadLine());

            if (sugar > 0)
            {
                int i = 1;
               while(i<=sugar)
                {
                    Console.WriteLine("putting sugar spoon number " + i);
                    i++;
                }
                Console.WriteLine("coffee is ready to serve");
            }
            else
            {
                Console.WriteLine("coffee is ready to serve");
            }

        }
    }
}