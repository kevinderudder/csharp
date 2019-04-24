using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo_Features
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static IEnumerable<string> GetNames(IEnumerable<Person> people)
        {
            foreach (var p in people)
            {
                yield return GetName(p);
            }
        }

        private static string GetName(Person p)
        {
            return $"{p.FirstName} {p.MiddleName[0]} {p.LastName}";
        }
    }

    internal class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public Person(string fname, string lname)
        {
            this.FirstName = fname;
            this.LastName = LastName;
        }
        public Person(string firstname, string middlename, string lastname)
        {
            this.FirstName = firstname;
            this.MiddleName = middlename;
            this.LastName = lastname;
        }

    }

    internal class ElmosService
    {
        static Person[] employees = {
                new Person("Karin", "Works with numbers", "Van Looveren"),
                new Person("Lynn", "Wondermama van een tweeling", "Vercammen"),
                new Person("Nathalie", "Fan van Anderlecht",  "De Becker"),
                new Person("Sanne", "Proud from Limburg", "Schouteden"),
                new Person("Eddy ", "Mr Elmos", "Lambaerts"),
                new Person("Kevin ", "DeRudder"),
                new Person("Liesbeth", "Ms Elmos", "Debruyn"),
                new Person("An", "Kan alles",  "Liekens"),
                new Person("Charlotte", "Zotte doos", "Roelandt"),
                new Person("Joris", "Tennisser", "van Staay"),
                new Person("Koen", "Stamnummer 1", "Lermytte"),
                new Person("Lore", "Eet graag Oats", "Dewulf"),
                new Person("Christophe", "Ping Pong Meister", "Costa"),
                new Person("Dany", "Loper",  "Dedeurwaerder"),
                new Person("Guillaume", "Heeft alle basket data ter wereld, whaaaaat?", "Kindt"),
                new Person("Joke", "Beste dichter ter wereld", "Tange"),
                new Person("Manon", "Lacht altijd", "Hoet"),
                new Person("Marijke", "Don't stop me now", "Wouters"),
                new Person("Sébastien", "Bachelor for a few more weeks", "Stoops"),
            };

        public static IEnumerable<Person> GetElmosPeopleAtYourService()
        {
            foreach (var p in employees) yield return p;
        }

        public static async IAsyncEnumerable<Person> GetElmosPeopleAtYourServiceAsync()
        {
            foreach (var p in employees)
            {
                await Task.Delay(100);
                yield return p;
            }
        }
    }
}
