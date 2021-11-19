using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOneStuffff
{
    public class Kontekst : DbContext
    {
        public DbSet<Osoba> Osobe { get; set; }
        public DbSet<Adresa> Adrese { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = Bazzza;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Osoba>().HasKey(o => o.Id);
            modelBuilder.Entity<Adresa>().HasKey(a => a.Id);

            modelBuilder.Entity<Osoba>().HasOne(o => o.Adresa)
                .WithOne(a => a.Osoba)
                .HasForeignKey<Osoba>(o => o.Adresa_Id);

            modelBuilder.Entity<Adresa>().HasData
            (
                new Adresa[]
                {
                    new Adresa{ Grad="asd", Ulica="asdfeg", Broj="234fg", Id=-1},
                    new Adresa{ Grad="gsg4g", Ulica="a45h5yh", Broj="5", Id=-2},
                    new Adresa{ Grad="vfd", Ulica="agdsgvdvg", Broj="6", Id=-3},
                    new Adresa{ Grad="ffffff", Ulica="1fe3f", Broj="7", Id=-4},

                }
            );
            modelBuilder.Entity<Osoba>().HasData
            (
                new Osoba[]
                {
                    new Osoba{Ime="Asd", Prezime="Qwe", Id = -1, Adresa_Id=-4},
                    new Osoba{Ime="Zxc", Prezime="Hgf", Id = -2, Adresa_Id=-3},
                    new Osoba{Ime="Gfd", Prezime="Fde", Id = -3, Adresa_Id=-2},
                    new Osoba{Ime="Ert", Prezime="Zser", Id = -4, Adresa_Id=-1}
                }
            );

            base.OnModelCreating(modelBuilder);
        }

    }
}
