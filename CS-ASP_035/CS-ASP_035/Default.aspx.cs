using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_035
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            //lbltext.Text = "<p style=\"color: red;\" \">Hi</p>";

            string value = TextBox1.Text;
            //access any specific character
            // lbltext.Text = value[2].ToString();

            //startwith(), EndWith(), Contains()
            /*
            if (value.StartsWith("A"))
                lbltext.Text = "value start with 'A'";

            if (value.EndsWith("."))
                lbltext.Text += "value ends with a '.'";

            if (value.Contains("good"))
                lbltext.Text += "Value contains good";
            */

            //IndexOf();
           int index = value.IndexOf("good");
            // lbltext.Text = "good begins at index" + index.ToString();

            //insert, remove
            //lbltext.Text = value.Insert(index, "jolly ");
            //lbltext.Text = value.Remove(index, value.Length - index);

            //Substring
            // lbltext.Text = value.Substring(index, value.Length - index - 1);

            //Trim(this is for empty spaces it will trim it), TrimStart, TrimEnd
            // lbltext.Text = String.Format("Length Before: {0}<br/>Length After: {1}", value.Length, value.Trim().Length);

            //PadLeft, PadRight
            //lbltext.Text = value.PadLeft(10, '*');

            //ToUpper, ToLower
            //if ("bob" == "Bob") lbltext.Text= "The same";
            //else lbltext.Text = "Different";
            /*
            if (value.Trim().ToUpper() == "BOB") lbltext.Text = "The same";
            else lbltext.Text = "Different";
            */
            //Replace()
            // string template = "[NAME] said it would be ok. Maybe you should take that up with [NAME].";
            //lbltext.Text = template.Replace("[NAME]", TextBox1.Text);

            //Split example of a char is single quotes

            //string result = "";
            StringBuilder sb = new StringBuilder();

            string[] values = TextBox1.Text.Split(',');
            for (int i = 0; i < values.Length; i++)
            {
                // result += values[i] + " " + values[i].Length + "<br/>";
                sb.Append(values[i]);
                sb.Append(" ");
                sb.Append(values[i].Length);
                sb.Append("<br/>");
            }
            // lbltext.Text = result;
            lbltext.Text = sb.ToString();

        }
    }
}