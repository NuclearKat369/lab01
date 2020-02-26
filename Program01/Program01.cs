using System;

namespace Program01
{
    class Program01
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int n = r.Next(20);
            int[] b = new int[n];
            for (int i = 0; i < n; i++)
            {
                b[i] = r.Next(100);
            }

            MyArray z = new MyArray(b);

            Console.WriteLine("Передан массив: " + (String)z);
            int s = (int)z;
            Console.WriteLine("Сумма элементов: " + s);

            Console.WriteLine("Преобразование числа в объект: " + (String)(MyArray)r.Next(10));
            Console.ReadLine();
        }
    }

    class MyArray
    {
        static int[] arr;

        public MyArray(int [] a)
        {
            arr = a;
        }

        MyArray(int l)
        {
            int [] b = new int [l];
            for (int i = 0; i < l; i++)
            {
                b[i] = 0;
            }
            arr = b;
        }

        public static explicit operator String (MyArray obj)
        {
            String txt = "";
            for(int i = 0; i < arr.Length; i++)
            {
                txt += arr[i] + " ";
            }
            return txt;
        }

        public static explicit operator int (MyArray obj)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i]; 
            }
            return sum;
        }

        public static explicit operator MyArray(int x)
        {            
            return new MyArray(x);
        }        
    }
}
