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
    public partial class frmAuthor : Form
    {
        Peer_ReviewrDBEntities db = new Peer_ReviewrDBEntities();
        public frmAuthor()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            Author au = new Author()
            {
                Name = nameTextBox.Text,
                Email = emailTextBox.Text,
                DOB = dateTimePicker1.Value,

            };

            db.Authors.Add(au);
            db.SaveChanges();

            idTextBox.Text = au.Id.ToString();

            foreach (object item in listBox1.SelectedItems)
            {
                //MessageBox.Show(listBox1.GetItemText(item));
                string idn = item.ToString().Split(',')[0].Substring(6);
                //MessageBox.Show(idn);

                AuthorSkill ask = new AuthorSkill();
                ask.authorId = au.Id;
                ask.skillId = Int32.Parse(idn);

                db.AuthorSkills.Add(ask);
                db.SaveChanges();
            }

            MessageBox.Show("Data Inserted Successfully ...");
        }

        private void frmAuthor_Load_1(object sender, EventArgs e)
        {
            var data1 = db.Skills.Select(d => new { d.Id, d.Name }).ToList();

            listBox1.DataSource = data1;
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "Id";
            listBox1.SelectionMode = SelectionMode.MultiSimple;

            if (data1.Count == 0)
            {
                MessageBox.Show("No skill found !!!");
                btnSubmit.Enabled = false;
            }
            else
            {
                btnSubmit.Enabled = true;
            }
        }
    }
}
