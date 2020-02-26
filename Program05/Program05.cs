using System;

namespace Program05
{
    class Program05
    {
        static void Main(string[] args)
        {
            int[,] a = new int[10, 5];
                        
            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    a[i, j] = r.Next(9);
                    Console.Write("{0,4}",a[i, j]);
                }
                Console.WriteLine(" | ");
            }
            
            myarray c = new myarray(a);

            Console.WriteLine(c[1,2]);
            c[1, 2] = 20;
            
            Console.WriteLine(c[1, 2]);
           
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("{0,4}", c[i, j]);
                }
                Console.WriteLine(" | ");
            }

            Console.WriteLine(c[4]);
            c[4] = 50;
            Console.WriteLine(c[4]);


            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("{0,4}", c[i, j]);
                }
                Console.WriteLine(" | ");
            }
            Console.ReadLine();
        }
    }

    class myarray
    {
        public int[,] nums;
        
        public myarray (int [,] b)
        {
            nums = b;

        }
        public int this[int i, int j]
        {
            get
            {
                int x = nums[i, j];
                return x;
            }
            set
            {
                nums[i, j] = value * 2;
            }
        }

        public int this[int i] 
        {
            get 
            {
                int max=0;
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                        if (nums[i, j] >= max) max = nums[i, j];                    
                }
                return max;
            }

            set
            {
                int max=0;
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    if (nums[i, j] >= max) max = nums[i, j];

                }

                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    if (nums[i, j] == max) nums[i, j]=value;

                }                
            }
        }           
    }
}


