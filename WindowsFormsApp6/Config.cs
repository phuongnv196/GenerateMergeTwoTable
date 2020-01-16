using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
        }
        public string FirstConnectString { set; get; }
        public string SecondConnectString { set; get; }
        private void Config_Load(object sender, EventArgs e)
        {
            

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var connectString = "Server={0};Initial Catalog=master;User ID={1};Password={2};Connection Timeout=600;";
            FirstConnectString = string.Format(connectString, txtFirstServer.Text, txtFirstAccount.Text, txtFirstPassword.Text);
            SecondConnectString = string.Format(connectString, txtSecondServer.Text, txtSecondAccount.Text, txtSecondPassword.Text);
            this.Close();
        }
    }
}
