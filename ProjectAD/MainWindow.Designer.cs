
namespace ProjectAD
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbData = new System.Windows.Forms.RichTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cbFileTypeName = new System.Windows.Forms.ComboBox();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.btnPreView = new System.Windows.Forms.Button();
            this.btnGenerateWordFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbData
            // 
            this.rtbData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbData.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtbData.Location = new System.Drawing.Point(513, 45);
            this.rtbData.Margin = new System.Windows.Forms.Padding(2);
            this.rtbData.Name = "rtbData";
            this.rtbData.ReadOnly = true;
            this.rtbData.Size = new System.Drawing.Size(614, 522);
            this.rtbData.TabIndex = 1;
            this.rtbData.Text = "";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.Location = new System.Drawing.Point(9, 10);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 30);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "&Dodaj";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEdit.Location = new System.Drawing.Point(77, 10);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(64, 30);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "&Edytuj";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDelete.Location = new System.Drawing.Point(146, 10);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(64, 30);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "&Usuń";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Gold;
            this.btnRefresh.Location = new System.Drawing.Point(374, 10);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(64, 30);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "&Odśwież";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cbFileTypeName
            // 
            this.cbFileTypeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFileTypeName.Location = new System.Drawing.Point(214, 15);
            this.cbFileTypeName.Margin = new System.Windows.Forms.Padding(2);
            this.cbFileTypeName.Name = "cbFileTypeName";
            this.cbFileTypeName.Size = new System.Drawing.Size(157, 21);
            this.cbFileTypeName.TabIndex = 6;
            // 
            // dgvMain
            // 
            this.dgvMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvMain.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(9, 45);
            this.dgvMain.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.RowHeadersWidth = 51;
            this.dgvMain.RowTemplate.Height = 24;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(500, 522);
            this.dgvMain.TabIndex = 7;
            // 
            // btnPreView
            // 
            this.btnPreView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreView.BackColor = System.Drawing.Color.Crimson;
            this.btnPreView.Location = new System.Drawing.Point(960, 9);
            this.btnPreView.Margin = new System.Windows.Forms.Padding(2);
            this.btnPreView.Name = "btnPreView";
            this.btnPreView.Size = new System.Drawing.Size(167, 30);
            this.btnPreView.TabIndex = 8;
            this.btnPreView.Text = "&Podgląd dokumentu";
            this.btnPreView.UseVisualStyleBackColor = false;
            this.btnPreView.Click += new System.EventHandler(this.btnPreView_Click);
            // 
            // btnGenerateWordFile
            // 
            this.btnGenerateWordFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateWordFile.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGenerateWordFile.Location = new System.Drawing.Point(806, 9);
            this.btnGenerateWordFile.Name = "btnGenerateWordFile";
            this.btnGenerateWordFile.Size = new System.Drawing.Size(149, 30);
            this.btnGenerateWordFile.TabIndex = 9;
            this.btnGenerateWordFile.Text = "Utwórz plik Word";
            this.btnGenerateWordFile.UseVisualStyleBackColor = false;
            this.btnGenerateWordFile.Click += new System.EventHandler(this.btnGenerateWordFile_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1138, 583);
            this.Controls.Add(this.btnGenerateWordFile);
            this.Controls.Add(this.btnPreView);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.cbFileTypeName);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.rtbData);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1154, 622);
            this.Name = "MainWindow";
            this.Text = "Aplikacja do zarządzania dokumentami";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbData;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cbFileTypeName;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Button btnPreView;
        private System.Windows.Forms.Button btnGenerateWordFile;
    }
}

