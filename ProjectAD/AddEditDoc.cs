using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAD
{
    public partial class AddEditDoc : Form
    {
        private FileHelper<List<Document>> _fileHelper;
        private FileHelper<List<Document>> _fileHelperBasic = new FileHelper<List<Document>>(Program.FilePath);
        private string _docPath;
        private int _documentId;

        public AddEditDoc(int id = 0)
        {
            InitializeComponent();
            GetDocType();

            _documentId = id;

            if (_documentId != 0)
            {
                Text = "Edytowanie dokumentu";
                GetDocToUpdate(_documentId);
            }
        }

        private void btnSelectedFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                ValidateNames = true,
                Multiselect = false,
                Filter = "Word 97-2003|*.doc|Word Document|*.docx"
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    tbDocPath.Text = ofd.SafeFileName;
                    _docPath = ofd.FileName;
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            List<Document> documents = _fileHelperBasic.DeserializeFromFile();

            if (_documentId != 0)
            {
                Document documentToUpdate = documents.FirstOrDefault(x => x.Id == _documentId);

                if (_documentId != 0 && documentToUpdate.DocType == "Uchwała")
                    UpdateDocumentWhichWasResolution();
                else
                    UpdateDocumentWhichWasProtocol();

                documents.RemoveAll(x => x.Id == _documentId);
            }
            else
            {
                Document documentWithHighestId = documents.OrderByDescending(x => x.Id).FirstOrDefault();
                _documentId = documentWithHighestId == null ? 1 : documentWithHighestId.Id + 1;
            }
            Document document = new Document
            {
                Id = _documentId,
                Name = tbName.Text,
                CreatedDate = dtpCreateDate.Value,
                DocType = cbAddEditDoc.Text,
                DocPath = _docPath,
                Description = rtbDescription.Text,
                DocFileName = tbDocPath.Text
            };

            documents.Add(document);
            _fileHelperBasic.SerializeToFile(documents);

            if (cbAddEditDoc.SelectedIndex == 0)
                SaveDocumentWhichIsResolution(document);

            if (cbAddEditDoc.SelectedIndex == 1)
                SaveDocumentWhichIsProtocol(document);

            Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void GetDocToUpdate(int id)
        {
            List<Document> documents = _fileHelperBasic.DeserializeFromFile();

            Document documentToUpdate = documents.FirstOrDefault(x => x.Id == id);

            tbName.Text = documentToUpdate.Name;
            dtpCreateDate.Value = documentToUpdate.CreatedDate;
            cbAddEditDoc.Text = documentToUpdate.DocType;
            tbDocPath.Text = documentToUpdate.DocFileName;
            rtbDescription.Text = documentToUpdate.Description;
            _docPath = documentToUpdate.DocPath;
        }
        private void GetDocType()
        {
            cbAddEditDoc.Items.Add("Uchwała");
            cbAddEditDoc.Items.Add("Protokół");
            cbAddEditDoc.SelectedIndex = 0;
        }
        private void SaveDocumentWhichIsProtocol(Document document)
        {
            _fileHelper = new FileHelper<List<Document>>(Program.FilePathToProtocols);
            List<Document> documentsWhichAreProtocols = _fileHelper.DeserializeFromFile();
            documentsWhichAreProtocols.Add(document);
            _fileHelper.SerializeToFile(documentsWhichAreProtocols);
        }
        private void SaveDocumentWhichIsResolution(Document document)
        {
            _fileHelper = new FileHelper<List<Document>>(Program.FilePathToResolutions);
            List<Document> documentsWhichAreResolutions = _fileHelper.DeserializeFromFile();
            documentsWhichAreResolutions.Add(document);
            _fileHelper.SerializeToFile(documentsWhichAreResolutions);
        }
        private void UpdateDocumentWhichWasProtocol()
        {
            _fileHelper = new FileHelper<List<Document>>(Program.FilePathToProtocols);
            List<Document> protocols = _fileHelper.DeserializeFromFile();
            protocols.RemoveAll(x => x.Id == _documentId);
            _fileHelper.SerializeToFile(protocols);
        }
        private void UpdateDocumentWhichWasResolution()
        {
            _fileHelper = new FileHelper<List<Document>>(Program.FilePathToResolutions);
            List<Document> resolutions = _fileHelper.DeserializeFromFile();
            resolutions.RemoveAll(x => x.Id == _documentId);
            _fileHelper.SerializeToFile(resolutions);
        }
    }
}
