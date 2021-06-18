using System;

namespace HazirMetodlar1String
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken="Dersimiz CSharp, Hosgeldiniz!";
            string degisken2="dersimiz CSharp, Hosgeldiniz!";

            //lenght: karakter sayisi
            Console.WriteLine(degisken.Length);

            //ToUpper: Buyuk harfe cevirir
            //ToLower: Kucuk harfe cevirir
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat
            Console.WriteLine(String.Concat(degisken," Merhaba!"));

            // CompareTo: degiskenin karakter sayisi degisken2 nin karaker sayisina esitse 0,
            // degiskenin karakter sayisi degisken2 nin karakter sayisindan kucukse -1,
            // degiskenin karakter sayisi degisken2 nin karakter sayisindan buyukse 1 dondurur.
            Console.WriteLine(degisken.CompareTo(degisken2));

            //Compare:
            //ignore case=true: iki degiskeni kiyaslarken buyuk kucuk harf duyarsiz hale gelir.
            Console.WriteLine(String.Compare(degisken,degisken2,true));
            Console.WriteLine(String.Compare(degisken,degisken2,false));

            //Contains: Degisken icerisinde degisken2 varsa true doner
            Console.WriteLine(degisken.Contains(degisken2));

            Console.WriteLine(degisken.EndsWith("Hosgeldiniz!"));
            Console.WriteLine(degisken.StartsWith("Merhaba!"));

            //IndexOf: ilk buldugu yerin indexini doner.Bulamazsa -1 doner.
            Console.WriteLine(degisken.IndexOf("CSharp"));
            Console.WriteLine(degisken.IndexOf("Morvarid"));

            //Insert: belirtilen indexten baslayarak istenilen degeri ekler.
            Console.WriteLine(degisken.Insert(0,"Merhaba! "));

            //LastIndexOf: Belirtilen karakterin son indexini dondurur.
            Console.WriteLine(degisken.LastIndexOf("i"));


            //PadLeft:degisken2 nin soluna karakter sayisi 30 olana kadar bosluk ekler. 
            //Hangi karakteri eklemek istedigimizi de verebiliriz.
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(30, '*'));


            //PadRight:degiskenin sagina karakter sayisini 50ye tamamlayana kadar bosluk/- ekleyecek.
            Console.WriteLine(degisken.PadRight(50) + degisken2);
            Console.WriteLine(degisken.PadRight(50, '-') + degisken2);


            //Remove: istenilen indexten baslayip sonuna kadar siliyor.
            Console.WriteLine(degisken.Remove(10));
            //5.karakterden baslayip 3 karakter sil.
            Console.WriteLine(degisken.Remove(5, 3));
            //bastan 1 karakter sil.
            Console.WriteLine(degisken.Remove(0, 1));


            //Replace: CSharp yazan yeri C# olarak degistir.
            Console.WriteLine(degisken.Replace("CSharp", "C#"));
            Console.WriteLine(degisken.Replace(" ", "*"));

            //Split: degiskeni bosluk karakterlerinden ayirir ve bunlari bir diziye atar.
            //Dizinin 1.indexindeki veriyi getir.
            Console.WriteLine(degisken.Split(' ')[1]);


            //Substring: istenilen idexten itibaren string degerlerini getirir.
            Console.WriteLine(degisken.Substring(4));
            //4. indexten baslayarak 6 karakter getir.
            Console.WriteLine(degisken.Substring(4, 6));

        }
    }
}
