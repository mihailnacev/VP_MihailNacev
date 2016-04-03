using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _141142_MihailNacev_ITLab1
{
    class Agencija {
        ArrayList salteri;

        public Agencija() {
            salteri = new ArrayList(3);
            for (int i = 0; i < 3; i++) salteri.Add(new Salter(i+1));
        }

        public Salter getSalter(int i){
            return (Salter)salteri[i-1];
        }

        public void printALL(string vremeOd,string vremeDo) {
            for (int i = 0; i < 3; i++) {
                Console.WriteLine("Salter broj {0}",i+1);
                Salter s= (Salter)salteri[i];
                s.printUsluzeni(vremeOd, vremeDo);
            }
        }

        public Int32 vkPrometAgencija() {
            Int32 vkPrometAgen = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Salter broj {0}", i + 1);
                Salter s = (Salter)salteri[i];
                vkPrometAgen += s.presmetajVkPromet("00:00:00","23:59:59");
            }
            return vkPrometAgen;
        }

        public double odnosKlienti() {
            Int32 brUsluzeni = 0;
            Int32 brNeUsluzeni = 0;
            for (int i = 0; i < 3; i++)
            {
                 Salter s = (Salter)salteri[i];
                brUsluzeni += s.brUsluzeni();
                brNeUsluzeni += s.brNeUsluzeni();
            }
            return brUsluzeni / (double)(brUsluzeni + brNeUsluzeni);
        }
    }

    class Korisnik {
        string ime;
        string prezime;
        Int32 godini;
        Int32 brSalter;
        string destinacija;
        public  Int32 cenaNaKarta;
        public TimeSpan vreme;

        public Korisnik(string ime, string prezime, Int32 godini, Int32 brSalter, string destinacija,TimeSpan vreme) {
            this.ime = ime;
            this.prezime = prezime;
            this.godini = godini;
            this.brSalter = brSalter;
            this.destinacija = destinacija;
            cenaNaKarta = 1000* destinacija.Length;
            this.vreme = vreme;
        }

        override
        public string ToString() {
            return String.Format("{0} {1} {2}   {3}" ,ime,prezime,vreme,cenaNaKarta);
        }
    }

    class Salter {
        int brSalter;
        ArrayList usluzeniKorisnici;
        ArrayList neusluzeniKorisnici;
        HashSet<string> destinacii;
        int brProdadeniKarti;

        public Salter(int brSalter) {
            this.brSalter = brSalter;
            usluzeniKorisnici = new ArrayList();
            neusluzeniKorisnici = new ArrayList();
            destinacii = new HashSet<string>();
            mozniDestinacii();
            brProdadeniKarti = 0;
        }

        public void mozniDestinacii() {
            destinacii.Add("Rim");
            destinacii.Add("London");
            destinacii.Add("Tokio");
            destinacii.Add("Sofija");
            destinacii.Add("Istambul");
            destinacii.Add("Toronto");
            destinacii.Add("Majami");
            destinacii.Add("Zagreb");
            destinacii.Add("Belgrad");
            destinacii.Add("Moskva");
        }
        public void addCustomer(Korisnik korisnik,string destinacija) {
            if (containsDestinacija(destinacija))
            {
                usluzeniKorisnici.Add(korisnik);
                brProdadeniKarti++;
            }
            else {
                neusluzeniKorisnici.Add(korisnik);
            }
        }

        public bool containsDestinacija(string destinacija)
        {
            bool flag = false;
            foreach (string str in destinacii)
            {
                if (str.CompareTo(destinacija) == 0) { flag = true; break; }
            }
            return flag;
        }

        public Int32 brProdadeniKartiVremenskiInterval(string vremeOd,string vremeDo) {
            Int32 brProdadeni = 0;
            foreach (Korisnik k in usluzeniKorisnici){
                if (k.vreme.ToString().CompareTo(vremeOd) >= 0 && k.vreme.ToString().CompareTo(vremeDo) <= 0) {
                    brProdadeni++;
                }
            }
            return brProdadeni;
        }

        public Int32 presmetajVkPromet(string vremeOd, string vremeDo)
        {
            Int32 vkPromet = 0;
            foreach (Korisnik k in usluzeniKorisnici)
            {
                if (k.vreme.ToString().CompareTo(vremeOd) >= 0 && k.vreme.ToString().CompareTo(vremeDo) <= 0)
                {
                    vkPromet += k.cenaNaKarta;
                }
            }
            return vkPromet;
        }

        public void printUsluzeni(string vremeOd, string vremeDo)
        {
            Int32 brojac = 1;
            foreach (Korisnik k in usluzeniKorisnici) {
                if (k.vreme.ToString().CompareTo(vremeOd) >= 0 && k.vreme.ToString().CompareTo(vremeDo) <= 0)
                {
                    Console.WriteLine("{0}. {1}", brojac++, k.ToString());
                }
            }
        }

        public ArrayList getUsluzeni() {
            return usluzeniKorisnici;
        }

        public Int32 brUsluzeni() {
            Int32 brUsluzeni = 0;
            foreach (Korisnik k in usluzeniKorisnici)
            {
                brUsluzeni++;
            }
            return brUsluzeni;
        }

        public Int32 brNeUsluzeni()
        {
            Int32 brNeUsluzeni = 0;
            foreach (Korisnik k in neusluzeniKorisnici)
            {
                brNeUsluzeni++;
            }
            return brNeUsluzeni;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dobredojdovte vo agencijata World!!!");
            Agencija agencija = new Agencija();
            while (true)
            {
                Console.WriteLine("Pocetno Menu!!!");
                Console.WriteLine("Pritisnete 1-Kupuvanje na karta||2-brProdadeniKarti (na Salter) (vo daden vo vremenski interval)||3-vkupen promet (na salter) (vo daden vremenski interval)||4-Site prodadeni karti na agencijata, organizirani po salter (vo daden vremenski opseg)||5-Vkupen promet na agencijata||6-Uspesnost na agencijata(Odnos:brUsluzeni/vkBroj)||7-Izlez");
                Int32 izbor = Convert.ToInt32(Console.ReadLine());
                if (izbor == 1) {
                    Console.WriteLine("1-Kupuvanje na karta");
                    Console.WriteLine("Vnesete ime i prezime(oddeleni so prazno mesto)");
                    String vlez1 = Console.ReadLine();
                    char[] separator = {' '};
                    string[] myWords = vlez1.Split(separator);
                    string ime = myWords[0];
                    string prezime = myWords[1];
                    Console.WriteLine("Vnesete gi vasite godini(vozrast)!");
                    Int32 godini = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Vnesete broj na salter:1 2 ili 3");
                    Int32 brSalter = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Vnesete destinacija kade sakate da patuvate");
                    string destinacija = Console.ReadLine();
                    DateTime data = DateTime.Now;
                    TimeSpan timeOfDay = data.TimeOfDay;
                    Korisnik korisnik = new Korisnik(ime,prezime,godini,brSalter,destinacija,timeOfDay);
                    Console.WriteLine(korisnik.ToString());
                    agencija.getSalter(brSalter).addCustomer(korisnik, destinacija);
                }

                if (izbor == 2) { 
                    Console.WriteLine("Vnesi broj na salter");
                    Int32 brSalter= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Vnesi vremeOD i VremeDo(oddeleni so zapirka, vo sledniot format hh:mm:ss)");
                    string vlez1 = Console.ReadLine();
                    char[] separator = {','};
                    string[] myWords = vlez1.Split(separator);
                    string vremeOd = myWords[0];
                    Console.WriteLine("VremeOD:{0}",vremeOd);
                    string vremeDo = myWords[1];
                    Console.WriteLine("VremeDo:{0}", vremeDo);
                    Console.WriteLine("Brojot na prodadeni karti na salterot {0} vo periodot od {1} do {2} iznesuva {3}.", brSalter, vremeOd, vremeDo, agencija.getSalter(brSalter).brProdadeniKartiVremenskiInterval(vremeOd,vremeDo));

                }

                if (izbor == 3) {
                    Console.WriteLine("3-vkupen promet (na salter) (vo daden vremenski interval)");
                    Console.WriteLine("Vnesi broj na salter");
                    Int32 brSalter = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Vnesi vremeOD i VremeDo(oddeleni so zapirka, vo sledniot format hh:mm:ss)");
                    string vlez1 = Console.ReadLine();
                    char[] separator = { ',' };
                    string[] myWords = vlez1.Split(separator);
                    string vremeOd = myWords[0];
                    Console.WriteLine("VremeOD:{0}", vremeOd);
                    string vremeDo = myWords[1];
                    Console.WriteLine("VremeDo:{0}", vremeDo);
                    Console.WriteLine("Vkupniot promet na salterot {0} vo periodot od {1} do {2} iznesuva {3}.",brSalter,vremeOd,vremeDo,agencija.getSalter(brSalter).presmetajVkPromet(vremeOd,vremeDo));

                }

                if (izbor == 4) {
                    Console.WriteLine("4 - Site prodadeni karti na agencijata, organizirani po salter (vo daden vremenski opseg)");
                    Console.WriteLine("Vnesi vremeOD i VremeDo(oddeleni so zapirka, vo sledniot format hh:mm:ss)");
                    string vlez1 = Console.ReadLine();
                    char[] separator = { ',' };
                    string[] myWords = vlez1.Split(separator);
                    string vremeOd = myWords[0];
                    Console.WriteLine("VremeOD:{0}", vremeOd);
                    string vremeDo = myWords[1];
                    Console.WriteLine("VremeDo:{0}", vremeDo);
                    agencija.printALL(vremeOd,vremeDo);
                }
                if (izbor == 5) {
                    Console.WriteLine("Vkupniot promet na agencijata iznesuva {0}.",agencija.vkPrometAgencija());
                }
                if (izbor == 6) {
                    Console.WriteLine("6-Uspesnost na agencijata(Odnos:brUsluzeni/vkBroj)");
                    Console.WriteLine("Odnosot iznesuva {0}",agencija.odnosKlienti());

                }
                if (izbor == 7) {
                    Console.WriteLine("Doviduvanje!!!");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
