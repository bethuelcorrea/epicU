using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_008
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /*
            int I;
            I = "3";
            */
            /*
            int I = 2000000000;
            long J = I;
            */

            //long I = 2000000000;
            //int J = (int)I; // this is call a down cast . changing a long to int  (int)I

            // double k = 2.5;
            // int J = (int)k;

            // textlabel.Text =J.ToString() ;
            // this is a test to commit
            string i = TextBox1.Text;
            int j = int.Parse(i);

            int k = j + 1;
            textlabel.Text = k.ToString();




        }
    }
}