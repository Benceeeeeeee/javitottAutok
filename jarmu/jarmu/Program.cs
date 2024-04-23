using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jarmu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Autoszalon jarmuvek = new Autoszalon();
            Szemelyauto jarmu = new Szemelyauto("Toyota", "Corolla", 2021, 8000000, 15000, 5, 6.5, "Fehér");
            jarmuvek.UjJarmuHozzaadasa(jarmu);

            Terepjaro terep = new Terepjaro("Land Rover", "Defender", 2020, 15000000, 20000, "4WD", true, 3500);
            jarmuvek.UjJarmuHozzaadasa(terep);

            jarmuvek.JarmuvekListazasa();

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("eladás");
            
            bool sikeres = jarmuvek.JarmuEladasa("Toyota", "Corolla");
            Console.WriteLine($"Autó eladása: {sikeres}");

            Jarmu defender = jarmuvek.JarmuKeresese("Land Rover", "Defender");
            if(defender != null)
            {
                Console.WriteLine("Az autó megvan");
                defender.JarmuInfo();
            }
            else
            {
                Console.WriteLine("Az autó nincs meg");
            }

            Console.WriteLine("Járművek listázása");
            jarmuvek.JarmuvekListazasa();

            if (defender != null)
            {
                Terepjaro landRover = (Terepjaro)defender;
                landRover.OffroadCsomagFelszerel();
                landRover.KmAllasFrissites(200);

                int premiumHangrendszer = 50000;
                int napfenyteto = 100000;

                int ar = landRover.Arkalkulacio() + premiumHangrendszer + napfenyteto;

                Console.WriteLine("árajánlat:");
                Console.WriteLine("Alapár: " + landRover.Arkalkulacio());
                Console.WriteLine("Prémium hangrendszer: " + premiumHangrendszer);
                Console.WriteLine("Napfénytető: " + napfenyteto);
                Console.WriteLine("Összesen: " + ar);
            }
        }
    }
}
