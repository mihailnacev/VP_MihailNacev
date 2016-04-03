using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    enum PasswordStrenght {
        easy = 1,
        normal = 2,
        hard = 3
    }
    class Program
    {
        static string generatePassword(PasswordStrenght passwordStrenght) {
            string sodrzina = "" ;
            int dolzina = 0;
            Random generator = new Random();
            if (passwordStrenght.Equals(PasswordStrenght.easy)) {
                sodrzina = "abcdefghijklmnopqrstuvwxyz";
                dolzina = 6;
            }
            if (passwordStrenght.Equals(PasswordStrenght.normal)) {
                sodrzina = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
                dolzina = generator.Next(6, 10);
            }
            if (passwordStrenght.Equals(PasswordStrenght.hard)) {
                sodrzina = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!@#$%^&*";
                dolzina = generator.Next(10, 13);
            }
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < dolzina;i++)
            {
                sb.Append(sodrzina[generator.Next(0,sodrzina.Length-1)]);
            }
            return sb.ToString();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Tri tipa na password- 1(easy), 2(normal), 3(hard)!!!");
            Console.WriteLine("Izgenerirani se tri tipa na lozinki!!!");
            //Za da pravam sporedba gi pecatam password-ite
            string generatedPassword1 = generatePassword(PasswordStrenght.easy);
            Console.WriteLine("Prvata generirana lozinka: {0}", generatedPassword1);
            string generatedPassword2 = generatePassword(PasswordStrenght.normal);
            Console.WriteLine("Vtorata generirana lozinka: {0}", generatedPassword2);
            string generatedPassword3 = generatePassword(PasswordStrenght.hard);
            Console.WriteLine("Tretata generirana lozinka: {0}", generatedPassword3);
            Console.WriteLine("Vnesi tri lozinki za sporedba, odeleni so prazno mesto.");
            string passLine = Console.ReadLine();
            char[] delimiter = {' '};
            string[] parts = passLine.Split(delimiter);
            bool[] flags = new bool[3];
            for (int i = 0; i < 3; i++) {
                flags[i] = false;
            }
            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i].Equals(generatedPassword1)) { Console.WriteLine("Ja pogodivte prvata lozinka!"); flags[0] = true; }
                if (parts[i].Equals(generatedPassword2)) { Console.WriteLine("Ja pogodivte vtorata lozinka!"); flags[1] = true; }
                if (parts[i].Equals(generatedPassword3)) { Console.WriteLine("Ja pogodivte tretata lozinka!"); flags[2] = true; }
            }
            for (int i = 0; i < 3; i++)
            {
                if (flags[i] == false) Console.WriteLine("Ja promasivte {0}-tata lozinka!",i+1);
            }
            Console.ReadKey();



        }
    }
}
