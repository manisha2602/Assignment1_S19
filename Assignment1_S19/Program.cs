using System;
using System.Diagnostics;

namespace Assignment1_S19
{
    class Program
    {
        public static void Main()
        {
            int a = 5, b = 15;
            printPrimeNumbers(a, b);
            Console.ReadKey(true);

            int n1 = 5;
            double r1 = getSeriesResult(n1);
            Console.WriteLine("The sum of the series is: " + r1);
            Console.ReadKey(true);

            long n2 = 15;
            long r2 = decimalToBinary(n2);
            Console.WriteLine("Binary conversion of the decimal number " + n2 + " is: " + r2);
            Console.ReadKey(true);


            long n3 = 1111;
            long r3 = binaryToDecimal(n3);
            Console.WriteLine("Decimal conversion of the binary number " + n3 + " is: " + r3);
            Console.ReadKey(true);


             int n4 = 5;
             printTriangle(n4);

            Console.ReadKey(true);

             int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2};
             computeFrequency(arr);
             Console.ReadKey(true);

            // My basics for c# programming are clear now. This was a good assignment to brush up
            //my programming skills and getting into track for bigger challenges.

        }

        public static void printPrimeNumbers(int x, int y)
        {
            try
            {
                
                for(int i =x; i<=y;i++)
                {

                    if (IsPrime(i) == true)    //if a number is prime than only it is printed
                        Console.WriteLine(i);
                    
                }
               
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()"+ex);
            }
        }
        public static Boolean IsPrime(int n)  //function to find if the no. is prime or not
        {
            int f=0; // to count factors
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    f++;
            }

            if (f == 2) //prime no. has only two factors
                return true;
            else
                return false;
          

        }

        public static double getSeriesResult(int n)
        {
            double s = 0;  
            try
            { 
                for (int i = 1; i <= n; i++)
                {

                    double f = 1;     //factorial varialble
                    double j = i;
                    while (j != 0)   //loop to count factorial
                    {
                        f = f * j;
                        j--;
                    }
                    if (i % 2 == 1)  //subtracting if number is odd
                        s = s + (f / (i + 1));
                    else            // adding if number is even
                        s = s - (f / (i + 1));
                }

            }
           
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }

            return Math.Round(s,3);   // rounding the sum to 3 decimal places and returning the output
        }
        public static long decimalToBinary(long n)
        {
            string b = "";   //string to concatenate the binary result
            try
            {
                long rem = 0;   
                long n1 = n;
                
                while(n1 != 0)
                {
                    rem = n1 % 2;   //remainder for binary digit
                    b = rem + b;
                    n1 = n1 / 2;   //storing quotient for next iteration
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing decimalToBinary()");
            }

            return Convert.ToInt64(b);  //converting string output to long
        }

        public static long binaryToDecimal(long n)
        {
            long dec = 0;
            try
            {
                long n1 = n;
                long p = 1;
                long rem = 0;
                
                while (n1 != 0)
                {
                    rem = n1 % 10;     //getting the last digit
                    dec = dec + rem * p;
                    p = p * 2;         //increasing power of 2 by 1
                    n1 = n1 / 10;      //remaining quotient for next iteration
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing binaryToDecimal()");
            }

            return dec;
        }
        public static void printTriangle(int n)
        {
            try
            {
               for(int i = 0;i<=n;i++)     //outer loop for number of lines
                {
                    for (int j = n-i; j > 1; j--) //loop to print spaces before printing *
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j <= (2*i)-1; j++)  //loop to print stars
                    {
                        Console.Write("*");
                    }
                    Console.Write('\n');
                }
                
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }
        public static void computeFrequency(int[] a)
        {
            Console.WriteLine("Number  Frequency");  //to print the heading of output
            try
            {
                int n = a.Length;
                Boolean[] counted = new Boolean[n]; //boolean array to find if no. is counted or not
              //  for (int i = 0; i < n; i++)
               // {
               //     counted[i] = false;
              //  }
                    for (int i = 0; i < n;i++)
                {
                    if (counted[i] == true)
                        continue;    // if no. is alreadey counted than continue to next
                    int f = 1;
                    for (int j = i + 1; j < n; j++)  //loop to count the frequency of a number in an array
                    {
                        if (a[i] == a[j])
                        {
                            counted[j] = true;
                            f++;
                        }
                        
                    }
                    Console.WriteLine(a[i] + "       " + f);
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            }
        }

    }
}

