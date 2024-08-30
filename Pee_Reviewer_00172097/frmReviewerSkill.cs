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
    public partial class frmReviewerSkill : Form
    {
        Peer_ReviewrDBEntities db = new Peer_ReviewrDBEntities();
        public frmReviewerSkill()
        {
            InitializeComponent();
        }
        

        

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            Reviewer rev = new Reviewer()
            {
                Name = nameTextBox.Text,
                Email = emailTextBox.Text,
                DOB = dateTimePicker1.Value,

            };

            db.Reviewers.Add(rev);
            db.SaveChanges();

            foreach (object item in listBox1.SelectedItems)
            {
                //MessageBox.Show(listBox1.GetItemText(item));
                string idn = item.ToString().Split(',')[0].Substring(6);
                //MessageBox.Show(idn);

                ReviewerSkill revsk = new ReviewerSkill();
                revsk.reviewerId = rev.Id;
                revsk.skillId = Int32.Parse(idn);

                db.ReviewerSkills.Add(revsk);
                db.SaveChanges();
            }

            MessageBox.Show("Data added successfully ...");
        }

        private void frmReviewerSkill_Load_1(object sender, EventArgs e)
        {
            var data1 = db.Skills.Select(d => new { d.Id, d.Name }).ToList();

            listBox1.DataSource = data1;
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "Id";
            listBox1.SelectionMode = SelectionMode.MultiExtended;

        }
    }
}
