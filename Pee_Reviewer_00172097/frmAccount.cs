using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pee_Reviewer_00172097
{
    public partial class frmAccount : Form
    {
        Peer_ReviewrDBEntities db = new Peer_ReviewrDBEntities();
        public frmAccount()
        {
            InitializeComponent();
        }
        
        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            Account ac = new Account
            {
                Name = nameTextBox.Text,
                Email = emailTextBox.Text,
                Pass = passTextBox.Text,
                uType = cboUType.Text
            };

            db.Accounts.Add(ac);
            db.SaveChanges();

            idTextBox.Text = ac.Id.ToString();
            MessageBox.Show("Data Inserted Successfully ...");
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
