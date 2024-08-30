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
    public partial class frmSkil : Form
    {
        Peer_ReviewrDBEntities db = new Peer_ReviewrDBEntities();
        public frmSkil()
        {
            InitializeComponent();
        }
        

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            Skill sk = new Skill()
            {
                Name = nameTextBox.Text,
                Desscription = descTextBox.Text

            };

            db.Skills.Add(sk);
            db.SaveChanges();

            idTextBox.Text = sk.Id.ToString();
            MessageBox.Show("Data Save Successfully ...");
        }
    }
}
