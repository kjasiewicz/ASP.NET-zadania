using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Cukiernia_EF.Models
{
    public class CukierniaDbContext:DbContext
    {
        public CukierniaDbContext():base("CukierniaDbContext")
        {

        }
        public virtual DbSet<Produkt> Produkty { get; set; }
        public virtual DbSet<Zamowienia> Zamowienia { get; set; }
        public virtual DbSet<ElementyZamowienia> ElementyZamowienia { get; set; }
        public virtual DbSet<Klienci> Klienci { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); 
            base.OnModelCreating(modelBuilder);
        }

        public class CukierniaInitializer : DropCreateDatabaseAlways<CukierniaDbContext>
        {
            protected override void Seed(CukierniaDbContext context)
            {
                //context.Klienci.Add(new Klienci() { 
                //Adres="Partyzantów",
                //NazwaFirmy="blabla",
                //Miasto="Kety",
                //NIP= 1254789,
                //Region="malopolska",
                //Telefon= 506320031,                
                //});
                //context.Produkty.Add(new Produkt()
                //{
                //    CenaJednostkowa = 5.00m,
                //    CzasPrzechowywaniaGodziny = 24,
                //    ElementyZamowienia = new List<ElementyZamowienia>() {
                //        new ElementyZamowienia{                           
                //            Ilosc=5,                            
                //            Wartosc=25.00m
                //        }                                                       
                //    },
                //    IloscDostepna= 20,
                //    NazwaProduktu= "Ciasto2"                    
                //});
                //context.Zamowienia.Add(new Zamowienia()
                //{
                //    DataRealizacji=new DateTime(2014,9,22),
                //    DataZamowienia= new DateTime(2014,9,21),
                    
                    

                //});
                context.ElementyZamowienia.Add(new ElementyZamowienia()
                {
                    Ilosc = 10,
                    Produkt = new Produkt
                    {
                        CenaJednostkowa = 5.00m,
                        CzasPrzechowywaniaGodziny = 24,
                        IloscDostepna = 20,
                        NazwaProduktu = "Ciasto2"
                    },
                    Wartosc = 50.00m,
                    Zamowienia = new Zamowienia
                    {
                        DataRealizacji = new DateTime(2014, 9, 22),
                        DataZamowienia = new DateTime(2014, 9, 21),
                        Klient = new Klienci {
                            Adres = "Partyzantów",
                            NazwaFirmy = "blabla",
                            Miasto = "Kety",
                            NIP = 1254789,
                            Region = "malopolska",
                            Telefon = 506320031
                        },
                        WartoscZamowienia= 50.00m,
                        Znizka=0
                    }
                    
                });
                context.SaveChanges();
                base.Seed(context);
            }
        }
    }
}