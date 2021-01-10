using System;
using System.Collections.Generic;
using System.Text;

namespace testDebogage
{
    class maClasse
    {
        public string nom { get; set; }
        public string prenom { get; set; }
        public int age { get; set; }

        public maClasse(string nom, string prenom, int age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
        }

        public override string ToString()
        {
           return ($"{nom} {prenom} {age}");
        }
    }



}
