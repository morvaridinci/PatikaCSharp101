using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;
            
            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak ayindasiniz!");
                    break;
                case 2:
                    Console.WriteLine("Şubat ayindasiniz!");
                    break;
                case 3:
                    Console.WriteLine("Mart ayindasiniz!");
                    break;
                case 4:
                    Console.WriteLine("Nisan ayindasiniz!");
                    break;
        
                case 5:
                    Console.WriteLine("Mayıs ayindasiniz!");
                    break;

                case 6:
                    Console.WriteLine("Haziran ayindasiniz!");
                    break;

                //  18 gibi bir sayi girilirse default calisacak
                default:
                    Console.WriteLine("Yanlıs veri girdiniz!");
                    break;
            }

            switch (month)
            { 
                // Bu uc ay geldiginde ayni kod blogu calisacak
                case 12:
                case 1:
                case 2:
                      Console.WriteLine("Kis ayindasiniz!");
                      break;
                case 3:
                case 4:
                case 5:
                      Console.WriteLine("Ilkbahar ayindasiniz!");
                      break;
                case 6:
                case 7:
                case 8:
                      Console.WriteLine("Yaz ayindasiniz!");
                      break;
                case 9:
                case 10:
                case 11:
                      Console.WriteLine("Sonbahar ayindasiniz!");
                      break;
                default:
                break;
            }
        }
    }
}
