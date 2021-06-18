using System;
using System.Collections;
using System.Collections.Generic;

namespace Array_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();

            /*
            liste.Add("Ayşe");
            liste.Add(2);
            liste.Add(true);
            liste.Add('A');
            Console.WriteLine(liste[1]);
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
            */

            Console.WriteLine("***** Add Range *****");
            //string[] renkler = {"kirmizi","sari","yesil"};
            List<int> sayilar = new List<int>(){1,8,3,7,9,92,25};
            //liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("***** Sort *****");
            //siralama
            //siralama icin int32 olmali
            liste.Sort();

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("***** Binary Search *****");
            Console.WriteLine(liste.BinarySearch(9));

            Console.WriteLine("***** Reverse ******");
            //ortadan ayirip aynaliyor.
            liste.Reverse();

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("***** Clear *****");
            liste.Clear();

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
        }
    }
}