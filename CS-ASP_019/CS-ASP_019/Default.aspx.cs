using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_019
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // string result = String.Format("Thank you, {0}, for your business", nameTextBox1.Text);

            //string result = String.Format("Thank you, {0}, for your business.<br/> Your SocialSecurity is {1:000-00-0000}", nameTextBox1.Text,ss);
            /*
            long ph = long.Parse(phone.Text);
            int ss = int.Parse(ssTextBox3.Text);
            string result = String.Format("Thank you, {0}, for your business.<br/>"+
                " Your SocialSecurity is {1:000-00-0000}<br/>"+
                " Phone: {2:(000) 000-0000}<br/>"+
                "Loan Date{3: ddd -- M, d, yyyy}", nameTextBox1.Text, ss, ph, myCalendar1.SelectedDate);
           */
            long ph = long.Parse(phone.Text);
            int ss = int.Parse(ssTextBox3.Text);
            double salary = double.Parse(SalaryTextBox4.Text);
            string result = String.Format("Thank you, {0}, for your business.<br/>" +
                " Your SocialSecurity is {1:000-00-0000}<br/>" +
                " Phone: {2:(000) 000-0000}<br/>" +
                "Loan Date{3: ddd -- M, d, yyyy}<br/>"+
                "Salary: {4:C}", nameTextBox1.Text, ss, ph, myCalendar1.SelectedDate, salary);


            lbltext.Text = result;



        }
    }
}