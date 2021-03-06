using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProjectAD
{
    public partial class MainWindow : Form
    {
        private FileHelper<List<Document>> _fileHelper;
        private FileHelper<List<Document>> _fileHelperBasic = new FileHelper<List<Document>>(Program.FilePath);

        public MainWindow()
        {
            InitializeComponent();
            FullScreen.EnterFullScreenMode(this);
            _fileHelper = _fileHelperBasic;
            GetDocsTypeName();
            CreatNecessaryFilesAndFolders();
            RefreshDataGridView();
            SetColumnsProperties();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEditDoc addDoc = new AddEditDoc();
            addDoc.ShowDialog();
            RefreshDataGridView();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvMain.SelectedRows.Count == 0)
            {
                MessageBox.Show("Proszę zaznaczyć dokument, który chcesz edytować.");
                return;
            }
            AddEditDoc editDoc = new AddEditDoc(Convert.ToInt32(dgvMain.SelectedRows[0].Cells[5].Value));
            editDoc.ShowDialog();
            RefreshDataGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMain.SelectedRows.Count == 0)
            {
                MessageBox.Show("Proszę zaznaczyć dokument, który chcesz usunąć.");
                return;
            }

            int documentIdToDelete = Convert.ToInt32(dgvMain.SelectedRows[0].Cells[5].Value);

            List<Document> documents = _fileHelperBasic.DeserializeFromFile();
            Document documentToDelete = documents.FirstOrDefault(x => x.Id == documentIdToDelete);

            int caseSwitch;
            if (documentToDelete.DocType == "Uchwała")
                caseSwitch = 1;
            else
                caseSwitch = 2;

            DialogResult result = MessageBox.Show($"Czy na pewno chcesz usunąć dokument: {documentToDelete.Name}?",
                                                    "Usuwanie dokumentu", 
                                                    MessageBoxButtons.OKCancel, 
                                                    MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                documents.Remove(documentToDelete);
                _fileHelperBasic.SerializeToFile(documents);

                switch (caseSwitch)
                {
                    case 1:
                        DeleteDocumentFromResolutions(documentIdToDelete);
                        break;
                    case 2:
                        DeleteDocumentFromProtocols(documentIdToDelete);
                        break;
                }

                RefreshDataGridView();
            }
            else
            {
                return;
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }
        private void btnPreView_Click(object sender, EventArgs e)
        {
            int documentIdWhichWillBeDisplay = Convert.ToInt32(dgvMain.SelectedRows[0].Cells[5].Value);
            Cursor.Current = Cursors.WaitCursor;
            RefreshRichTextBox(documentIdWhichWillBeDisplay);
        }
        private void RefreshDataGridView()
        {
            if (cbFileTypeName.SelectedIndex == 0)
            {
                List<Document> documents = _fileHelperBasic.DeserializeFromFile();
                dgvMain.DataSource = documents;
            }
            else if (cbFileTypeName.SelectedIndex == 1)
            {
                _fileHelper = new FileHelper<List<Document>>(Program.FilePathToResolutions);
                List<Document> documents = _fileHelper.DeserializeFromFile();
                dgvMain.DataSource = documents;
            }
            else if (cbFileTypeName.SelectedIndex == 2)
            {
                _fileHelper = new FileHelper<List<Document>>(Program.FilePathToProtocols);
                List<Document> documents = _fileHelper.DeserializeFromFile();
                dgvMain.DataSource = documents;
            }
        }

        private void RefreshRichTextBox(int documentIdWhichWillBeDisplay)
        {
            List<Document> documents = _fileHelperBasic.DeserializeFromFile();
            Document documentToDisplay = documents.FirstOrDefault(x => x.Id == documentIdWhichWillBeDisplay);

            if (string.IsNullOrWhiteSpace(documentToDisplay.DocPath))
            {
                MessageBox.Show("Ścieżka do wybranego dokumentu jest nieprawidłowa.", "Zła ścieżka");
                return;
            }

            object readOnly = false;
            object visible = true;
            object save = false;
            object fileName = documentToDisplay.DocPath;
            object newTemplate = false;
            object docType = 0;
            object missing = Type.Missing;
            Microsoft.Office.Interop.Word._Document document;
            Microsoft.Office.Interop.Word._Application application = new Microsoft.Office.Interop.Word.Application() { Visible = false };
            document = application.Documents.Open(ref fileName, ref missing, ref readOnly, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing, ref visible, ref missing, ref missing,
                ref missing, ref missing);
            document.ActiveWindow.Selection.WholeStory();
            document.ActiveWindow.Selection.Copy();
            IDataObject dataObject = Clipboard.GetDataObject();
            rtbData.Rtf = dataObject.GetData(DataFormats.Rtf).ToString();
            application.Quit(ref missing, ref missing, ref missing);
        }

        private void SetColumnsProperties()
        {
            dgvMain.Columns[5].Visible = false; //ID
            dgvMain.Columns[6].Visible = false;
            dgvMain.Columns[7].Visible = false;
            dgvMain.Columns[0].HeaderText = "Nazwa";
            dgvMain.Columns[1].HeaderText = "Termin wykonania";
            dgvMain.Columns[4].HeaderText = "Rodzaj";
            dgvMain.Columns[3].HeaderText = "Opis";
            dgvMain.Columns[2].HeaderText = "Odpowiedzialny";
            dgvMain.Columns[1].DefaultCellStyle.Format = "d";
        }

        private void CreatNecessaryFilesAndFolders()
        {
            if (!File.Exists(Path.Combine(Environment.CurrentDirectory, @"JsonFile\Documents.txt")))
            {
                Directory.CreateDirectory(Path.Combine(Environment.CurrentDirectory, "JsonFile"));
                using (File.Create(Path.Combine(Environment.CurrentDirectory, @"JsonFile\Documents.txt"))) { }
            }
            if (!File.Exists(Path.Combine(Environment.CurrentDirectory, @"JsonFile\Resolutions.txt")))
            {
                using (File.Create(Path.Combine(Environment.CurrentDirectory, @"JsonFile\Resolutions.txt"))) { }
            }
            if (!File.Exists(Path.Combine(Environment.CurrentDirectory, @"JsonFile\Protocols.txt")))
            {
                using (File.Create(Path.Combine(Environment.CurrentDirectory, @"JsonFile\Protocols.txt"))) { }
            }
        }
        private void GetDocsTypeName()
        {
            cbFileTypeName.Items.Add("--Wszystkie--");
            cbFileTypeName.Items.Add("Uchwały");
            cbFileTypeName.Items.Add("Protokoły");
            cbFileTypeName.SelectedIndex = 0;
        }
        private void DeleteDocumentFromProtocols(int id)
        {
            _fileHelper = new FileHelper<List<Document>>(Program.FilePathToProtocols);
            List<Document> documents = _fileHelper.DeserializeFromFile();
            documents.RemoveAll(x => x.Id == id);
            _fileHelper.SerializeToFile(documents);
        }
        private void DeleteDocumentFromResolutions(int id)
        {
            _fileHelper = new FileHelper<List<Document>>(Program.FilePathToResolutions);
            List<Document> documents = _fileHelper.DeserializeFromFile();
            documents.RemoveAll(x => x.Id == id);
            _fileHelper.SerializeToFile(documents);
        }

        private void btnGenerateWordFile_Click(object sender, EventArgs e)
        {
            ExportDocumentToWordTable.ExportToWord();
        }
    }
}
