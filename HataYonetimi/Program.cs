using System;

namespace HataYonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            //// try - Hata olmasi muhtemel, guvence altina almak istenilen kod blogu yazilir.
            // try
            // {
            //     Console.WriteLine("Bir sayı giriniz");
            //     int sayi = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine("girmis oldugunuz sayi:" +sayi);
            // }
            // // catch - Hata yakalandiginda ne yapmak isteniyorsa o yazilir.
            // catch (Exception ex)
            // {
            //     Console.WriteLine("Hata"+ex.Message.ToString());
            //     throw;
            // }
            // // finally - Hata olsun olmasin,kosuldan bagimsiz calismasini istenilen kod blogu yazilir.
            // // optional
            // finally{
            //      Console.Write("Islem tamamlandi");
            // }


            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-20000000000");
            }
            catch (ArgumentNullException ex) 
            {
                Console.WriteLine("Bos deger girdiniz!");
                Console.WriteLine(ex);
                throw;
            }
             catch (FormatException ex) 
            {
                Console.WriteLine("Veri tipi uygun degil!");
                Console.WriteLine(ex);
                throw;
            }
              catch (OverflowException ex) 
            {
                Console.WriteLine("Cok buyuk yada cok kucuk deger girdiniz!");
                Console.WriteLine(ex);
                throw;
            }
            finally{
                Console.WriteLine("Islem basariyla tamamlandi");
            }
            
        }
    }
}
