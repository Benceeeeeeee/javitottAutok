using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jarmu
{
    public class Terepjaro : Jarmu
    {
        public Terepjaro(string gyarto, string modell, int evjarat, int alapar, int kilometeroraAllas, string hajtas, bool offroadKepessegek, int vontatóképesség) : base(gyarto, modell, evjarat, alapar, kilometeroraAllas)
        {
            Hajtas = hajtas;
            OffroadKepessegek = offroadKepessegek;
            Vontatóképesség = vontatóképesség;
        }
        public string Hajtas {  get; set; }
        public bool OffroadKepessegek { get; set; }
        public int Vontatóképesség {  get; set; }

        public void OffroadCsomagFelszerel()
        {
            OffroadKepessegek = true;
            Alapar += 10000;
        }
        public void VontatóképességBeállítása(int képesség)
        {
            Vontatóképesség = képesség;
            Console.WriteLine("Vontatóképesség beállítva");
        }
    }
}
