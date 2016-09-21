using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssignment
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {

                // this will set the default date on the calenders
                codeName.Text = " ";
                endCurrentAssignment.SelectedDate = DateTime.Now.Date;
                startNewAssignment.SelectedDate= DateTime.Now.Date.AddDays(14);
                projectedAssignment.SelectedDate = DateTime.Now.Date.AddDays(21);               

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            DateTime endDatesch = endCurrentAssignment.SelectedDate;
            DateTime startNewSch = startNewAssignment.SelectedDate;
            DateTime proAssignshedule = projectedAssignment.SelectedDate;


            

            //this is the TimeSpan from last calender - second caleder 7 days 

            TimeSpan totaltime =  proAssignshedule - startNewSch ;

            double cost = totaltime.Days * 500;                      

            if (totaltime.Days > 21) {

                cost = (totaltime.Days * 500) + 1000;
            }

            //not allow time under the two week check
            TimeSpan notAllowTime = startNewSch - endDatesch;

            if (notAllowTime.Days < 14)
            {
                lblresult.Text = "<font color='red'>Error:</font> Must allow at least two weeks between previous assignment and new assignment";
                startNewAssignment.SelectedDate = DateTime.Now.Date.AddDays(14);
            }
            else
            {  //final stage output


                //validation of empty string before output.
                if (assignname.Text.Length <= 1 || codeName.Text.Length <= 1)
                        {
                             lblresult.Text = "Code Name and Assignment Name are required!";
                        }
                else {

                    //this is my check just to make your my day are right
                    // lblresult.Text = cost.ToString() + "<br/>" + totaltime.Days + "<br/>" + notAllowTime.Days;
                    lblresult.Text = string.Format("&nbsp;Assignment of {0} to assignment Project: {1}" +
                     " is authorize. Total cost:  {2:C}   ", codeName.Text, assignname.Text, cost);
                    }



            }//end of final stage
                       


        }
    }
}