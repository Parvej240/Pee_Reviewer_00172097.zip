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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAuthor dlg = new Pee_Reviewer_00172097.frmAuthor();
            dlg.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        } private void documentDownloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDownload dlg = new frmDownload();
            dlg.Show();
        }

        private void logOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frm = new Pee_Reviewer_00172097.frmLogin();
            frm.Show();
        }

        private void exitToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            if (UserTypeCls.UserType == "User")
            {
                fileToolStripMenuItem.Visible = false;
            }
            else
            {
                fileToolStripMenuItem.Visible = true;
            }

            toolStripStatusLabel1.Text = "Welcome " + UserTypeCls.UserName;
            MessageBox.Show("Hi " + UserTypeCls.UserType);
        }

        private void searchByWordToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmSearchByWord dlg = new frmSearchByWord();
            dlg.Show();
        }

        private void researchWorkToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmResearchWorkList dlg = new frmResearchWorkList();
            dlg.Show();
        }

        private void skillInformationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmSkillList dlg = new frmSkillList();
            dlg.Show();
        }

        private void authorInformationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmAuthorList dlg = new frmAuthorList();
            dlg.Show();
        }

        private void conferenceToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmConference dlg = new frmConference();
            dlg.Show();
        }

        private void registerUserToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmAccount dlg = new frmAccount();
            dlg.Show();
        }

        private void ratingToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmRating dlg = new frmRating();
            dlg.Show();
        }

        private void peerReviewToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmPeerReview dlg = new frmPeerReview();
            dlg.Show();
        }

        private void reviewerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmReviewerSkill dlg = new frmReviewerSkill();
            dlg.Show();
        }

        private void commentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmComment dlg = new frmComment();
            dlg.Show();
        }

        private void authorSkilToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmAuthorSkillList dlg = new frmAuthorSkillList();
            dlg.Show();
        }

        private void documentUploadToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmWork dlg = new Pee_Reviewer_00172097.frmWork();
            dlg.Show();
        }

        private void skillToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmSkil dlg = new frmSkil();
            dlg.Show();
        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmAboutBox about = new frmAboutBox();
            about.ShowDialog();
        }

        private void authorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmAuthor dlg = new Pee_Reviewer_00172097.frmAuthor();
            dlg.Show();
        }

        private void documentDownloadToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmDownload dlg = new frmDownload();
            dlg.Show();
        }
    }
}
