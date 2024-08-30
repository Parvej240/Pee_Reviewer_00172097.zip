namespace Pee_Reviewer_00172097
{
    partial class frmWork
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label docLabel;
            System.Windows.Forms.Label uDateLabel;
            System.Windows.Forms.Label dTypeLabel;
            System.Windows.Forms.Label aIdLabel;
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.docTextBox = new System.Windows.Forms.TextBox();
            this.uDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dTypeTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            docLabel = new System.Windows.Forms.Label();
            uDateLabel = new System.Windows.Forms.Label();
            dTypeLabel = new System.Windows.Forms.Label();
            aIdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(21, 20);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 16;
            idLabel.Text = "Id:";
            // 
            // docLabel
            // 
            docLabel.AutoSize = true;
            docLabel.Location = new System.Drawing.Point(21, 46);
            docLabel.Name = "docLabel";
            docLabel.Size = new System.Drawing.Size(93, 13);
            docLabel.TabIndex = 18;
            docLabel.Text = "Document Name :";
            // 
            // uDateLabel
            // 
            uDateLabel.AutoSize = true;
            uDateLabel.Location = new System.Drawing.Point(21, 73);
            uDateLabel.Name = "uDateLabel";
            uDateLabel.Size = new System.Drawing.Size(70, 13);
            uDateLabel.TabIndex = 20;
            uDateLabel.Text = "Upload Date:";
            // 
            // dTypeLabel
            // 
            dTypeLabel.AutoSize = true;
            dTypeLabel.Location = new System.Drawing.Point(21, 98);
            dTypeLabel.Name = "dTypeLabel";
            dTypeLabel.Size = new System.Drawing.Size(86, 13);
            dTypeLabel.TabIndex = 22;
            dTypeLabel.Text = "Document Type:";
            // 
            // aIdLabel
            // 
            aIdLabel.AutoSize = true;
            aIdLabel.Location = new System.Drawing.Point(21, 124);
            aIdLabel.Name = "aIdLabel";
            aIdLabel.Size = new System.Drawing.Size(44, 13);
            aIdLabel.TabIndex = 24;
            aIdLabel.Text = "Author :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(146, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 27;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.ForeColor = System.Drawing.Color.Yellow;
            this.btnSubmit.Location = new System.Drawing.Point(21, 213);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(86, 39);
            this.btnSubmit.TabIndex = 26;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBrowse.Location = new System.Drawing.Point(271, 164);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 30);
            this.btnBrowse.TabIndex = 25;
            this.btnBrowse.Text = "Browse File";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click_1);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(146, 21);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(51, 20);
            this.idTextBox.TabIndex = 17;
            // 
            // docTextBox
            // 
            this.docTextBox.Location = new System.Drawing.Point(146, 47);
            this.docTextBox.Name = "docTextBox";
            this.docTextBox.ReadOnly = true;
            this.docTextBox.Size = new System.Drawing.Size(200, 20);
            this.docTextBox.TabIndex = 19;
            // 
            // uDateDateTimePicker
            // 
            this.uDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.uDateDateTimePicker.Location = new System.Drawing.Point(146, 73);
            this.uDateDateTimePicker.Name = "uDateDateTimePicker";
            this.uDateDateTimePicker.Size = new System.Drawing.Size(110, 20);
            this.uDateDateTimePicker.TabIndex = 21;
            // 
            // dTypeTextBox
            // 
            this.dTypeTextBox.Location = new System.Drawing.Point(146, 99);
            this.dTypeTextBox.Name = "dTypeTextBox";
            this.dTypeTextBox.Size = new System.Drawing.Size(200, 20);
            this.dTypeTextBox.TabIndex = 23;
            // 
            // frmWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 264);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(docLabel);
            this.Controls.Add(this.docTextBox);
            this.Controls.Add(uDateLabel);
            this.Controls.Add(this.uDateDateTimePicker);
            this.Controls.Add(dTypeLabel);
            this.Controls.Add(this.dTypeTextBox);
            this.Controls.Add(aIdLabel);
            this.MaximumSize = new System.Drawing.Size(401, 303);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(401, 303);
            this.Name = "frmWork";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmWork";
            this.Load += new System.EventHandler(this.frmWork_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox docTextBox;
        private System.Windows.Forms.DateTimePicker uDateDateTimePicker;
        private System.Windows.Forms.TextBox dTypeTextBox;
    }
}