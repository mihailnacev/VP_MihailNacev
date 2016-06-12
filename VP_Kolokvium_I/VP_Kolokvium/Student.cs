using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VP_Kolokvium
{
    public class Student
    {
        public string ime;
        public string prezime;
        public string indeks;
        public List<Predmet> lista;

        public Student(string ime,string prezime,string indeks) {
            this.ime = ime;
            this.prezime = prezime;
            this.indeks = indeks;
            lista = new List<Predmet>();
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}",ime,prezime,indeks);
        }
    }
}
