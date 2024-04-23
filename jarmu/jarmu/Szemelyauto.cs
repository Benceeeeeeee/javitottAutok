using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jarmu
{
    public class Szemelyauto : Jarmu
    {
        public Szemelyauto(string gyarto, string modell, int evjarat, int alapar, int kilometeroraAllas, int ulesekszama, double fogyasztas, string szin) : base(gyarto, modell, evjarat, alapar, kilometeroraAllas)
        {
            UlesekSzama = ulesekszama;
            Fogyasztas = fogyasztas;
            Szin = szin;
        }
        public int UlesekSzama {  get; set; }
        public double Fogyasztas {  get; set; }
        public string Szin {get; set; }
        public void KenyelmiExtraBeszerzese(string extra)
        {
            Alapar += 5000;
        }

        public void SzínFrissítése(string újSzín)
        {
            Szin = újSzín;
            Console.WriteLine("Szín frissítve");
        }
    }
}
