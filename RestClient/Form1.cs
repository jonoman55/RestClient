using System;
using System.Windows.Forms;

namespace RestClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // https://dry-cliffs-19849.herokuapp.com/users.json
        // https://dry-cliffs-19849.herokuapp.com/users/2.json
        private void cmdBtn_Click(object sender, EventArgs e)
        {
            HttpRestClient client = new HttpRestClient();
            client.EndPoint = txtRequest.Text;

            debugOutput("REST Client Created");

            string strResp = string.Empty;

            strResp = client.MakeRequest();

            if (formatChkBox.Checked == true && client.EndPoint.Contains(".json"))
            {
                debugOutput(strResp.FormatJson());
                return;
            }

            debugOutput(strResp);
        }

        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                txtResponse.Text = txtResponse.Text + strDebugText + Environment.NewLine;
                txtResponse.SelectionStart = txtResponse.TextLength;
                txtResponse.ScrollToCaret();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            txtResponse.Clear();
            txtRequest.Clear();
            formatChkBox.CheckState = CheckState.Unchecked;
        }
    }
}
