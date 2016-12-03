using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_059
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Database1Entities db = new Database1Entities();
            var customers = db.Customers;
            string result = " ";
            foreach (var customer in customers)
            {
                result += "<p>"+customer.Name+"</p>";
            }

            lbltext.Text = result;
        }
    }
}