using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Person1 = new Person("Armbruster", "Rick", 24);
            Console.WriteLine(Person1._Nachname);
            Person1._Nachname = "Sperzel";
            Console.WriteLine(Person1._Nachname);
            Console.ReadKey();
            Person.Nummer = 22;
            Console.WriteLine(Person.Nummer);
            Console.ReadKey();
            Person[] aperson = new Person[2];
            aperson[0] = new Person("Norbert", "hauser", 50);
            aperson[1] = new Person("gammel", "king", 33);
            Console.WriteLine(aperson[0]._Vorname);
            aperson[0]._Vorname = "franz";
            Console.WriteLine(aperson[0]._Vorname);
            Console.ReadKey();

            
        }
    }

    class Person
    {
        private string Nachname, Vorname;
        private int Alter;

        static int nummer;

        public Person(string Nachname,string Vorname,int Alter)
        {
            this.Nachname = Nachname;
            this.Vorname = Vorname;
            this.Alter = Alter;
        }

        public string _Nachname
        {
            get { return Nachname; }
            set
            {
                if(value.Length >= 3)
                {
                    Nachname = value;
                }
            }
        }
        public static int Nummer
        {
            get { return nummer; }
            set { nummer = value; }
        }

        public string _Vorname
        {
            get { return Vorname; }
            set { Vorname = value; }
        }
        public int _Alter
        {
            get { return Alter; }
            set { Alter = value; }
        }
    }
}
