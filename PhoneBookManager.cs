using System;
namespace telefon_rehberi
{
    class PhoneBookManager
    {
        public void SaveNumber(Person newPerson)
        {
            PhoneBook.phoneBook.Add(newPerson); 
            Console.WriteLine("Kişi başarıylar eklendi\n");
        }
        public void DeleteNumber(string nameSurname)
        {
            Console.WriteLine();
            int temp = 0;
            foreach (var item in PhoneBook.phoneBook)
            {
                if (nameSurname.ToLower() == item.Name.ToLower() || nameSurname.ToLower() == item.Surname.ToLower())
                {
                    temp++;
                    Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(Y/N)",item.Name);
                    string select1 = Console.ReadLine();
                    select1.ToUpper();
                    if (select1 == "Y")
                    {
                        PhoneBook.phoneBook.Remove(item);
                        Console.WriteLine("Silme işlemi başarıyla gerçekleşti.");
                        break;
                    }
                    else if(select1 == "N")
                    {
                        break;
                    }
                }
            }
            if(temp == 0){
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");
                int select = int.Parse(Console.ReadLine());
                if (select == 2)
                {
                    Program.DeleteNumber();
                }
            }
        }

        public void UpdateNumber(string nameSurname)
        {
            Console.WriteLine();
            int temp = 0;
            foreach (var item in PhoneBook.phoneBook)
            {
                if (nameSurname.ToLower() == item.Name.ToLower() || nameSurname.ToLower() == item.Surname.ToLower())
                {
                    temp++;
                    Console.WriteLine("Lütfen yeni telefon numarasını giriniz.");
                    string newNumber = Console.ReadLine();
                    item.PhoneNumber = newNumber;
                    break;
                }
            }
            if(temp == 0){
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için           : (2)");
                int select = int.Parse(Console.ReadLine());
                if (select == 2)
                {
                    Program.UpdateNumber();
                }
            }
        }
        public void ShowPhoneBook(int selected)
        {
            Console.WriteLine();
            if(selected == 1) //A-Z
            {
                PhoneBook.phoneBook.Sort((o1,o2) => o1.Name.CompareTo(o2.Name));
            }
            else if(selected == 2) //Z-A
            {
                PhoneBook.phoneBook.Sort((o1,o2) => o1.Name.CompareTo(o2.Name));
                PhoneBook.phoneBook.Reverse();
            }
            foreach (var item in PhoneBook.phoneBook)
            {
                Console.WriteLine("İsim : {0}", item.Name);
                Console.WriteLine("Soyisim : {0}", item.Surname);
                Console.WriteLine("Telefon Numarası : {0}", item.PhoneNumber);
                Console.WriteLine("-");
            }
        }

        public void SearchInPhoneBook(int selected)
        {
            Console.WriteLine();
            if (selected == 1)//isim veya soyisime göre
            {
                Console.Write("İsim veya soyisim giriniz:");
                string nameSurname = Console.ReadLine();

                Console.WriteLine("Arama sonuçlarınız:");
                Console.WriteLine("**********************************************\n");
                foreach (var item in PhoneBook.phoneBook)   //Arama sonucu listeleniyor
                {
                    if (item.Name.ToLower() == nameSurname.ToLower() || item.Surname.ToLower() == nameSurname.ToLower())
                    {
                        Console.WriteLine("İsim : {0}", item.Name);
                        Console.WriteLine("Soyisim : {0}", item.Surname);
                        Console.WriteLine("Telefon : {0}", item.PhoneNumber);
                    }
                }
            }
            else if (selected == 2) //telefon numarasina göre arama
            {
                Console.Write("Telefon numarası giriniz: ");
                string phoneNumber = Console.ReadLine();

                Console.WriteLine("Arama sonuçlarınız:");
                Console.WriteLine("**********************************************\n");
                foreach (var item in PhoneBook.phoneBook)   //Arama sonucu listeleniyor
                {
                    if (item.PhoneNumber == phoneNumber)
                    {
                        Console.WriteLine("İsim : {0}", item.Name);
                        Console.WriteLine("Soyisim : {0}", item.Surname);
                        Console.WriteLine("Telefon : {0}", item.PhoneNumber);
                    }
                }
            }
        }
    }
}