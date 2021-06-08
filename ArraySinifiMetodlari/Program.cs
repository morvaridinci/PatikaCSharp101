using System;

namespace ArraySinifiMetodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            //sort
            int[] sayiDizisi = {23,12,4,86,72,3,11,17}; 
            Console.WriteLine("****** Sirasiz Liste *******");
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);
            
            Console.WriteLine("****** Sirali Liste *******");
            Array.Sort(sayiDizisi);

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //Clear
            Console.WriteLine("****** Array Clear *******");
            // sayiDizisi kullanarak 2. indexten itibaren 2 tane elemani sifirlar
            Array.Clear(sayiDizisi,2,2);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //Reverse
            Console.WriteLine("****** Array Reverse *******");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);
            
            // IndexOf
            Console.WriteLine("***** Array IndexOf *****");
            Console.WriteLine(Array.IndexOf(sayiDizisi, 23));

            // Resize
            Console.WriteLine("***** Array Resize *****");
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 99;

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);
        }
    }
}
