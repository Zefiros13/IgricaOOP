using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgricaOOP
{
    class Macevalac : Heroj
    {
        public Macevalac()
        {
            Helti = 100;
            Ime = "Macevalac";
        }

        public override void UzmiOruzije(IOruzije oruzije)
        {
            if (oruzije is Carolija)
            {
                throw new Exception();
            }

            base.UzmiOruzije(oruzije);
        }

        public override void Napad(Cudoviste cudoviste)
        {
            if (Oruzije is Koplje)
            {
                cudoviste.Helti -= 15;
                Console.WriteLine($"[{Ime}] je napao [{cudoviste.Ime}] pomocu [koplja]");
            }
            else if (Oruzije is Mac)
            {
                cudoviste.Helti -= 10;
                Console.WriteLine($"[{Ime}] je napao [{cudoviste.Ime}] pomocu [maca]");
            }
            else
            {
                Console.WriteLine("Macevalac nema oruzije");
            }
        }
    }
}
