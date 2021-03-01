using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgricaOOP
{
    class Borba
    {
        public Cudoviste Cudoviste { get; set; }
        public Heroj Heroj { get; set; }

        public Borba(Cudoviste cudoviste, Heroj heroj)
        {
            Cudoviste = cudoviste;
            Heroj = heroj;
        }

        public void Pocetak(Random randomNapadac, Random randomCudovisteNapad)
        {
            while (Cudoviste.Helti > 0 || Heroj.Helti > 0)
            {
                if (randomNapadac.Next(0, 100) <= 50)
                {
                    Heroj.Napad(Cudoviste);
                    if (Cudoviste.Helti <= 0)
                    {
                        Console.WriteLine($"[{Heroj.Ime}] je pobednik u duelu sa [{Cudoviste.Ime}]!");
                        break;
                    }
                }
                else
                {
                    Cudoviste.Napad(Heroj, randomCudovisteNapad);
                    if (Heroj.Helti <= 0)
                    {
                        Console.WriteLine($"[{Cudoviste.Ime}] je pobednik u duelu sa [{Heroj.Ime}]!");
                        break;
                    }
                }
            }
        }
    }
}
