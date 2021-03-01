using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgricaOOP
{
    abstract class Cudoviste
    {
        public int Helti { get; set; }
        public string Ime { get; set; }
        public string ImeSPecijalnogNapada { get; set; }

        public Cudoviste()
        {
            Helti = 200;
        }

        private void Udara(Heroj heroj)
        {
            heroj.Helti -= 5;
            Console.WriteLine($"[{Ime}] je napao [{heroj.Ime}] pomocu [obicnog napada]");
        }

        virtual public void SpecijalniNapad(Heroj heroj)
        {
            Console.WriteLine($"[{Ime}] je napao [{heroj.Ime}] pomocu [{ImeSPecijalnogNapada}]");
        }

        public void Napad(Heroj heroj, Random random)
        {
            if (random.Next(0, 100) <= 50)
            {
                Udara(heroj);
            }
            else
            {
                SpecijalniNapad(heroj);
            }
        }
    }
}
