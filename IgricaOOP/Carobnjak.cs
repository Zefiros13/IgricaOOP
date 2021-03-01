using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgricaOOP
{
    class Carobnjak : Heroj
    {
        public Carobnjak()
        {
            Helti = 150;
            Ime = "Carobnjak";
        }

        public override void UzmiOruzije(IOruzije oruzije)
        {
            if (oruzije is Mac || oruzije is Koplje)
            {
                throw new Exception();
            }

            base.UzmiOruzije(oruzije);
        }

        public override void Napad(Cudoviste cudoviste)
        {
            cudoviste.Helti -= 20;
            Console.WriteLine($"[{Ime}] je napao [{cudoviste.Ime}] pomocu [carolije]");
        }
    }
}
