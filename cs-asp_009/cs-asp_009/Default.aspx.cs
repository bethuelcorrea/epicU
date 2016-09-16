using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cs_asp_009
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            int i = 1;
            int j = 2;
            //int result = i + j;
            //int result = i - j;
            //int result = i * j;
            //int result = i/j;

            //i = i + 5;
            //i += 5;
            // i++;
            // i--;

            // int myInteger = (5 + 1) * 7;
            //lbltext.Text = myInteger.ToString();


            // double myDouble =5.5;
            //int myInteger = 7;

            //double myResult = myDouble + myInteger;
            // int myResult = (int)myDouble + myInteger;
            // lbltext.Text = myResult.ToString();


           // int myInteger = 7;
            //int myOtherInteger=4;

            //int myResult = myInteger / myOtherInteger;
           // double myResult =(double) myInteger /(double) myOtherInteger;

           // lbltext.Text = myResult.ToString();

            
            int firstnumber  = 2000000000;
            int secondnumber = 2000000000;
            long resultNumber;

            checked
            {
                 resultNumber = firstnumber * secondnumber;
            }

            lbltext.Text = resultNumber.ToString();
            
           


        }
    }
}