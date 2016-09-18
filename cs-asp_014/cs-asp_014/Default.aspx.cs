using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cs_asp_014
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //DateTime myValue = DateTime.Now;
            // lbltext.Text = myValue.ToString();
            // lbltext.Text = myValue.ToLongDateString();
            // lbltext.Text = myValue.ToLongTimeString();
            //  lbltext.Text = myValue.ToShortDateString();
            // lbltext.Text = myValue.ToShortTimeString();

            // lbltext.Text = myValue.AddDays(2).ToString();
            //lbltext.Text = myValue.AddMonths(-2).ToString();

            //DateTime.Now.Tostring("");  this prefered way of doing it
            //numberphile daylight. the problem with time and timezons

            //lbltext.Text = myValue.Month.ToString();
            // lbltext.Text = myValue.IsDaylightSavingTime().ToString();
            // lbltext.Text = myValue.DayOfWeek.ToString();
            // lbltext.Text = myValue.DayOfYear.ToString();

            //DateTime myvalue = DateTime.Parse("11/10/1979");
            DateTime myvalue = new DateTime(1979, 11, 10, 6, 30, 0);
            lbltext.Text = myvalue.ToLongDateString(); 



        }
    }
    
}