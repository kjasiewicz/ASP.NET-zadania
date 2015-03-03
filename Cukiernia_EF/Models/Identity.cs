using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Cukiernia_EF.Models
{
    public class Produkt
    {
        public int ProduktId { get; set; }
        public string NazwaProduktu { get; set; }
        public decimal CenaJednostkowa { get; set; }
        public int CzasPrzechowywaniaGodziny { get; set; }
        public int IloscDostepna { get; set; }
        public virtual ICollection<ElementyZamowienia> ElementyZamowienia { get; set; }
        public Produkt()
        {
            ElementyZamowienia = new List<ElementyZamowienia>();
        }
    }
    public class Zamowienia
    {
        public int ZamowieniaID { get; set; }
        public virtual Klienci Klient { get; set; }
        [ForeignKey("Klient")]
        public int KlientID { get; set; }
        public decimal WartoscZamowienia { get; set; }
        public DateTime DataZamowienia { get; set; }
        public DateTime DataRealizacji { get; set; }
        public decimal Znizka { get; set; }
        public virtual ICollection<ElementyZamowienia> ElementyZamowienia { get; set; }
        public Zamowienia()
        {
            ElementyZamowienia = new List<ElementyZamowienia>();
        }
    }
    public class Klienci
    {
        public virtual ICollection<Zamowienia> Zamowienia { get; set; }
        public Klienci()
        {
            Zamowienia = new List<Zamowienia>();
        }

        public int KlienciId { get; set; }
        public string NazwaFirmy { get; set; }
        public int NIP { get; set; }
        public string Adres { get; set; }
        public string Miasto { get; set; }
        public string Region { get; set; }
        public int Telefon { get; set; }
    }
    public class ElementyZamowienia
    {
        public int ElementyZamowieniaId { get; set; }
        public virtual Zamowienia Zamowienia { get; set; }
        [ForeignKey("Zamowienia")]
        public int ZamowienieId { get; set; }
        public virtual Produkt Produkt { get; set; }
        [ForeignKey("Produkt")]
        public int ProduktId { get; set; }
        public int Ilosc { get; set; }
        public decimal Wartosc { get; set; }        
    }

}