using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_035_Challenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            /*
             String name = "Bethuel Correa";

             char[] cArray = name.ToCharArray();
             string reverse = String.Empty;
             for (int i = cArray.Length - 1; i > -1; i--)
             {
                 reverse += cArray[i];
             }
             lbltext.Text = reverse;
             */

            /*

            String name = "Luke,Leia,Han,Chebacca";

            string[] cArray = name.Split(',');
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i]+",";
            }

            reverse = reverse.Remove(reverse.Length -1);
            lbltext.Text = reverse;
            */

            String name = "Luke,Leia,Han,Chebacca";

            string[] cArray = name.Split(',');
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                int padding = (14 - cArray[i].Length) / 2;
                string pad = cArray[i].PadLeft(cArray[i].Length + padding, '*');
                reverse += pad.PadRight(14, '*') + "<br/>";

            }

            //reverse = reverse.Remove(reverse.Length - 1);
            lbltext.Text = reverse;




        }
    }
}