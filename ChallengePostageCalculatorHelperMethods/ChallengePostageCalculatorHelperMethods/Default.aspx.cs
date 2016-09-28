using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePostageCalculatorHelperMethods
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        public void getDimension(double shipping)
        {
            if (widthTextBox1.Text.Trim().Length == 0 && 
                heightTextBox2.Text.Trim().Length == 0)
                return;

            double width = 0.0;
            double height = 0.0;
            double length = 0.0;

            if (!Double.TryParse(widthTextBox1.Text, out width))
                return;
            if (!Double.TryParse(heightTextBox2.Text, out height))
                return;
            if (!Double.TryParse(lengthTextBox3.Text, out length))
                return;

            double result = (width * height * length) * shipping;


            lbltext.Text = String.Format("your parcel will cost {0:C}", result);        

                            

        }

        


        protected void groundRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            getDimension(.15);
        }

        protected void airRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            getDimension(.25);
        }

        protected void nextDayRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            getDimension(.45);
        }
    }
}