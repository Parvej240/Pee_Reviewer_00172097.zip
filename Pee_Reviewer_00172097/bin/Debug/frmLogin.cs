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
    public partial class frmLogin : Form
    {
        Peer_ReviewrDBEntities db = new Peer_ReviewrDBEntities();
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var user = db.Accounts.Where(d => d.Email == emailTextBox.Text && d.Pass == passTextBox.Text).FirstOrDefault();
            if (user != null)
            {
                UserTypeCls.UserName = user.Name;
                if (user.uType == "Author")
                {
                    UserTypeCls.UserType = user.uType;
                    this.Hide();
                    Form1 frm = new Form1();
                    frm.Show();
                }
                else
                {
                    UserTypeCls.UserType = user.uType;

                    this.Hide();
                    Form1 frm = new Form1();
                    frm.Show();
                }

            }
            else
            {
                MessageBox.Show("Not a valid user !!!");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAccount acc = new frmAccount();
            acc.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAccount acc = new frmAccount();
            acc.ShowDialog();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            var user = db.Accounts.Where(d => d.Email == emailTextBox.Text && d.Pass == passTextBox.Text).FirstOrDefault();
            if (user != null)
            {
                UserTypeCls.UserName = user.Name;
                if (user.uType == "Author")
                {
                    UserTypeCls.UserType = user.uType;
                    this.Hide();
                    Form1 frm = new Form1();
                    frm.Show();
                }
                else
                {
                    UserTypeCls.UserType = user.uType;

                    this.Hide();
                    Form1 frm = new Form1();
                    frm.Show();
                }

            }
            else
            {
                MessageBox.Show("Not a valid user !!!");
            }
        }
    }
}
