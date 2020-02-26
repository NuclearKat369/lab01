using System;

namespace Program08
{
    class Program
    {
        static void Main(string[] args)
        {
            Alpha a = new Alpha();
            a.text = "Привет!";
            Console.WriteLine(a.text);

            Beta b = new Beta();
            b.text = "Как дела?";
            Console.WriteLine(b.text);
            Console.WriteLine(a);
            Console.WriteLine(b);

            b.text = "Хорошо";
            Console.WriteLine(b.text);
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }

    public class Alpha
    {
        protected string t;

        public virtual string text
        {
            get
            {
                return t;
            }

            set
            {
                t = value;
            }
        }

        public override string ToString()
        {
            string str = "Объект класса " + this.GetType().Name + "\nЗначение текстового поля: " + t;
            return str;
        }
    }

    public class Beta : Alpha
    {
        string s;

        public override string text
        {
            get
            {
                return t + " " + s;
            }

            set
            {
                s = value;

                int i = s.IndexOf(" ");
                if (i != -1)
                {
                    t = s.Remove(i);
                    s = s.Substring(i);
                }

                else
                {
                    t = s;
                    s = "";
                }
            }
        }

        public override string ToString()
        {
            string str = "Объект класса " + this.GetType().Name + "\nЗначение первого текстового поля: " + t +
                "\nЗначение второго текстового поля: " + s;

            return str;
        }

    }
}
