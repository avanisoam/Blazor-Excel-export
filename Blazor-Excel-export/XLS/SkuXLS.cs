using BlazorExcelExport.Models;
using ClosedXML.Excel;

namespace BlazorExcelExport.XLS
{
    public class SkuXLS
    {
        public byte[] Edition(SKU[] data)
        {
            var wb = new XLWorkbook();
            wb.Properties.Author = "the Author";
            wb.Properties.Title = "the Title";
            wb.Properties.Subject = "the Subject";
            wb.Properties.Category = "the Category";
            wb.Properties.Keywords = "the Keywords";
            wb.Properties.Comments = "the Comments";
            wb.Properties.Status = "the Status";
            wb.Properties.LastModifiedBy = "the Last Modified By";
            wb.Properties.Company = "the Company";
            wb.Properties.Manager = "the Manager";

            var ws = wb.Worksheets.Add("SKU");

            ws.Cell(1, 1).Value = "Id";
            ws.Cell(1, 2).Value = "ItemName";
            ws.Cell(1, 3).Value = "Attribute1";
            ws.Cell(1, 4).Value = "Attribute2";
            ws.Cell(1, 5).Value = "Attribute3";

            // Fill a cell with a date
            //var cellDateTime = ws.Cell(1, 2);
            //cellDateTime.Value = new DateTime(2010, 9, 2);
            //cellDateTime.Style.DateFormat.Format = "yyyy-MMM-dd";

            for (int row = 0; row < data.Length; row++)
            {
                // The apostrophe is to force ClosedXML to treat the date as a string
                ws.Cell(row + 1, 1).Value = "'" + data[row].Id.ToString();
                ws.Cell(row + 1, 2).Value = data[row].ItemName;
                ws.Cell(row + 1, 3).Value = data[row].Attribute1;
                ws.Cell(row + 1, 4).Value = data[row].Attribute2;
                ws.Cell(row + 1, 5).Value = data[row].Attribute3;
            }

            MemoryStream XLSStream = new();
            wb.SaveAs(XLSStream);

            return XLSStream.ToArray();
        }
    }
}
