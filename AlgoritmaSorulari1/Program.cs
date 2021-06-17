using System;

namespace AlgoritmaSorulari1
{
    class Program
    {
        static void Main(string[] args)
        {
        //    //Soru 1
        //    Console.Write("Bir sayi giriniz:");
        //    int sayi = int.Parse(Console.ReadLine());
           
        //    int sayi2 = 0;
        //    for (int i = 0; i < sayi; i++)
        //    {
        //        Console.WriteLine("{0}. sayiyi giriniz:",i+1);
        //        sayi2= int.Parse(Console.ReadLine());
        //        if(sayi2%2 == 0)
        //           Console.WriteLine(sayi2+" Cift sayidir.");
        //    }

        // //Soru 2
        //  Console.Write("Birinci sayi giriniz:");
        //  int n = int.Parse(Console.ReadLine());
        //  Console.Write("Ikinci sayi giriniz:");
        //  int m = int.Parse(Console.ReadLine());
         
        //  for (int i = 0; i < n; i++)
        //  {
        //      Console.WriteLine("{0}. sayiyi giriniz:" ,i+1);
        //      int sayi = int.Parse(Console.ReadLine());
        //      if( sayi == m||sayi%m == 0)
        //         Console.WriteLine(sayi +", " + m  + " ye tam bolunur." );
        //  }
         
        //  //Soru 3 
        //  Console.Write("Bir sayi giriniz:");
        //  int input = int.Parse(Console.ReadLine());
        //  string[] array = new string[input];
        //  for (int i = 0; i < input; i++)
        //  {
        //      Console.Write("{0}. kelimeyi giriniz:",i+1);
        //      string word = Console.ReadLine();
        //      array[i]= word;
        //  }

        //  Array.Reverse(array);
        //  foreach (var item in array)
        //  {
        //      Console.WriteLine(item);
        //  }

        Console.Write("Bir cumle yaziniz:");
        string sentence = Console.ReadLine();
        int character=0;
        foreach(var c in sentence){
            character++;
        }
        string[] words = sentence.Split(' ');
        Console.WriteLine("Cumlede gecen kelime sayisi: "+ words.Length);
        Console.WriteLine("Cumlede gecen harf sayisi ", character-(words.Length-1));
        }
    }
}
