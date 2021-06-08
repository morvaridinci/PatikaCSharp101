using System;

namespace While_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {

           // 1'den başlayarak console'dan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp console'a yazdıran program.
            Console.Write("Lütfen bir sayı girin:");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                 toplam += sayac;
                 sayac++;   
            }
            Console.WriteLine(toplam / sayi);

            //'a' - 'z' ye kadar tüm harfleri console'a yazdır.
            char character = 'a';
            while (character <  'z')
            {
                 Console.Write(character);
                 character++;    
            }

            Console.WriteLine("");
            Console.WriteLine("***** Foreach *****");
            string[] arabalar = {"BMV", "Ford", "Toyota", "Nissan"};

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
