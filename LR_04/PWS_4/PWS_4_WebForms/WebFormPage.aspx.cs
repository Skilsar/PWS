using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebServices.SimplexS;


namespace PWS_4_WebForms
{
    public partial class WebFormPage : System.Web.UI.Page
    {
        Simplex simplex;

        protected void Page_Load(object sender, EventArgs e)
        {
            simplex = new SimplexImplemetation();
            int.TryParse(x.Value, out int paramX);
            int.TryParse(y.Value, out int paramY);

            addResult.InnerText = "Result is: " + simplex.Add(paramX, paramY);
        }
    }
}