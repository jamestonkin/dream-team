using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dreamteam
{
    public interface Icohort18
    {
        string Specialty { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string FullName { get; }

        void Work();
    }

    public class James : Icohort18
    {
        public string Specialty { get; set; } = "Angular";
        public string FirstName { get; set; } = "James";
        public string LastName { get; set; } = "Tonkin";
        public string FullName { get => $"{this.FirstName} {this.LastName}"; }

        public void Work()
        {
            Console.WriteLine("Eagle Eye James tests code and writes factories in Angular.");
        }

    }

    public class Jordan : Icohort18
    {
        public string Specialty { get; set; } = "Python";
        public string FirstName { get; set; } = "Jordan";
        public string LastName { get; set; } = "Nelson";
        public string FullName { get => $"{this.FirstName} {this.LastName}"; }

        public void Work()
        {
            Console.WriteLine("Writes about his love of Poland and Trump in Python.");
        }

    }

    public class Dean : Icohort18
    {
        public string Specialty { get; set; } = "WordPress";
        public string FirstName { get; set; } = "Dean";
        public string LastName { get; set; } = "Smith";
        public string FullName { get => $"{this.FirstName} {this.LastName}"; }

        public void Work()
        {
            Console.WriteLine("Loves making WordPress sites and should have named it FaceBuck.");
        }

    }

    public class Casey : Icohort18
    {
        public string Specialty { get; set; } = "JavaScript";
        public string FirstName { get; set; } = "Casey";
        public string LastName { get; set; } = "Dailey";
        public string FullName { get => $"{this.FirstName} {this.LastName}"; }

        public void Work()
        {
            Console.WriteLine("Cooking up some JavaScript");
        }

    }

    public class Dara : Icohort18
    {
        public string Specialty { get; set; } = "PHP";
        public string FirstName { get; set; } = "Dara";
        public string LastName { get; set; } = "Thomas";
        public string FullName { get => $"{this.FirstName} {this.LastName}"; }

        public void Work()
        {
            Console.WriteLine("Learning PHP and Angular 4.");
        }

    }

    public class Nick : Icohort18
    {
        public string Specialty { get; set; } = "RPG";
        public string FirstName { get; set; } = "Nick";
        public string LastName { get; set; } = "Nash";
        public string FullName { get => $"{this.FirstName} {this.LastName}"; }

        public void Work()
        {
            Console.WriteLine("Writes RPG, not role playing games.");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            James james = new James();
            Jordan jordan = new Jordan();
            Dean dean = new Dean();
            Casey casey = new Casey();
            Dara dara = new Dara();
            Nick nick = new Nick();

            List<Icohort18> serverSide = new List<Icohort18>()
            {
                jordan, dean, nick
            };

            List<Icohort18> clientSide = new List<Icohort18>()
            {
                james, casey, dara
            };

            foreach(Icohort18 person in serverSide)
            {
                person.Work();
            }

            foreach (Icohort18 person in clientSide)
            {
                person.Work();
            }

            Console.Read();
        }
    }
}
