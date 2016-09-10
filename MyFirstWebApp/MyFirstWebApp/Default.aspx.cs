using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWebApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button1_Click(object sender, EventArgs e)
        {
            //string firstName = firstNameTextBox.Text;
            // https://msdn.microsoft.com/en-us/library/cs7y5x0x%28v=vs.90%29.aspx?f=255&MSPPError=-2147217396
            //link to check data type

            string firstName;
            firstName = "Bob";
            resultLabel.Text = firstName;

            /*


            string lastName = lastNameTextBox.Text;

            string result = "Hello " + firstName + " " + lastName;

            resultLabel.Text = result;

            */
        }
    }
}