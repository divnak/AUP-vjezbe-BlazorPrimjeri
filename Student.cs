namespace mojaBiblioteka
{
    class Student
    {
        private int ects;
        public int Ects
        {
            get { return ects; }
            set { ects = value; }
        }

        private string ime;
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        private string prezime;
        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        private string grad;
        public string Grad
        {
            get { return grad; }
            set { grad = value; }
        }
        

        public Student()
        {
            this.ime = "";
            this.prezime = "";
            this.ects = 0;
            this.grad = "";
        }

        public override string ToString()
        {
            return $"{this.Ime} {this.Prezime}\nEcts: {this.Ects}, Grad: {this.Grad}";
        }
    }
}