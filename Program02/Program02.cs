using System;

namespace Program02
{
    class Program02
    {
        static void Main(string[] args)
        {
            Overload y = new Overload(10);
            Overload z = new Overload(15);
            
            Console.WriteLine("Заданы числа {0} и {1} ", y.num, z.num);

            y += z;

            Console.WriteLine("Сказочная сумма чисел равна " + y.num);

            Console.WriteLine("\nЗаданы числа {0} и {1} ", y.num, z.num);

            z -= y;

            Console.WriteLine("Сказочная разность чисел равна " + z.num);

            Console.WriteLine("\nЗаданы числа {0} и {1} ", y.num, z.num);

            y *= z;

            Console.WriteLine("Сказочное произведение чисел равно " + y.num);
            Console.ReadLine();
        }
    }

    class Overload
    {
        public int num;

        public Overload(int x)
        {
            num = x;
        }

        public static Overload operator+(Overload a, Overload b)
        {
            return new Overload (a.num + b.num + 1);
        }

        public static Overload operator-(Overload a, Overload b)
        {
            return new Overload(a.num - b.num - 2 );
        }

        public static Overload operator*(Overload a, Overload b)
        {
            return new Overload(a.num * b.num * 2);
        }
    }
}
