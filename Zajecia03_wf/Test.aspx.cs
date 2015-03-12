using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Zajecia03_wf.Entities;

namespace Zajecia03_wf
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var x = new formcontext())
            {
                var q = x.Formularz.Select(j => j).ToList();
                Repeater1.DataSource = q;
                Repeater1.DataBind();
            }
        }
        protected void Zapisz(object sender, EventArgs e)
        {
            using (var x = new formcontext())
            {
                x.Formularz.Add(new Formularz
                {
                    AdresUczelni = AdresSzkoly.Text,
                    EmailAutora = EmailAutora.Text,
                    ImieAutora = ImieAutora.Text,
                    ImieOpiekuna = ImieOpiekuna.Text,
                    ImieWspolautora = ImieWspolautora.Text,
                    NazwaUczelni = NazwaSzkoly.Text,
                    NazwiskoAutora = NazwiskoAutora.Text,
                    NazwiskoOpiekuna = NazwiskoOpiekuna.Text,
                    NazwiskoWspolautora = NazwiskoWspolautora.Text,
                    StreszczenieReferatu = StreszczenieReferatu.Text,
                    TytulReferatu = TytulReferatu.Text
                });
                x.SaveChanges();

                var q = x.Formularz.Select(j => j).ToList();
                Repeater1.DataSource = q;
                Repeater1.DataBind();
            }
        }
        protected void CzyscForme()
        {
            ImieAutora.Text = String.Empty;
            ImieOpiekuna.Text = String.Empty;
            ImieWspolautora.Text = String.Empty;
            NazwaSzkoly.Text = String.Empty;
            NazwiskoAutora.Text = String.Empty;
            NazwiskoOpiekuna.Text = String.Empty;
            NazwiskoWspolautora.Text = String.Empty;
            StreszczenieReferatu.Text = String.Empty;
            TytulReferatu.Text = String.Empty;
        }
    }
}