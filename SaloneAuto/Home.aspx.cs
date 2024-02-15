using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace SaloneAuto
{
    public partial class Home : System.Web.UI.Page
    {
        public class Auto
        {
            public string Nome { get; set; }
            public double PrezzoBase { get; set; }
            public string ImmagineUrl { get; set; }
        }

        private List<Auto> autoDisponibili = new List<Auto>
        {
            new Auto { Nome = "Lamborghini", PrezzoBase = 70000, ImmagineUrl = "Content/img/Lambo.jpeg" },
            new Auto { Nome = "BMW", PrezzoBase = 45000, ImmagineUrl = "Content/img/BMW.jpg" },
            new Auto { Nome = "Mustang", PrezzoBase = 20000, ImmagineUrl = "Content/img/Mustang.jpg" },
            new Auto { Nome = "Panda", PrezzoBase = 3000, ImmagineUrl = "Content/img/Panda.jpeg" },
            new Auto { Nome = "Mercedes", PrezzoBase = 35000, ImmagineUrl = "Content/img/Mercedes.jpeg" },
        };

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                foreach (Auto auto in autoDisponibili)
                {
                    ddlAuto.Items.Add(new ListItem(auto.Nome, auto.Nome));
                }
                ddlAuto_SelectedIndexChanged(sender, e);
            }
        }

        protected void ddlAuto_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetCampi();
            string autoSelezionata = ddlAuto.SelectedValue;

            Auto auto = autoDisponibili.Find(a => a.Nome == autoSelezionata);

            lblPrezzoBase.InnerText = auto.PrezzoBase.ToString("C");
            imgAuto.ImageUrl = auto.ImmagineUrl;
        }

        protected void btnStampa_Click(object sender, EventArgs e)
        {

            double totaleOptional = 0;
            if (chkOptional1.Checked)
                totaleOptional += 5000;
            if (chkOptional2.Checked)
                totaleOptional += 1500;
            if (chkOptional3.Checked)
                totaleOptional += 200;

            lblTotaleOptional.InnerText = totaleOptional.ToString("C");

            int anniGaranzia = Convert.ToInt32(ddlGaranzia.SelectedValue);
            double totaleGaranzia = anniGaranzia * 120;
            lblTotaleGaranzia.InnerText = totaleGaranzia.ToString("C");

            double prezzoBase = double.Parse(lblPrezzoBase.InnerText, System.Globalization.NumberStyles.Currency);
            double totaleComplessivo = prezzoBase + totaleOptional + totaleGaranzia;
            lblTotaleComplessivo.InnerText = totaleComplessivo.ToString("C");
        }
        protected void ResetCampi()
        {
            lblPrezzoBase.InnerText = "";
            imgAuto.ImageUrl = "";
            lblTotaleOptional.InnerText = "";
            lblTotaleGaranzia.InnerText = "";
            lblTotaleComplessivo.InnerText = "";

            chkOptional1.Checked = false;
            chkOptional2.Checked = false;
            chkOptional3.Checked = false;

            ddlGaranzia.SelectedIndex = 0;
        }

    }
}