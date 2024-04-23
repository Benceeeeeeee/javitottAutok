using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jarmu
{
    internal class Autoszalon
    {
        public List<Jarmu> Jarmuvek {  get; set; }
        public Autoszalon()
        {
            Jarmuvek = new List<Jarmu>();
        }
        public void UjJarmuHozzaadasa(Jarmu jarmu)
        {
            Jarmuvek.Add(jarmu);
            Console.WriteLine("jármű hozzá lett adva");
        }
        public bool JarmuEladasa(string gyarto, string modell)
        {
            Jarmu eladas = JarmuKeresese(gyarto, modell);

            if(eladas != null)
            {
                Jarmuvek.Remove(eladas);
                return true;
            }
            return false;
        }
        public Jarmu JarmuKeresese(string gyarto, string modell)
        {
            foreach (Jarmu jarmu in Jarmuvek)
            {
                if (jarmu.Gyarto == gyarto && jarmu.Modell == modell)
                {
                    return jarmu;
                }
            }
            return null;
        }
        public void JarmuvekListazasa()
        {
            foreach(var jarmu in Jarmuvek)
            {
                jarmu.JarmuInfo();
            }
        }
    }
}
