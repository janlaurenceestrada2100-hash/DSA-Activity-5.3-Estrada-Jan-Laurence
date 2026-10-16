using System;
using System.Collections.Generic;

namespace DSA_Activity_53_Estrada_JanLaurence
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
             * DSA ACTIVITY 5.3 - ESTRADA JAN LAURENCE
             * PROGRAM DESCRIPTION
             * SIMPLE GAME PROGRAMME
             */
            try
            {

                var p1 = new Stack<int>();
                var p2 = new Stack<int>();

                for (int i = 0; i < 10; i++)
                {
                    Random rnd = new Random();
                    p1.Push(rnd.Next(1, 10));
                    p2.Push(rnd.Next(1, 10));
                }
                for (int i = 0; i < 10; i++)
                {

                }
                Console.WriteLine("WELCOME TO MY SIMPLE GAME PROGRAM");
                Console.WriteLine();

                Console.Write("Player A: ");
                foreach (int i in p1) { Console.Write(i + " "); }

                Console.WriteLine();

                Console.Write("Player B: ");
                foreach (int i in p2) { Console.Write(i + " "); }

                Console.WriteLine();
                Console.WriteLine();

                int c = 0;

                while (p1.Count() != 0 && p2.Count() != 0)
                {

                        Console.WriteLine($"Match {c++}");
                        Console.WriteLine($"{p1.Peek()} vs {p2.Peek()}");
                        if (p1.Peek() != p2.Peek())
                        {
                            if (p1.Peek() > p2.Peek())
                            {
                                Console.WriteLine("Player A Win");
                                p2.Pop();
                                Console.WriteLine();

                            }
                            else
                            {
                                Console.WriteLine("Player B Win");
                                p1.Pop();
                                Console.WriteLine();

                            }
                        }
                        else
                        {
                            Console.WriteLine("Rematch");
                            p1.Pop();
                            p2.Pop();
                            Console.WriteLine();

                        }
                    

                }
                Console.WriteLine("Final Result: ");
                Console.WriteLine();

                Console.Write("Player A: ");
                foreach (int i in p1) { Console.Write(i + " "); }

                Console.WriteLine();

                Console.Write("Player B: ");
                foreach (int i in p2) { Console.Write(i + " "); }
                Console.WriteLine();
                Console.WriteLine();

                if (p1.Count() > p2.Count())
                {
                    Console.WriteLine("Player A Win");
                }
                else
                {
                    Console.WriteLine("Player B Win");
                }
                Console.WriteLine();

                Console.WriteLine("Thank You For Using The Program");


            }

            catch (Exception e)
            {
                Console.WriteLine("Error Encountered " + e.ToString());
            }
            finally
            {
                Console.ReadKey();
            }


        }

    }

}

