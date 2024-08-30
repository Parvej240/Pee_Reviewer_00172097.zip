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
    public partial class frmRating : Form
    {
        Peer_ReviewrDBEntities db = new Peer_ReviewrDBEntities();
        public frmRating()
        {
            InitializeComponent();
        }
        

        private void hScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {
            lblRating.Text = hScrollBar1.Value.ToString();
        }

        private void frmRating_Load_1(object sender, EventArgs e)
        {
            //-------- Get Combobox data from Comment --------
            var data1 = db.Comments.ToList();

            cboComment.DataSource = data1;
            cboComment.DisplayMember = "peerRevId";
            cboComment.ValueMember = "Id";

            //-------- Get Combobox data from ResearchWork --------
            var data2 = db.ResearchWorks.Select(d => new { d.Id, d.Doc }).ToList();

            cboDocument.DataSource = data2;
            cboDocument.DisplayMember = "Doc";
            cboDocument.ValueMember = "Id";
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            Rating rat = new Rating()
            {
                RatingValue = hScrollBar1.Value,
                commentId = Int32.Parse(cboComment.SelectedValue.ToString()),
                authorDocId = Int32.Parse(cboDocument.SelectedValue.ToString())

            };

            db.Ratings.Add(rat);
            db.SaveChanges();

            idTextBox.Text = rat.Id.ToString();
            MessageBox.Show("Data Save Successfully ...");
        }
    }
}
