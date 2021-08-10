
namespace ProjectAD
{
    partial class AddEditDoc
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCreatedDate = new System.Windows.Forms.Label();
            this.dtpCreateDate = new System.Windows.Forms.DateTimePicker();
            this.cbAddEditDoc = new System.Windows.Forms.ComboBox();
            this.lbDocType = new System.Windows.Forms.Label();
            this.btnSelectedFile = new System.Windows.Forms.Button();
            this.tbDocPath = new System.Windows.Forms.TextBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(149, 21);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(215, 22);
            this.tbName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwa:";
            // 
            // lbCreatedDate
            // 
            this.lbCreatedDate.AutoSize = true;
            this.lbCreatedDate.Location = new System.Drawing.Point(14, 70);
            this.lbCreatedDate.Name = "lbCreatedDate";
            this.lbCreatedDate.Size = new System.Drawing.Size(114, 17);
            this.lbCreatedDate.TabIndex = 3;
            this.lbCreatedDate.Text = "Data utworzenia:";
            // 
            // dtpCreateDate
            // 
            this.dtpCreateDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCreateDate.Location = new System.Drawing.Point(149, 65);
            this.dtpCreateDate.Name = "dtpCreateDate";
            this.dtpCreateDate.Size = new System.Drawing.Size(215, 22);
            this.dtpCreateDate.TabIndex = 4;
            // 
            // cbAddEditDoc
            // 
            this.cbAddEditDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAddEditDoc.FormattingEnabled = true;
            this.cbAddEditDoc.Location = new System.Drawing.Point(149, 108);
            this.cbAddEditDoc.Name = "cbAddEditDoc";
            this.cbAddEditDoc.Size = new System.Drawing.Size(215, 24);
            this.cbAddEditDoc.TabIndex = 5;
            // 
            // lbDocType
            // 
            this.lbDocType.AutoSize = true;
            this.lbDocType.Location = new System.Drawing.Point(14, 111);
            this.lbDocType.Name = "lbDocType";
            this.lbDocType.Size = new System.Drawing.Size(56, 17);
            this.lbDocType.TabIndex = 6;
            this.lbDocType.Text = "Rodzaj:";
            // 
            // btnSelectedFile
            // 
            this.btnSelectedFile.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSelectedFile.Location = new System.Drawing.Point(17, 154);
            this.btnSelectedFile.Name = "btnSelectedFile";
            this.btnSelectedFile.Size = new System.Drawing.Size(89, 36);
            this.btnSelectedFile.TabIndex = 7;
            this.btnSelectedFile.Text = "&Wybierz";
            this.btnSelectedFile.UseVisualStyleBackColor = false;
            this.btnSelectedFile.Click += new System.EventHandler(this.btnSelectedFile_Click);
            // 
            // tbDocPath
            // 
            this.tbDocPath.Location = new System.Drawing.Point(149, 161);
            this.tbDocPath.Name = "tbDocPath";
            this.tbDocPath.ReadOnly = true;
            this.tbDocPath.Size = new System.Drawing.Size(215, 22);
            this.tbDocPath.TabIndex = 8;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(14, 215);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(41, 17);
            this.lbDescription.TabIndex = 9;
            this.lbDescription.Text = "Opis:";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(149, 212);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(215, 78);
            this.rtbDescription.TabIndex = 10;
            this.rtbDescription.Text = "";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.PaleGreen;
            this.btnConfirm.Location = new System.Drawing.Point(149, 296);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(92, 44);
            this.btnConfirm.TabIndex = 11;
            this.btnConfirm.Text = "&Zatwierdź";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCancel.Location = new System.Drawing.Point(272, 296);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 44);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "&Anuluj";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddEditDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 378);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.tbDocPath);
            this.Controls.Add(this.btnSelectedFile);
            this.Controls.Add(this.lbDocType);
            this.Controls.Add(this.cbAddEditDoc);
            this.Controls.Add(this.dtpCreateDate);
            this.Controls.Add(this.lbCreatedDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.MaximumSize = new System.Drawing.Size(422, 425);
            this.MinimumSize = new System.Drawing.Size(422, 425);
            this.Name = "AddEditDoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodawanie dokumentu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCreatedDate;
        private System.Windows.Forms.DateTimePicker dtpCreateDate;
        private System.Windows.Forms.ComboBox cbAddEditDoc;
        private System.Windows.Forms.Label lbDocType;
        private System.Windows.Forms.Button btnSelectedFile;
        private System.Windows.Forms.TextBox tbDocPath;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}