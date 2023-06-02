// ovo dodajemo radi pisanja "anotacija", npr. Required
// detaljnije na linku:
// https://learn.microsoft.com/en-us/aspnet/core/blazor/forms-and-input-components?view=aspnetcore-7.0
using System.ComponentModel.DataAnnotations;

namespace mojaBiblioteka
{
    class StudentProvjera
    {
        private int ects;
        [Required] //ovo mora ići odmah iznad SVOJSTVA (neće raditi za polje)
        [Range(0, 60, ErrorMessage = "Ects mora biti iz intervala [0, 60]")] //primjer za interval
        public int Ects
        {
            get { return ects; }
            set { ects = value; }
        }

        private string ime;
        [Required] //ovo mora ići odmah iznad SVOJSTVA (neće raditi za polje)
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        private string prezime;
        [Required] //ovo mora ići odmah iznad SVOJSTVA (neće raditi za polje)

        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        private string grad;
        // neće biti obavezno
        public string Grad
        {
            get { return grad; }
            set { grad = value; }
        }

        public StudentProvjera()
        {
            this.ime = "";
            this.prezime = "";
            this.grad = "";
            this.ects = 0;
        }
        // izrada kopije
        public StudentProvjera(StudentProvjera kopija)
        {
            this.ime = kopija.Ime;
            this.prezime = kopija.Prezime;
            this.grad = kopija.Grad;
            this.ects = kopija.Ects;
        }

        public override string ToString()
        {
            return $"{this.Ime} {this.Prezime}\nEcts: {this.Ects}, Grad: {this.Grad}";
        }
    }
}