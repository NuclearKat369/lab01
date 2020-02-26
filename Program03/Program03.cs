using System;

namespace Program03
{
    class Program03
    {
        static void Main(string[] args)
        {
            sym x = new sym('k');
            sym y = new sym('c');

            Console.WriteLine("Введены символы: {0}, {1} ", x.ch, y.ch);

            x += y;

            Console.WriteLine("Сумма символов равна " + x.txt);

            Console.WriteLine("Введены символы: {0}, {1} ", (char)x.ch, y.ch);

            x -= y;

            Console.WriteLine("Разность кодов символов равна " + x.num);
            Console.ReadLine();
        }
    }


    class sym
    {
        public char ch;
        public string txt;
        public int num;

        public sym(char c)
        {
            ch = c;
        }

        sym(string t, char c)
        {
            ch = c;
            txt = t;
        }

        sym(int n)
        {
            num = n;
        }

        public static sym operator +(sym a, sym b)
        {
            return new sym(a.ch + "" + b.ch, a.ch);
        }

        public static sym operator -(sym a, sym b)
        {
            return new sym((int)a.ch - b.ch);
        }  
    }
}

