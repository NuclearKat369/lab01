using System;

namespace Program07
{
    class Program
    {
        static void Main(string[] args)
        {

            Alpha a = new Alpha(1234);

            Console.WriteLine(a[2]);

            Beta b = new Beta(9876, 54321);

            Console.WriteLine(b[0, 2]);
            Console.WriteLine(b[1, 3]);
            Console.WriteLine("Сумма значений полей {0} и {1} равна {2},\nв разряде 3 находится число {3}",
                b.m, b.n, (b.n+b.m), b[3]);
            Console.ReadLine();
        }
    }

    class Alpha
    {
        public int n;
              
        public Alpha(int x)
        {
            n = x;
        }
        public virtual int this[int i]
        {
            get
            {
                int k;
                k = (n / ((int)Math.Pow(10, i))) % 10;
                return k;
            }
        }
    }

    class Beta: Alpha
    {
        public int m;
        public Beta(int x, int y): base(x)
        {
            m = y;
        }
        public int this[int i, int j]
        {
            get
            {
                int k;
                if (i == 0)
                {
                    k = (n / ((int)Math.Pow(10, j))) % 10;
                }                
                else
                {
                    k = (m / ((int)Math.Pow(10, j))) % 10;
                }                
                return k;
            }
        }

        public override int this[int i] {
            get
            {
                int k;               
                k = ((m + n) / ((int)Math.Pow(10, i))) % 10;
                return k;
            }
        }
    }
}


        
        
    

