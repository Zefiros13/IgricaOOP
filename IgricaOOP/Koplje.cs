namespace IgricaOOP
{
    internal class Koplje : IOruzije
    {
        public string Ime { get; set; }
        public bool DaLiJeAktivno { get; set; }

        public Koplje(string ime)
        {
            Ime = ime;
        }
    }
}