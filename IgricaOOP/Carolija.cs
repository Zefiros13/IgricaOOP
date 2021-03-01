namespace IgricaOOP
{
    internal class Carolija : IOruzije
    {
        public string Ime { get; set; }
        public bool DaLiJeAktivno { get; set; }

        public Carolija(string ime)
        {
            Ime = ime;
        }
    }
}