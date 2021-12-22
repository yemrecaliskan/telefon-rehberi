using System;
using System.Collections.Generic;

namespace telefon_rehberi
{
    class PhoneBook
    {
        //Telefon rehberi
        public static List<Person> phoneBook;

        static PhoneBook(){
            phoneBook = DefaultPersons();
        }

        public static List<Person> DefaultPersons()
        {
            return new List<Person>()
            {
                new Person("Yunus Emre","Çalışkan","11111"),
                new Person("Aslıhan","Atıcı","22222"),
                new Person("Elif","Bektaş","33333"),
                new Person("Can","Selek","44444"),
                new Person("Hatice","Yeşilyurt","55555")
            };
        }
    }
}