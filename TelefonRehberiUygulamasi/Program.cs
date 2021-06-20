using System;
using System.Collections.Generic;

namespace TelefonRehberiUygulamasi
{
    class Program
    {
        public static List<Person> persons;
        static void Main(string[] args)
        {
            persons = new List<Person>();

            persons.Add(new Person("Morvarid", "Inci", "589999758"));
            persons.Add(new Person("Dilek", "Okay", "58823542547"));
            persons.Add(new Person("Merve", "Kara", "5332223458"));
            persons.Add(new Person("Hatice", "Öztürk", "54782541254"));

            Menu();
        }

        public static void Menu()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek\n(2) Varolan Numarayı Silmek\n(3) Varolan Numarayı Güncellemek\n(4) Rehberi Listelemek\n(5) Rehberde Arama Yapmak\n");
            Console.Write("İşlem tercihiniz: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Add();
                    break;
                case 2:
                    Delete();
                    break;
                case 3:
                    Update();
                    break;
                case 4:
                    List();
                    break;
                case 5:
                    Search();
                    break;
                default:
                    Console.WriteLine("Hatalı giriş yaptınız!\n");
                    Menu();
                    break;
            }
        }

        public static void Add()
        {
            Console.Write("Lütfen isim giriniz: ");
            string name = Console.ReadLine();

            Console.Write("Lütfen soyisim giriniz: ");
            string surname = Console.ReadLine();

            Console.Write("Lütfen telefon numarası giriniz:");
            string phoneNumber = Console.ReadLine();

            persons.Add(new Person(name, surname, phoneNumber));
            Menu();
        }

        public static void Delete()
        {
            Console.Write("Lütfen numarısını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string personName = Console.ReadLine();

            foreach (Person person in persons)
            {
                if (person.Name == personName || person.Surname == personName)
                {
                    Console.WriteLine("{0} {1} isimli kişi rehberden silinmek üzere, onaylıyor musunuz? (y/n)", person.Name, person.Surname);
                    string input = Console.ReadLine();

                    if (input == "y")
                    {
                        persons.Remove(person);
                        Console.WriteLine("Silme işlemi başarılı.\n");
                        Menu();
                    }
                    else if (input == "n")
                    {
                        Menu();
                    }
                    else
                    {
                        Console.WriteLine("Hatalı giriş yaptınız!\n");
                        Menu();
                    }
                }
            }

            Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n* Silmeyi sonlandırmak için : (1)\n* Yeniden denemek için : (2)");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Menu();
            }
            else if (choice == "2")
            {
                Delete();
            }
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız!");
                Menu();
            }
            
        }

        public static void Update()
        {
             Console.Write("Lütfen numarısını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string personName = Console.ReadLine();

            foreach (Person person in persons)
            {
                if (person.Name == personName || person.Surname == personName)
                {
                    Console.Write("{0} {1} isimli kişinin yeni numarasını giriniz: ", person.Name, person.Surname);
                    string newNumber = Console.ReadLine();

                    person.PhoneNumber = newNumber;
                    Menu();
                }
            }

            Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n* Güncellemeyi sonlandırmak için : (1)\n* Yeniden denemek için : (2)");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Menu();
            }
            else if (choice == "2")
            {
                Update();
            }
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız!");
                Menu();
            }
        }

        public static void List()
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************");
            foreach (Person person in persons)
            {
                Console.WriteLine("İsim: {0}\nSoyisim: {1}\nTelefon Numarası: {2}\n-", person.Name, person.Surname, person.PhoneNumber);
            }

            Menu();
        }

        public static void Search()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("*********************************************");
            Console.WriteLine("\nİsim veya soyisime göre arama yapmak için : (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için : (2)");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("İsim veya soyisim giriniz: ");
                string personName = Console.ReadLine();

                foreach (Person person in persons)
                {
                    if (person.Name == personName || person.Surname == personName)
                    {
                        Console.WriteLine("İsim: {0}\nSoyisim: {1}\nTelefon Numarası: {2}\n-", person.Name, person.Surname, person.PhoneNumber);
                    }
                }

                Menu();
            }
            else if (choice == "2")
            {
                Console.Write("Telefon numarası giriniz: ");
                string phoneNumber = Console.ReadLine();

                foreach (Person person in persons)
                {
                    if (person.PhoneNumber == phoneNumber)
                    {
                        Console.WriteLine("İsim: {0}\nSoyisim: {1}\nTelefon Numarası: {2}\n-", person.Name, person.Surname, person.PhoneNumber);
                    }
                }

                Menu();
            }
            else
            {
                Console.WriteLine("Hatalı Giriş Yaptınız!\n");
                Menu();
            }
        }
    }

    

    public class Person
    {
        private string name;
        private string surname;
        private string phoneNumber;

        public Person(string name, string surname, string phoneNumber)
        {
            this.name = name;
            this.surname = surname;
            this.phoneNumber = phoneNumber;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
    }
}