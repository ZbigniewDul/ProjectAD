using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAD
{
    public class ExportDataGridToWordTable
    {
        public ExportDataGridToWordTable()
        {
        }

        public static void ExportToWord(DataGridView dgv)
        {
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
                newTable = doc.Tables.Add(wrdRng, 1, dgv.Columns.Count - 1, ref oMissing, ref oMissing);
                newTable.Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle;
                newTable.Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle;
                newTable.AllowAutoFit = true;

                foreach (DataGridViewCell cell in dgv.Rows[0].Cells)
                {
                    newTable.Cell(newTable.Rows.Count, cell.ColumnIndex).Range.Text = dgv.Columns[cell.ColumnIndex].Name;
                }

                newTable.Rows.Add();

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        newTable.Cell(newTable.Rows.Count, cell.ColumnIndex).Range.Text = cell.Value.ToString();
                    }
                    newTable.Rows.Add();
                }
            }
        }
    }
}
