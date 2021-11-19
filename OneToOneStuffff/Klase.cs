using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOneStuffff
{
    public class Osoba
    {
        public int Id;
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public Adresa Adresa { get; set; }
        public int Adresa_Id { get; set; }
    }
    
    public class Adresa
    {
        public int Id;
        public string Grad { get; set; }
        public string Ulica { get; set; }
        public string Broj { get; set; }

        public Osoba Osoba;

    }
}
