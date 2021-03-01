namespace IgricaOOP
{
    internal class Mac : IOruzije
    {
        public string Ime { get; set; }
        public bool DaLiJeAktivno { get; set; }

        public Mac(string ime)
        {
            Ime = ime;
        }
    }
}