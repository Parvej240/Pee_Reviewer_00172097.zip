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
    public partial class frmConference : Form
    {
        Peer_ReviewrDBEntities db = new Peer_ReviewrDBEntities();
        public frmConference()
        {
            InitializeComponent();
        }
       
        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            Conference conf = new Conference()
            {
                Title = titleTextBox.Text,
                StartDate = dateTimePicker1.Value
            };


            db.Conferences.Add(conf);
            db.SaveChanges();

            idTextBox.Text = conf.Id.ToString();
            MessageBox.Show("Data Save Successfully ...");
        }
    }
}
    