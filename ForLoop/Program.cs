using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ekrandan girilen sayiya kadar olan tek sayilari ekrana yazdir.

            Console.Write("Bir sayi giriniz:");
            // ReadLine string okur.Bu yuzden int e cevirdik. 
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayac; i++)
            {
                //komutlar
                if(i%2 == 1)
                   Console.WriteLine(i);
            }


            // 1-1000 arasindaki tek ve cift sayilari toplayip ekrana yazdir.
            int ciftToplam=0;
            int tekToplam=0;
            for (int i = 0; i <=1000; i++)
            {
                if(i%2 == 1){
                    tekToplam+=i;
                }else{
                    ciftToplam+=i;
                }
            }
            Console.WriteLine("Tek sayilarin toplami:" + tekToplam);
            Console.WriteLine("Cift sayilarin toplami:" + tekToplam);


            // break , continue
            for (int i = 1; i < 10; i++)
            {
                if(i == 4)
                   //break;
                   continue;
                Console.WriteLine(i);
            }
        }
    }
}
