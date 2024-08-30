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
    public partial class frmPeerReview : Form
    {
        Peer_ReviewrDBEntities db = new Peer_ReviewrDBEntities();
        public frmPeerReview()
        {
            InitializeComponent();
        }
        
        private void frmPeerReview_Load_1(object sender, EventArgs e)
        {
            //-------- Get Combobox data from Reviewer --------
            var data1 = db.Reviewers.ToList();


            cboRevId.DataSource = data1;
            cboRevId.DisplayMember = "Name";
            cboRevId.ValueMember = "Id";

            //-------- Get Combobox data from ResearchWork --------
            var data2 = db.ResearchWorks.Select(d => new { d.Id, d.Doc }).ToList();

            cboDocId.DataSource = data2;
            cboDocId.DisplayMember = "Doc";
            cboDocId.ValueMember = "Id";
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            //--------- db -----------------
            PeerReview pr = new PeerReview();

            pr.DOR = dateTimePicker1.Value;
            pr.reviewerId = Int32.Parse(cboRevId.SelectedValue.ToString());
            pr.docId = Int32.Parse(cboDocId.SelectedValue.ToString());

            db.PeerReviews.Add(pr);
            db.SaveChanges();

            idTextBox.Text = pr.Id.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
