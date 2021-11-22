using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OneToOneStuffff
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Kontekst _kon = new();

        public MainWindow()
        {
            InitializeComponent();

            _kon.Database.EnsureCreated();

            /*Adresa a = new Adresa { Broj = "13/a/31", Ulica = "Mehmeda Alibasica", Grad = "NP" };
            _kon.Add(new Osoba { Ime = "Pera", Prezime = "Peric", Adresa = a });

            _kon.SaveChanges();*/

            List<Osoba> osobe = _kon.Osobe.ToList();

            _kon.Adrese.ToList();

            var knji = new Knjiga { Naziv = "Teeest" };
            osobe.First().Knjige.Add(knji);

            var rac = new Racun();
            var art = new Artikal { Naziv = "Test", Cena = (decimal)45.50 };
            var art2 = new Artikal { Naziv = "Test2", Cena = (decimal)55.50 };
            rac.AKR.Add(new ArtikalKaRacunu { Artikal = art, Kolicina = 5 });
            rac.AKR.Add(new ArtikalKaRacunu { Artikal = art2, Kolicina = 1 });
            _kon.Add(rac);

            _kon.SaveChanges();
        }
    }
}
