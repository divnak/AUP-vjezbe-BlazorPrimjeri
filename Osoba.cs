namespace mojaBiblioteka
{
    class Osoba
    {
        public string ime;
        public int godina;
        public Osoba()
        {
            this.ime = "Pero";
            this.godina = 2000;
        }

        // za izradu kopije osobe
        public Osoba(Osoba kopija)
        {
            this.ime = kopija.ime;
            this.godina = kopija.godina;
        }

        public int Dob()
        {
            int danas = DateTime.Now.Year;
            return danas - this.godina;
        }

        // override metode ToString
        public override string ToString()
        {
            return $"{this.ime}, {this.godina} (Dob: {this.Dob()})";
        }
    }
}