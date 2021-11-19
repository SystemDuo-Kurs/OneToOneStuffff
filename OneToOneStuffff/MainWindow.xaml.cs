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
        }
    }
}
