using System;


    namespace test
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Enter n: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter p: ");
                double p = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[n]; // array
                int i = 0;
                double tempSum = 0;
                double answer = 0;
                
                while (i != n) // fill arr
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                    i++;
                }
                for (int j=0;j<arr.Length;j++)
                {
                    tempSum = tempSum + (Math.Pow(arr[j],p));

                }
                answer = Math.Pow(tempSum,(1/p));
                Console.WriteLine("Answer = " + answer);
            }
            
        }
    }