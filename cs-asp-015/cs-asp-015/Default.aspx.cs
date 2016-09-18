using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cs_asp_015
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            //http://is.gd/timespan
            //Days.Hours:Minutes:Seconds.Milliseconds
            TimeSpan myTimeSpan = TimeSpan.Parse("1.2:3:30.5");

            //day from my birthday until Now
            DateTime MyBirthday = DateTime.Parse("11/10/79");
            TimeSpan myAge = DateTime.Now.Subtract(MyBirthday);

            lbltext.Text = myAge.Hours.ToString();

            lbltext.Text = myAge.TotalDays.ToString();


        }
    }
}