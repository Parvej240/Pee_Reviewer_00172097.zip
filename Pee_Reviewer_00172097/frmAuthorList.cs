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
    public partial class frmAuthorList : Form
    {
        Peer_ReviewrDBEntities db = new Peer_ReviewrDBEntities();
        public frmAuthorList()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void frmAuthorList_Load_1(object sender, EventArgs e)
        {
            var data = db.Authors.Select(d => new { d.Name, d.Email, DateOfBirth = d.DOB }).ToList();

            dataGridView1.DataSource = data.ToList();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
