using System;
using System.Collections.Generic;

namespace ProjectAD
{
    public class ExportDocumentToWordTable
    {
        private static FileHelper<List<Document>> _fileHelper = new FileHelper<List<Document>>(Program.FilePathToResolutions);

        public ExportDocumentToWordTable()
        {
        }

        public static void ExportToWord()
        {
            List<Document> resolutions = _fileHelper.DeserializeFromFile();

            Microsoft.Office.Interop.Word.Application word = null;
            Microsoft.Office.Interop.Word.Document doc = null;

            object oMissing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc";

            try
            {
                word = new Microsoft.Office.Interop.Word.Application();
                word.Visible = true;
                doc = word.Documents.Add(ref oMissing, ref oMissing, ref oMissing, ref oMissing);
            }
            catch (Exception ex)
            {
                throw;
            }

            if (word != null && doc != null)
            {
                Microsoft.Office.Interop.Word.Table newTable;
                Microsoft.Office.Interop.Word.Range wrdRng = doc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                newTable = doc.Tables.Add(wrdRng, 1, 5, ref oMissing, ref oMissing);
                newTable.Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle;
                newTable.Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle;
                newTable.AllowAutoFit = true;

                for (int i = 0; i < 5; i++)
                {
                    switch (i + 1)
                    {
                        case 1:
                            newTable.Cell(newTable.Rows.Count, 1).Range.Text = "Nr uchwały";
                            break;
                        case 2:
                            newTable.Cell(newTable.Rows.Count, 2).Range.Text = "Przedmiot uchwały";
                            break;
                        case 3:
                            newTable.Cell(newTable.Rows.Count, 3).Range.Text = "Odpowiedzialny";
                            break;
                        case 4:
                            newTable.Cell(newTable.Rows.Count, 4).Range.Text = "Termin wykonania";
                            break;
                        case 5:
                            newTable.Cell(newTable.Rows.Count, 5).Range.Text = "Uwagi o wykonaniu";
                            break;
                        default:
                            break;
                    }

                }

                foreach (var document in resolutions)
                {
                    newTable.Rows.Add();
                    newTable.Cell(newTable.Rows.Count, 1).Range.Text = document.Name;
                    newTable.Cell(newTable.Rows.Count, 2).Range.Text = document.Description;
                    newTable.Cell(newTable.Rows.Count, 3).Range.Text = document.PersonWhoHasBeenResponsible;
                    newTable.Cell(newTable.Rows.Count, 4).Range.Text = document.CreatedDate.ToString("Y");
                }
            }
        }
    }
}
