using System;

    namespace test
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Enter length of arr (n): ");
                int n = Convert.ToInt32(Console.ReadLine());
                int i = 0;
                Console.WriteLine("Enter your arr with " + n + " numbers");
                int[] arr = new int[n]; // array

                while (i != n) // fill arr
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                    i++;
                }

                Console.Write("Enter k (k<n): ");
                int k = Convert.ToInt32(Console.ReadLine());

                
                int Min = 1000000000;
                int lastMin = 0;

                for (int tempK=1;tempK<=k;tempK++) // сколько раз нужно найти Минимальное значение массива = k, tempK - счетчик до k
                {
                    for (int j=0;j<arr.Length;j++) // поиск минимума массива
                    {
                        if(arr[j]<Min & tempK==1) // нахождение первого минимума
                        {
                            Min=arr[j];
                        }
                        if (tempK!=1 & arr[j]>lastMin) // нахождение любого по счету минимума, кроме первого(то бишь более последнего минимума)
                        {
                            if(arr[j]<Min)
                            {
                                Min=arr[j];
                            }
                        }
                        
                    }

                    lastMin = Min;
                    Min=1000000000;
                }
                Console.WriteLine("Answer = "+lastMin);
            }
        }
    }