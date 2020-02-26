using System;

namespace Program06
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "Hello! ", "How ", "are ", "you ", "doing?" };
            myarray a = new myarray(arr);

            Console.Write("Введён массив: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(a[i]);
            }

            Console.WriteLine();
            Console.Write("Массив после изменения элемента a[4]: ");

            a[4] = "feeling?";

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(a[i]);
            }
            
            Console.WriteLine();
            Console.WriteLine("На позиции a[1, 3] находится символ: " + a[1, 3]);
            Console.WriteLine("На позиции a[3, 2] находится символ: " + a[3, 2]);
            Console.WriteLine("На позиции a[2, 19] находится символ: " + a[2, 19]);
            Console.ReadLine();
        }
    }

    public class myarray {

        string [] text;

        public myarray(string[] t)
        {
            text = t;
        }

        public string this[int i]{

            get{

            return text[i];

            }

            set
            {
                text[i] = value;
            }
        }

        public char this[int i, int j] { 
            
            get
            {                
                char [] sym = text[i].ToCharArray();
                if (j > sym.Length-1) j %= sym.Length-1;
                if (sym[j].Equals(' ')) return '_';
                return sym[j];
            }         
        }
    }
}

