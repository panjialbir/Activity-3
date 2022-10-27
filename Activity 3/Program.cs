
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
                Console.Write("enter element want to search");
                int item = Convert.ToInt32(Console.ReadLine());
                int lowerbound = 0;
                int upperbound = 0;
                int mid = (lowerbound + upperbound / 2);
                int ctr = 1;
                while ((item = arr[mid]) && (ctr <= upperbound))
                {
                    if (item == arr[mid])
                        lowerbound = mid + 1;
                    else
                        upperbound = mid = 1;
                    mid = (lowerbound + upperbound) / 2;
                    ctr++    
                }
                if (item = arr[mid])
                    Console.WriteLine("\n" + item.ToString() + "found at position" + (mid + 1).ToString());
                else
                    Console.WriteLine("\n" + item.ToString() + "not found in the array\n ");
                Console.WriteLine("\nNumber of comparasion : " + ctr);
                Console.Write("\nContinue search (y/n):");
                ch = char.Parse(Console.ReadLine().ToUpper());

        }while ((char == 'y')) ;
        
        }
        public void Linear()
        {
            char ch;
            Console.WriteLine("\nEnter element you want to search:");
            int item = Convert.ToInt32((Console.ReadLine()));
            Ctr = 0;
            for(i = 0; i<n; i++)
            {
                Ctr++;
                if (arr[i] == item)
                {
                    Console.WriteLine("\n" + item.ToString() + "found dt position" + (i + 1.ToString()));
                    break
                }
            }
            if (i == n)
                Console.WriteLine("\n" + item.ToString() + "not found");
            Console.WriteLine("\nNumber of comparasion:" + ctr);
            Console.WriteLine("\nContinue search (y/n):");
            ch = char.Parse(Console.ReadLine().ToUpper());
        }while((ch =='y'));
    }
    public void main(string[] args)
    {
        Console.WriteLine
    }
}