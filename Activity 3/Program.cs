
using System;


namespace Linear
{
    class Program
    {
        int() arr = new int(20);
        int n;
        int i;

        public void input()
        { while (true)
            {
                Console.Write("enter the number of element in the array");
                string s = Console.ReadLine();
                n = int32.Parse(s);
                if ((n > 0) && (n <= 20))
                    break
                        else
                    Console.WriteLine("\nArray should have minimum  and maximum 20 element.\n");
                Console.WriteLine("");
                Console.WriteLine("==========");
                Console.WriteLine("enter array element");
                Console.WriteLine("=============");
                for (i=0; i<n;i++)
                {
                    Console.WriteLine("<" + (i+1)+ "+>");
                    string s1 = Console.ReadLine();
                    arr[i] = int.Parse(s1);
                }
                

            }
        public void BinarySeach()
        {
                Console.Write("enter element want to search")
        }
        
        }

    }
}