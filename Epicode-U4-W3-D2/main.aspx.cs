using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Epicode_U4_W3_D2
{
    public partial class main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Controllo sessione
            if (Request.Cookies["User_Session"] == null)
                Response.Redirect("default.aspx");

            //Controllo valori application
            checkApplication();

            //Controllo disponibilita' sale
            checkAvailability();

            //Carico valori in basso
            loadValues();
        }

        protected void Aggiungi_Click(object sender, EventArgs e)
        {
            if (Ridotto.Checked)
                Application["Ridotto"] = Int32.Parse(Application["Ridotto"].ToString()) + 1;

            switch (Int32.Parse(DropDownSala.SelectedValue))
            {
                case 1:
                    Application["Nord"] = Int32.Parse(Application["Nord"].ToString()) - 1;
                    break;
                case 2:
                    Application["Est"] = Int32.Parse(Application["Est"].ToString()) - 1;
                    break;
                case 3:
                    Application["Sud"] = Int32.Parse(Application["Sud"].ToString()) - 1;
                    break;
            }

            new Biglietto(
                            Nome.Text,
                            Cognome.Text,
                            Ridotto.Checked,
                            Int32.Parse(DropDownSala.SelectedValue)
                         );
            Response.Redirect(Request.Url.ToString());

        }

        private void checkApplication()
        {
            if (Application["Ridotto"] == null)
            {
                Application["Ridotto"] = 0;
                Application["Nord"] = 120;
                Application["Est"] = 120;
                Application["Sud"] = 1;
            }
        }
        private void checkAvailability()
        {
            if (Application["Nord"].ToString() == "0")
                DropDownSala.Items[0].Enabled = false;
            if (Application["Est"].ToString() == "0")
                DropDownSala.Items[1].Enabled = false;
            if (Application["Sud"].ToString() == "0")
                DropDownSala.Items[2].Enabled = false;
        }
        private void loadValues()
        {
            Nord.InnerText = $"Posti rimanenti per la sala Nord: {Application["Nord"]}";
            Est.InnerText = $"Posti rimanenti per la sala Est:  {Application["Est"]}";
            Sud.InnerText = $"Posti rimanenti per la sala Sud:  {Application["Sud"]}";
            Rido.InnerText = $"Biglietti ridotti ventudi:        {Application["Ridotto"]}";
        }
    }
}