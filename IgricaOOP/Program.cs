using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgricaOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var kop1 = new Koplje("Hellreaver");
            var kop2 = new Koplje("Black Ice");
            var mac = new Mac("Armageddon");
            var carolija = new Carolija("Bladestorm");

            var macevalac = new Macevalac();
            var macevalac2 = new Macevalac();
            var carobnjak = new Carobnjak();

            var zmaj = new Zmaj();


            macevalac.UzmiOruzije(mac);
            macevalac.UzmiOruzije(kop2);
            macevalac.PromeniOruzije(1);


            //var bacenoOruzije = macevalac.BaciOruzije();
            //macevalac2.UzmiOruzije(bacenoOruzije);
            //Console.WriteLine(macevalac.Ranac.Count());

            //zmaj.Napad(macevalac);
            //carobnjak.Napad(zmaj);
            //macevalac.Napad(zmaj);


            var borba = new Borba(zmaj, macevalac);
            borba.Pocetak(new Random(), new Random());
            
            Console.WriteLine("Macevalac HP: " + macevalac.Helti);
            Console.WriteLine("Zmaj HP: " + zmaj.Helti);
        }
    }
}
