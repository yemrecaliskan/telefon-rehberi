using System;

namespace telefon_rehberi
{
    class Person
    {
        public string Name {get; set; }
        public string Surname {get; set; }
        public string PhoneNumber {get; set; }

        public Person(){}
        public Person(string name, string surname, string phoneNumber){
            this.Name = name;
            this.Surname = surname;
            this.PhoneNumber = phoneNumber;
        }
    }
}