using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Zajecia03_wf.Entities
{
    public class Formularz
    {
        public int FormularzId { get; set; }
        public string ImieAutora { get; set; }
        public string NazwiskoAutora { get; set; }
        public string EmailAutora { get; set; }
        public string ImieWspolautora { get; set; }
        public string NazwiskoWspolautora { get; set; }
        public string ImieOpiekuna { get; set; }
        public string NazwiskoOpiekuna { get; set; }
        public string NazwaUczelni { get; set; }
        public string AdresUczelni { get; set; }
        public string  TytulReferatu { get; set; }
        public string StreszczenieReferatu { get; set; }
    }
    public class formcontext: DbContext
    {
        public formcontext():base("formcontext")
        {
            
        }
        public DbSet<Formularz> Formularz { get; set; }
    }
}