using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssetTracker
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                double[] actOfSubterfuge = new double[0];
                ViewState.Add("ActOfSubterfuge", actOfSubterfuge);

                double[] electionRigged = new double[0];
                ViewState.Add("ElectionRigged", electionRigged);

                String[] assetName = new String[0];
                ViewState.Add("AssetName", assetName);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //first array
            double[] actOfSubterfuge = (double[]) ViewState["ActOfSubterfuge"];

            Array.Resize(ref actOfSubterfuge, actOfSubterfuge.Length + 1);

            int newestItem = actOfSubterfuge.GetUpperBound(0);

            actOfSubterfuge[newestItem] = double.Parse(actsPerformed.Text);

            ViewState["ActOfSubterfuge"] = actOfSubterfuge;


            //second array

            double[] electionRigged = (double[])ViewState["ElectionRigged"];

            Array.Resize(ref electionRigged, electionRigged.Length + 1);

            int newestItem2 = electionRigged.GetUpperBound(0);

            electionRigged[newestItem2] = double.Parse(electionRiggedtext.Text);

            ViewState["ElectionRigged"] = electionRigged;
            //third array


            String[] assetName = (String[])ViewState["AssetName"];

            Array.Resize(ref assetName, assetName.Length + 1);

            int newestItem3 = assetName.GetUpperBound(0);

            assetName[newestItem3] = AssetNameTextBox.Text;

            ViewState["AssetName"] = assetName;



            lbltext.Text = String.Format("Average Acts of Subterfuge per Asset: {1:N2}<br/>Total Elections Rigged {0}<br/>Last Asset you Added: {2}",  
                electionRigged.Sum(), actOfSubterfuge.Average(), assetName.Last());




            




        }
    }
}