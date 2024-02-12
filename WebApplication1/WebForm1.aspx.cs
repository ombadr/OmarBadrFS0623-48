using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void btnMostraCandidato_Click(object sender, EventArgs e)
        {
            string nome = WebConfigurationManager.AppSettings["CandidatoNome"];
            string cognome = WebConfigurationManager.AppSettings["CandidatoCognome"];

            lblCandidato.Text = $"Nome: {nome}, Cognome: {cognome}";
        }
    }
}