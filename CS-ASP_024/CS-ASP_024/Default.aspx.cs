﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_024
{
    public partial class Default : System.Web.UI.Page
    {
        string z = "Hello";// ths var is acceable to  all of the bottom methods

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int x = 1;

            if (x == 1)
            {
                x = 2;
                int y = 3;
            }

            string result = x.ToString();
        }
    }
}