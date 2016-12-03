using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_049
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string result = "";
            int switchExpression = 0;

            switch (switchExpression)
            {
                case 0:
                case 1:
                    result += "case 0 <br/>";
                break;

                case 3:
                    result += "case 2 <br/>";
                    break;

                default :
                    break;
                    result += "default";

             
            }
            lbltext.Text = result;

        }
    }
}