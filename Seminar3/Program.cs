using System;

namespace Seminar3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Abs(number)); //мдуль числа
            Console.WriteLine(Math.PI); //число Пи
            Console.WriteLine(Math.Sqrt(number)); //корень числа
            Console.WriteLine(Math.Round(Math.PI,3)); //округление
            Console.WriteLine(Math.Pow(number,4)); //возведение в степень
            int a = number > 1 ? number : 123; //сокращение условия if. Если значение больше 1, то значение равно 123
        }
    }
}