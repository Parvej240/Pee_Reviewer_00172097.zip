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
    public partial class frmWork : Form
    {
        string sourceFile;
        Peer_ReviewrDBEntities db = new Peer_ReviewrDBEntities();
        public frmWork()
        {
            InitializeComponent();
        }
        

       

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void frmWork_Load_1(object sender, EventArgs e)
        {
            //-------- Get Combobox data --------
            var data = db.Authors.ToList();

            comboBox1.DataSource = data;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";

            if (data.Count == 0)
            {
                MessageBox.Show("Please Add Author Information !!!");
                btnSubmit.Enabled = false;

            }
            else
            {
                btnSubmit.Enabled = true;
            }
        }

        private void btnBrowse_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Title = "Select file to be upload.";
            openFileDialog1.Filter = "Document(*.pdf; *.doc)|*.pdf; *.docx";
            openFileDialog1.FilterIndex = 1;
            try
            {
                if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    if (openFileDialog1.CheckFileExists)
                    {
                        string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                        sourceFile = path;
                        string filename = System.IO.Path.GetFileName(openFileDialog1.FileName);
                        docTextBox.Text = filename;
                    }
                }
                //else
                //{
                //    MessageBox.Show("Please Upload document.");
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (docTextBox.Text == null)
                {
                    MessageBox.Show("Please select a valid document.");
                }
                else
                {
                    //--------- db -----------------
                    ResearchWork w = new ResearchWork();
                    w.Doc = docTextBox.Text;
                    w.uDate = uDateDateTimePicker.Value;
                    w.dType = dTypeTextBox.Text;
                    w.aId = Int32.Parse( comboBox1.SelectedValue.ToString());

                    db.ResearchWorks.Add(w);
                    db.SaveChanges();

                    idTextBox.Text = w.Id.ToString();

                    //File upload
                    string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    System.IO.File.Copy(sourceFile, path + "\\Upload\\" + docTextBox.Text);
                    
                    MessageBox.Show("Document uploaded.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
