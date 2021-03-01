using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgricaOOP
{
    abstract class Heroj
    {
        public int Helti { get; set; }
        public List<IOruzije> Ranac = new List<IOruzije>();
        public string Ime { get; set; }
        public IOruzije Oruzije { get; set; }

        virtual public void UzmiOruzije(IOruzije oruzije)
        {
            if (Ranac.Count == 2)
            {
                //TODO change type of exception
                throw new Exception();
            }
            else
            {
                Ranac.Add(oruzije);

                Oruzije = oruzije;

                Console.WriteLine($"[{Ime}] je pokupio [{oruzije.Ime}]");
            }
        }

        public void PromeniOruzije(int index)
        {
            if (Ranac.Count == 0)
            {
                //TODO change type of exception
                throw new Exception();
            }

            IOruzije oruzije = Ranac[index];

            if (Oruzije == oruzije)
            {
                Console.WriteLine("Vec koristite ovo oruzije");
            }
            else
            {
                Oruzije = oruzije;
            }
        }

        public IOruzije BaciOruzije()
        {
            var oruzijeZaBacanje = Oruzije;

            if (Ranac.Count == 2)
            {
                Ranac.Remove(oruzijeZaBacanje);
                Oruzije = Ranac[0];
            }
            else if( Ranac.Count == 1)
            {
                Ranac.Clear();
                Console.WriteLine("Nemate drugo oruzije.");
            }
            else
            {
                Console.WriteLine("Nemate ni jedno oruzije.");
            }

            return oruzijeZaBacanje;
        }

        abstract public void Napad(Cudoviste cudoviste);
    }
}
