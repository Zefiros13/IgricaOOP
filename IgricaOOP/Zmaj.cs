using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgricaOOP
{
    class Zmaj : Cudoviste
    {
        public Zmaj()
        {
            Ime = "Zmaj";
            ImeSPecijalnogNapada = "BljujeVatru";
        }

        public override void SpecijalniNapad(Heroj heroj)
        {
            heroj.Helti -= 20;
            base.SpecijalniNapad(heroj);
        }
    }
}
