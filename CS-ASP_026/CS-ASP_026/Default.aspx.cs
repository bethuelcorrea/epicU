using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_026
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            string result = "";

            for (int i = 0; i < 10; i++)
            {

                result += "<br/>" + i.ToString();

            }

            lbltext.Text = result;
           
           */
            /*
             string result = "";

             for (int i = 0; i < 10; i--)
             {

                 result += "<br/>" + i.ToString();

             }

             lbltext.Text = result;
               */
            /*
         string[]

         for (int i = 0; i < names.length; i++)
         {
          result = String.Format();
          break;
         }
         */

            //linq


            var names = new[] { "a","b","c"};

            var result = names
                .FirstOrDefault(n => n == "a")
                .Select(n=>string.Format("result{0}",n));


        }
    }
}