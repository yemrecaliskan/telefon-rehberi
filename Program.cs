using System;

namespace telefon_rehberi
{
    class Program
    {
        public static int selection = 0;
        static void Main(string[] args)
        {
            while (selection != 6)
            {
                Menu();
                if (selection < 0 && selection > 5)
                {
                    Console.WriteLine("Lütfen geçerli bir işlem seçiniz...");
                    selection = int.Parse(Console.ReadLine());
                }
                switch (selection)
                {
                    case 1:
                        SaveNumber();
                        break;
                    case 2:
                        DeleteNumber();
                        break;
                    case 3:
                        UpdateNumber();
                        break;
                    case 4:
                        ShowPhoneBook();
                        break;
                    case 5:
                        SearchInPhoneBook();
                        break;
                }

            }
            Console.ReadKey();
        }

        public static void Menu() //İşlemler menüsü
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            selection = int.Parse(Console.ReadLine());
        }
        public static void SaveNumber()
        {
            Console.Write("Lütfen isim giriniz             : ");
            string name = Console.ReadLine();
            Console.Write("Lütfen soyisim giriniz          : ");
            string surname = Console.ReadLine();
            Console.Write("Lütfen telefon numarası giriniz : ");
            string phoneNumber = Console.ReadLine();

            Person newPerson = new Person(name,surname,phoneNumber);
            
            PhoneBookManager manager = new PhoneBookManager();
            manager.SaveNumber(newPerson);
        }
        public static void DeleteNumber()
        {
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            string result = Console.ReadLine();

            PhoneBookManager manager = new PhoneBookManager();
            manager.DeleteNumber(result);
        }

        public static void UpdateNumber()
        {
            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
            string result = Console.ReadLine();

            PhoneBookManager manager = new PhoneBookManager();
            manager.UpdateNumber(result);
        }

        public static void ShowPhoneBook()
        {
            Console.WriteLine("(1) A-Z Listele");
            Console.WriteLine("(2) Z-A Listele");
            int select = int.Parse(Console.ReadLine());
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");
            PhoneBookManager manager = new PhoneBookManager();
            manager.ShowPhoneBook(select);
        }

        public static void SearchInPhoneBook()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************\n");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");

            int select = int.Parse(Console.ReadLine());

            PhoneBookManager manager = new PhoneBookManager();
            manager.SearchInPhoneBook(select);
        }
    }
}