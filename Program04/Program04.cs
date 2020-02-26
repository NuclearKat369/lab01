using System;

namespace Program04
{
    class Program04
    {
        static void Main(string[] args)
        {   
            posit x = new posit();

            x[0] = 1544;
            x[1] = 66;
            x[2] = 557;
            x[3] = 4878;
            x[4] = 443;
            x[5] = 9;

            Console.WriteLine(x);
            Console.ReadLine();
        }
    }

    public class posit
    {
        uint num, t = 0;
                
        public uint this[int k]
        {                     
            set
            {
                num = (uint)((value%10) * Math.Pow(10, k));
                t += num;
            }

        }  
        
        public override String ToString()
        {
            return "Получилось число " + t;
        } 
    }
}


