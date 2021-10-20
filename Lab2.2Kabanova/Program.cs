using System;

namespace Lab2._2Kabanova
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите шестизначное число:");
                int n = int.Parse(Console.ReadLine());
                if (n >= 100000 && n <= 999999)
                {
                    int a = n / 100000;
                    int b = (n / 10000) % 10;
                    int c = (n / 1000) % 10;
                    int d = (n / 100) % 10;
                    int e = (n / 10) % 10;
                    int f = n % 10;
                    if (a + b + c == d + e + f) Console.WriteLine("число счастливое");
                    else Console.WriteLine("число не счастливое");
                }
                else Console.WriteLine("число не шестизначное");                               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
       
        }
    }
}
