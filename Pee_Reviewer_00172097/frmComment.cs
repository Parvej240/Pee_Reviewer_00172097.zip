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
    public partial class frmComment : Form
    {
        Peer_ReviewrDBEntities db = new Peer_ReviewrDBEntities();
        public frmComment()
        {
            InitializeComponent();
        }
       

        

        private void idTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                int idn = Int32.Parse(idTextBox.Text);
                var data1 = db.Comments.Where(d => d.Id == idn).FirstOrDefault();
                if (data1 != null)
                {
                    cboReview.SelectedValue = data1.peerRevId;
                    remarkTextBox.Text = data1.Remark;
                    dateTimePicker1.Value = DateTime.Parse(data1.cDate.ToString());
                    cboSkill.SelectedValue = data1.skillId;
                }
                else
                {

                    remarkTextBox.Text = "";
                    dateTimePicker1.Value = DateTime.Now;

                }
            }
            catch (Exception)
            {
            }
        }

        private void frmComment_Load_1(object sender, EventArgs e)
        {
            //-------- Get Combobox data from PeerReview --------
            var data1 = db.PeerReviews.Select(d => new { d.Id, Name = d.Reviewer.Name }).ToList();
            //var data1 = db.PeerReviews.ToList();


            cboReview.DataSource = data1;
            cboReview.DisplayMember = "Name";
            cboReview.ValueMember = "Id";



            //-------- Get Combobox data from Skill --------
            var data2 = db.Skills.Select(d => new { d.Id, d.Name }).ToList();

            cboSkill.DataSource = data2;
            cboSkill.DisplayMember = "Name";
            cboSkill.ValueMember = "Id";
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            //--------- db -----------------
            Comment cmt = new Comment();


            cmt.peerRevId = Int32.Parse(cboReview.SelectedValue.ToString());
            cmt.Remark = remarkTextBox.Text;
            cmt.cDate = dateTimePicker1.Value;
            cmt.skillId = Int32.Parse(cboSkill.SelectedValue.ToString());

            db.Comments.Add(cmt);
            db.SaveChanges();

            idTextBox.Text = cmt.Id.ToString();
        }
    }
}
