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
    public partial class frmSearchByWord : Form
    {
        Peer_ReviewrDBEntities db = new Peer_ReviewrDBEntities();
        public frmSearchByWord()
        {
            InitializeComponent();
        }
        

       

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            var data = db.Comments.Select(d => new { idn = d.Id, Reviewer = d.PeerReview.Reviewer.Name, d.Remark, d.cDate, d.Skill.Name }).Where(d => d.Remark.Contains(textBox1.Text)).ToList();

            dataGridView1.DataSource = data.ToList();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            var data = db.Comments.Select(d => new { idn = d.Id, Reviewer = d.PeerReview.Reviewer.Name, d.Remark, d.cDate, d.Skill.Name }).Where(d => d.Remark.Contains(textBox1.Text)).ToList();

            dataGridView1.DataSource = data.ToList();
        }

        private void frmSearchByWord_Load_1(object sender, EventArgs e)
        {
            var data = db.Comments.Select(d => new { idn = d.Id, Reviewer = d.PeerReview.Reviewer.Name, d.Remark, d.cDate, d.Skill.Name }).ToList();

            dataGridView1.DataSource = data.ToList();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
