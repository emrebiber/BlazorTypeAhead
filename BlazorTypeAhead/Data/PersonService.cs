using System.Collections.Generic;

namespace BlazorTypeAhead.Data
{
    public class PersonService
    {
        public List<Person> GetPeople()
        {
            var people = new List<Person>
            {
                new Person() { Id = 1, Name = "Jerry Parker", EmailAdress = "nelda2013@hotmail.com" },
                new Person() { Id = 2, Name = "Paula T Squires", EmailAdress = "leanne.lesc7@hotmail.com"},
                new Person() { Id = 3, Name = "Harvey J Smith", EmailAdress = "maxwell1990@gmail.com"},
                new Person() { Id = 4, Name = "Janelle D Carroll", EmailAdress = "maude.ander1@yahoo.com"},
                new Person() { Id = 5, Name = "Amanda Hogan", EmailAdress = "rosemary2009@hotmail.com"},
                new Person() { Id = 6, Name = "Logan Strother", EmailAdress = "aiden2016@gmail.com"},
            };

            return people;
        }
    }
}
