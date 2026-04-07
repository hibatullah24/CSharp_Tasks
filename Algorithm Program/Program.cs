using System;

namespace Algorithem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Welcome to the Algorithm Program!");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Choose a Services You Need: ");
                Console.WriteLine("1. Calculate Average");
                Console.WriteLine("2. Check if a Number is Even or Odd");
                Console.WriteLine("3. Find the Smallest Number in a List");
                Console.WriteLine("4. Count Positive and Negative Numbers");
                Console.WriteLine("5. Remove Duplicates from a List");
                Console.WriteLine("6. Find All Prime Numbers ");
                Console.WriteLine("7. Generate Multiplication Table");
                Console.WriteLine("8. Check Duplicate Value");
                Console.WriteLine("");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter How Many Numbers you Need:");
                        int n = int.Parse(Console.ReadLine());

                        int[] numbers = new int[n];

                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine("Enter Number:");
                            numbers[i] = int.Parse(Console.ReadLine());
                        }

                        int total = 0;
                        for (int i = 0; i < n; i++)
                        {
                            total += numbers[i];
                        }

                        float avg = (float)total / n;

                        Console.WriteLine("The Sum is = " + total);
                        Console.WriteLine("The Average is = " + avg);
                        break;

                    case 2:
                        Console.WriteLine("Enter Number:");
                        int number = int.Parse(Console.ReadLine());

                        if (number % 2 == 0)
                        {
                            Console.WriteLine("Even");
                        }
                        else
                        {
                            Console.WriteLine("Odd");
                        }

                        break;

                    case 3:
                        Console.WriteLine("How many Numbers you Needs:");
                        int N = int.Parse(Console.ReadLine());
                        int[] num = new int[N];

                        for (int i=0; i<N; i++)
                        {
                            Console.WriteLine("Enter Number:");
                            num[i] = int.Parse(Console.ReadLine());
                        }

                        int smallest = 0;
                        for (int i=0; i<N; i++)
                        {
                            if (num [i] < smallest)
                            {
                                smallest = num[i];
                            }
                        }

                        Console.WriteLine(" Smallest Number in the List is :" + smallest);

                        break;

                    case 4:
                        Console.WriteLine("How many Numbers you Needs:");
                        int NP = int.Parse(Console.ReadLine());
                        int[] NPnum = new int[NP];

                        for (int i = 0; i < NP; i++)
                        {
                            Console.WriteLine("Enter Number:");
                            NPnum[i] = int.Parse(Console.ReadLine());
                        }

                        int PositiveCount = 0;
                        int NegativeCount = 0;

                        for (int i = 0; i < NP; i++)
                        {
                            if (NPnum[i] > 0)
                            {
                                PositiveCount++;
                            }

                            else
                            {
                                NegativeCount++;
                            }
                        }

                        Console.WriteLine("Count of Positive Number in List is = " + PositiveCount);
                        Console.WriteLine("Count of Negative Number in List is = " + NegativeCount);

                        break;

                    case 5:
                        Console.WriteLine(" How Many Numbers you Needs:");
                        int D = int.Parse(Console.ReadLine());
                        int[] Dlist = new int[D];

                        for (int i =0; i<D; i++)
                        {
                            Console.WriteLine("Enter Number:");
                            Dlist[i] = int.Parse(Console.ReadLine());
                        }

                        int[] unique = new int[D];
                        int UnCount = 0;

                        for (int i=0; i<D; i++)
                        {
                            bool Duplicate = false;

                            for (int l=0; l<UnCount; l++)
                            {
                                if (Dlist[i] == unique[l])
                                {
                                    Duplicate = true;
                                }
                            }

                            if (Duplicate==false)
                            {
                                unique[UnCount] = Dlist[i];
                                UnCount++;
                            }
                        }

                        Console.WriteLine("List After Remove Duplicate:");
                        for (int i=0; i<UnCount; i++)
                        {
                            Console.WriteLine(unique[i] + " ");
                        }
                        
                        break;


                    case 6:
                        Console.WriteLine("Enter N:");
                        int P = int.Parse(Console.ReadLine());

                        Console.WriteLine("Prime Numbers for Selected Number are:");

                        for (int FPrime = 2; FPrime <= P; FPrime++)
                        {
                            bool isprime = true;
                            for (int div = 2; div < FPrime; div++)
                            {
                                if (FPrime % div ==0)
                                {
                                    isprime = false;

                                }
                            }

                            if (isprime == true)
                            {
                                Console.WriteLine(FPrime + " ");
                            }
                        }
                        break;


                    case 7:

                        Console.WriteLine("Enter Number:");
                        int PNum = int.Parse(Console.ReadLine());
                        int p = 1;
                        while (p <= PNum)
                        {
                            int s = 1;

                            while (s <= PNum)
                            {
                                int M = p * s;
                                Console.Write(M + " ");
                                s++;

                            }
                            Console.WriteLine();
                            p++;
                        }
                            break;

                    case 8:
                        Console.WriteLine("How Many Numbers you Needs:");
                        int DN = int.Parse(Console.ReadLine());
                        int[] DList = new int[DN];

                        for (int i = 0; i < DN; i++)
                        {
                            Console.WriteLine("Enter Number:");
                            DList[i] = int.Parse(Console.ReadLine());
                        }


                        bool hasDuplicate = false;
                        for (int i=0; i <DN; i++)
                        {
                            for (int j = i +1; j < DN; j++)
                            {
                                if (DList[i] == DList[j])
                                {

                                    hasDuplicate = true;
                                    break;

  

                                }
                            }

                        }


                        if (hasDuplicate)
                        {
                            Console.WriteLine("The List has Duplicate Values.");
                        }
                        else
                        {
                            Console.WriteLine("The List has No Duplicate Values.");
                        }
                        break;




                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }
}
