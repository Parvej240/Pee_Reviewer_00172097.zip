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
    public partial class frmAuthorSkillList : Form
    {
        Peer_ReviewrDBEntities db = new Peer_ReviewrDBEntities();
        public frmAuthorSkillList()
        {
            InitializeComponent();
        }

       
        private void frmAuthorSkillList_Load_1(object sender, EventArgs e)
        {
            var data = db.AuthorSkills.Select(d => new { idn = d.Id, AuthorName = d.Author.Name, AuthorEmail = d.Author.Email, SkillName = d.Skill.Name }).ToList();

            dataGridView1.DataSource = data.ToList();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
