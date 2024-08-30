using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pee_Reviewer_00172097
{
    public partial class frmDownload : Form
    {
        Peer_ReviewrDBEntities db = new Peer_ReviewrDBEntities();
        public frmDownload()
        {
            InitializeComponent();
        }
       

    private void frmDownload_Load(object sender, EventArgs e)
    {
        var data = db.ResearchWorks.ToList();

        comboBox1.DataSource = data;
        comboBox1.DisplayMember = "doc";
        comboBox1.ValueMember = "id";
    }

    private void button3_Click(object sender, EventArgs e)
    {
        
    }

    private void idTextBox_TextChanged(object sender, EventArgs e)
    {
            try
            {
                int idn = Int32.Parse(idTextBox.Text);
                var data = db.ResearchWorks.Where(d => d.Id == idn).FirstOrDefault();

                if (data != null)
                {
                    docTextBox.Text = data.Doc;
                    comboBox1.SelectedValue = data.Id;
                }
                else
                {
                    docTextBox.Text = "";
                }
            }
            catch (Exception)
            {

            }
        }

    private void idTextBox_KeyUp(object sender, KeyEventArgs e)
    {

    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        docTextBox.Text = comboBox1.Text;
    }

        private void frmDownload_Load_1(object sender, EventArgs e)
        {
            var data = db.ResearchWorks.ToList();

            comboBox1.DataSource = data;
            comboBox1.DisplayMember = "doc";
            comboBox1.ValueMember = "id";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (docTextBox.Text == "")
            {
                MessageBox.Show("Please search a document !!!");
                return;
            }
            try
            {
                string pathDestination = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), comboBox1.Text);
                //string pathDestination = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                string pathSource = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                //File.Copy(pathSource + "\\Upload\\" + comboBox1.Text, pathDestination);
                File.Copy(pathSource + "\\Upload\\" + docTextBox.Text, pathDestination);
                MessageBox.Show("Please check in desktop ...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
