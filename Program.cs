using System;

namespace IkiSayidanBüyüğünüBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Birinci sayiyi giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ikinci sayiyi giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            if (sayi1 > sayi2)
            {
                Console.WriteLine("Birinci sayi büyüktür");
            }
            else if(sayi2 == sayi1)
            {
                Console.WriteLine("Iki sayi esittir");
            }
            else
            {
                Console.WriteLine("Ikinci sayi büyüktür");
            }
        }
    }
}
