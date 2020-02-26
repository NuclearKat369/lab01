using System;

namespace Program09
{
    class Program
    {
        static void Main(string[] args)
        {

            Alpha al = new Alpha(6);

            for (int i = 0; i < 6; i++)
            {
                Console.Write(al[i] + " ");
            }

            Console.WriteLine();
            al[4] = 30000;

            for (int i = 0; i < 6; i++)
            {
                Console.Write(al[i] + " ");
            }

            Console.WriteLine();

            Beta be = new Beta(4);
            be[0] = 'a';
            for (int i = 1; i < 4; i++)
            {
                be[i] = be[i - 1] + 2;
            }
            for (int i = 0; i < 4; i++)
            {
                Console.Write((char)be[i] + " ");
            }

            Console.WriteLine();

            be[3] = 'K';
            for (int i = 0; i < 4; i++)
            {
                Console.Write((char)be[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Размер массива в классе Alpha: " + al.len +
                "\nи массивов в классе Beta: " + string.Join(", ", be.len));
            Console.ReadLine();
        }
    }


    public class Alpha
    {
        protected int[] num;
        public Alpha(int n)
        {
            num = new int[n];
            Random r = new Random();

            for (int i = 0; i < n; i++)
            {
                num[i] = r.Next(20);
            }
        }

        public int this[int i]
        {
            get
            {
                return num[i];
            }

            set
            {
                num[i] = value;
            }
        }
        public int len
        {
            get
            {
                return num.Length;
            }
        }
    }

    public class Beta : Alpha
    {
        protected char[] sym;

        public Beta(int n) : base(10)
        {
            sym = new char[n];
        }
        public char this[int i, char c]
        {
            get
            {
                return sym[i];
            }

            set
            {
                sym[i] = c;
            }
        }

        new public int[] len
        {
            get
            {
                int[] le = new int[2];
                le[0] = num.Length;
                le[1] = sym.Length;
                return le;
            }
        }
    }
}
