using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgricaOOP
{
    class Pauk : Cudoviste
    {
        public Pauk()
        {
            Ime = "Pauk";
            ImeSPecijalnogNapada = "Ujeda";
        }


        public override void SpecijalniNapad(Heroj heroj)
        {
            heroj.Helti -= 8;
            base.SpecijalniNapad(heroj);
        }
    }
}
