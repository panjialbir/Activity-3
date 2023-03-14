using System;

namespace Linaear_dan_Binary_Search
{
    class Program
    {
        //array untuk mencari
        int[] arr = new int[20];

        //element didalam array
        int n;

        //get the number of element to store in the array
        int i;

        public void input()
        {
            while (true)
            {
                Console.Write("Enter of Numbers of Element in the Array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20))
                    break;
                else
                    Console.Write("\n Array should have minimun 1 and maximum 20 element. \n");
            }

            //memasukkan element pada array
            Console.WriteLine("");
            Console.WriteLine("--------------------");
            Console.WriteLine("Enter Array Element ");
            Console.WriteLine("--------------------");

            for (i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }
        public void BinarySearch()
        {
            char ch;

            do
            {

                //memasukkan nomer element yang ingin dicari 
                Console.Write("\n Enter the Element you want to search : ");
                int item = Convert.ToInt32(Console.ReadLine());

                //penggunaan algoritma binary search
                int lowerbound = 0;
                int upperbound = 0;

                //obtained the index of the middle element in the array
                int mid = (lowerbound + upperbound) / 2;
                int ctr = 1;

                //loop the search for the element in the array
                while ((item != arr[mid]) && (ctr <= upperbound))
                {
                    if (item == arr[mid])

                        lowerbound = mid + 1;
                    else
                        upperbound = mid - 1;


                    mid = (lowerbound + upperbound) / 2;
                    ctr++;


                    if (item == arr[mid])

                        Console.WriteLine("\n" + item.ToString() + "found at position" + (mid + 1).ToString());
                    else
                        Console.WriteLine("\n" + item.ToString() + "not found in the array\n");
                    Console.WriteLine("\nNumber of Comparasion : " + ctr);


                }
                Console.WriteLine("\nContinue search (y/n) : ");
                ch = char.Parse(Console.ReadLine());
            } while ((ch == 'y'));

        }
        public void LinearSearch()
        {
            char ch;
            //search for the nummber to be search
            int ctr;
            do
            {
                //accept the number to be search
                Console.Write("\nEnter the Element you want to search : ");
                int item = Convert.ToInt32(Console.ReadLine());

                ctr = 0;
                for (i = 0; i < n; i++)
                {
                    ctr++;
                    if (arr[i] == item)
                    {
                        Console.WriteLine("\n" + item.ToString() + " found at position" + (i + 1).ToString());
                        break;
                    }
                }
                if (i == n)
                    Console.WriteLine("\n" + item.ToString() + "not found in the array");
                Console.WriteLine("\nNumber of Comparison : " + ctr);
                Console.WriteLine("\nContinue Search (y/n) : ");
                ch = char.Parse(Console.ReadLine());
            } while ((ch == 'y'));

        }



        static void Main(string[] args)
        {
            int pilihanmu;
            char ch;
            Program mylist = new Program();
            do
            {
                Console.WriteLine("Menu Pilihan");
                Console.WriteLine("======================");
                Console.WriteLine("1. Linear Search");
                Console.WriteLine("2. Binary Search");
                Console.WriteLine("3, Exit");
                Console.WriteLine("Enter your choice (1, 2, 3) : ");
                pilihanmu = Convert.ToInt32(Console.ReadLine());
                switch (pilihanmu)
                {
                    case 1:
                        Console.WriteLine("Linear Search");
                        Console.WriteLine("");
                        mylist.input();
                        mylist.LinearSearch();
                        Console.WriteLine("");
                        break;
                    case 2:
                        Console.WriteLine("Binary Search");
                        Console.WriteLine("");
                        mylist.input();
                        mylist.BinarySearch();
                        Console.WriteLine("");
                        break;
                    case 3:
                        Console.WriteLine("Exit");
                        break;
                }
                Console.WriteLine("\nPilih Menu Lagi? (y/n): ");
                ch = char.Parse(Console.ReadLine());
                Console.Clear();
            } while (ch == 'y');
        }
    }

}
