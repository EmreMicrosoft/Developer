using System;

namespace Developer.CSharp.Fundamentals
{
    public class Loops
    {
        public void ForLoop()
        {
            //for ( [variable to count iterations]; [conditions checked for] ; [code to execute every loop])
            //{
            //}

            int i;
            for (i = 0; i < 10; i++)
            {
            }

            for (var j = 0; j < 16; j++)
            {
                if (j == 12)
                {
                    break;
                }
            }

            //// http://www.learncs.org/en/For_loops
        }

        public void WhileLoop()
        {
            //while ([conditions to be checked])
            //{
            //    [Code to execute]
            //}

            var n = 0;

            while (n < 100)
            {
                n++;
            }

            //// http://www.learncs.org/en/While_loops
            //// https://www.tutorialspoint.com/csharp/csharp_while_loop.htm
        }

        public void DoWhileLoop()
        {
            //  do
            //  {
            //    statement(s);
            //  } 
            //  while (condition);


            /* local variable definition */
            var a = 10;

            /* do loop execution */
            do
            {
                Console.WriteLine("value of a: {0}", a);
                a = a + 1;
            }
            while (a < 20);

            //// https://www.tutorialspoint.com/csharp/csharp_do_while_loop.htm
        }
    }
}