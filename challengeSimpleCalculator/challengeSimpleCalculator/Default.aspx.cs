using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace challengeSimpleCalculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Double firstnumber = Convert.ToDouble (firstnumTextBox1.Text);
            Double Secondnumber = Convert.ToDouble(secondNumberTextBox2.Text);

            Double result = firstnumber + Secondnumber;
            lbltxt.Text = result.ToString();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Double firstnumber = Convert.ToDouble(firstnumTextBox1.Text);
            Double Secondnumber = Convert.ToDouble(secondNumberTextBox2.Text);

            Double result = firstnumber - Secondnumber;
            lbltxt.Text = result.ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Double firstnumber = Convert.ToDouble(firstnumTextBox1.Text);
            Double Secondnumber = Convert.ToDouble(secondNumberTextBox2.Text);

            Double result = firstnumber * Secondnumber;
            lbltxt.Text = result.ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Double firstnumber = Convert.ToDouble(firstnumTextBox1.Text);
            Double Secondnumber = Convert.ToDouble(secondNumberTextBox2.Text);

            Double result = firstnumber / Secondnumber;
            lbltxt.Text = result.ToString();
        }
    }
}