using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rateOfPrize
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Размер премии зависит от выслуги лет. ");
            Console.Write("Продолжительность вашей работы в годах: ");
            int employ = Convert.ToInt32(Console.ReadLine());

            if ((employ < 5) & (employ >= 0))
            {
                Console.WriteLine("Премия составит 10 % от зарплаты.");
            }
            else if ((employ >=5) & (employ < 10))
            {
                Console.WriteLine("Премия составит 15 % от зарплаты.");
            }
            else if ((employ >= 10) & (employ < 15))
            {
                Console.WriteLine("Премия составит 25 % от зарплаты.");
            }
            else if ((employ >= 15) & (employ < 20))
            {
                Console.WriteLine("Премия составит 35 % от зарплаты.");
            }
            else if ((employ >= 20) & (employ < 25))
            {
                Console.WriteLine("Премия составит 45 % от зарплаты.");
            }
            else if (employ >= 25)
            {
                Console.WriteLine("Премия составит 50 % от зарплаты.");
            }

            Console.ReadKey();



        }
    }
}
