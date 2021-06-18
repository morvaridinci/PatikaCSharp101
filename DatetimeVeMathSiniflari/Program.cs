using System;

namespace DatetimeVeMathSiniflari
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);//gunun tarıhı saat dakıka sn
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);//gunu string olarak yazar
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());// gun ay (strıng) yıl
            Console.WriteLine(DateTime.Now.ToShortDateString());//28/05/1995
            Console.WriteLine(DateTime.Now.ToLongTimeString()); // 11:15:20 PM
            Console.WriteLine(DateTime.Now.ToShortTimeString()); // 11:15 PM

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            //format
            Console.WriteLine(DateTime.Now.ToString("dd")); //18
            Console.WriteLine(DateTime.Now.ToString("ddd")); //Sat
            Console.WriteLine(DateTime.Now.ToString("dddd")); //Saturday

            Console.WriteLine(DateTime.Now.ToString("MM")); // 04
            Console.WriteLine(DateTime.Now.ToString("MMM")); // Apr
            Console.WriteLine(DateTime.Now.ToString("MMMM")); //April

            Console.WriteLine(DateTime.Now.ToString("yy")); //21
            Console.WriteLine(DateTime.Now.ToString("yyyy")); //2021

        
            //Math Kutuphanesi

            //Mutlak Deger
            Console.WriteLine(Math.Abs(-25));

            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(10));

            //22.3 ten buyuk en kucuk tam sayiyi getir
            Console.WriteLine(Math.Ceiling(22.3));//23
            Console.WriteLine(Math.Round(22.3));//22
            Console.WriteLine(Math.Round(22.7));//23
            Console.WriteLine(Math.Floor(22.7));//22

            Console.WriteLine(Math.Max(2,6));
            Console.WriteLine(Math.Min(2,6));

            Console.WriteLine(Math.Pow(3,4)); //3 uzeri 4 
            Console.WriteLine(Math.Sqrt(9));  //karekok
            Console.WriteLine(Math.Log(9));   //log
            Console.WriteLine(Math.Exp(3));   //e uzeri 3 
            Console.WriteLine(Math.Log10(10)); //log 10 tabaninda x i verir
        }
    }
}
