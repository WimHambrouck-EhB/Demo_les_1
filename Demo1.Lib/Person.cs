using System;

namespace Demo1.Lib
{
    public class Person
    {
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }

        public Person()
        {

        }

        public Person(string voornaam, string achternaam)
        {
            Voornaam = voornaam ?? throw new ArgumentNullException(nameof(voornaam));
            Achternaam = achternaam ?? throw new ArgumentNullException(nameof(achternaam));
        }
    }
}
