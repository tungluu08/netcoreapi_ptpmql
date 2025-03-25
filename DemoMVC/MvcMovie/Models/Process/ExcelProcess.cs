using System.Data;
using OfficeOpenXml;

public class ExcelProcess
{
    public static DataTable ExcelPackageToDataTable(ExcelPackage excelPackage)
    {
        DataTable dt = new DataTable();
        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets[1];

        // Kiểm tra nếu worksheet rỗng
        if (worksheet.Dimension == null)
        {
            return dt;
        }

        // Tạo danh sách để lưu tiêu đề cột
        List<string> columnNames = new List<string>();
        int currentColumn = 1;

        // Lặp qua tất cả các cột trong sheet
        foreach (var cell in worksheet.Cells[1, 1, 1, worksheet.Dimension.End.Column])
        {
            string columnName = cell.Text.Trim();

            // Kiểm tra nếu tiêu đề cột bị trống, đặt tên Header_x
            if (string.IsNullOrEmpty(columnName))
            {
                columnName = "Header_" + currentColumn;
            }

            // Tránh lỗi trùng tên cột
            int occurrences = columnNames.Count(x => x.Equals(columnName));
            if (occurrences > 0)
            {
                columnName = columnName + "_" + occurrences;
            }

            // Thêm vào danh sách và DataTable
            columnNames.Add(columnName);
            dt.Columns.Add(columnName);

            currentColumn++;
        }

        // Bắt đầu thêm nội dung vào DataTable
        for (int i = 2; i <= worksheet.Dimension.End.Row; i++)
        {
            var row = worksheet.Cells[i, 1, i, worksheet.Dimension.End.Column];
            DataRow newRow = dt.NewRow();

            foreach (var cell in row)
            {
                newRow[cell.Start.Column - 1] = cell.Text;
            }

            dt.Rows.Add(newRow);
        }

        return dt;
    }
}
