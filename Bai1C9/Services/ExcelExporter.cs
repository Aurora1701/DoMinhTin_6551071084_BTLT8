using ClosedXML.Excel;
using Bai1C9.Models;

namespace Bai1C9.Services;

public static class ExcelExporter
{
    public static void XuatLuoi(DataGridView luoi, string duongDan)
    {
        using var wb = new XLWorkbook();
        var ws = wb.Worksheets.Add("HangHoa");

        var cot = luoi.Columns.Cast<DataGridViewColumn>()
            .Where(c => c.Visible)
            .OrderBy(c => c.DisplayIndex)
            .ToList();

        for (int i = 0; i < cot.Count; i++)
            ws.Cell(1, i + 1).Value = cot[i].HeaderText;

        int dong = 2;
        foreach (DataGridViewRow row in luoi.Rows)
        {
            if (row.IsNewRow) continue;
            for (int i = 0; i < cot.Count; i++)
                GhiO(ws.Cell(dong, i + 1), row.Cells[cot[i].Index].Value);
            dong++;
        }

        ws.Row(1).Style.Font.Bold = true;
        ws.Columns().AdjustToContents();
        wb.SaveAs(duongDan);
    }

    public static void XuatTonKho(List<HangHoa> danhSach, string duongDan)
    {
        using var wb = new XLWorkbook();
        var ws = wb.Worksheets.Add("TonKho");

        string[] tieuDe = { "STT", "Tên hàng", "Loại hàng", "Đơn vị", "Giá bán", "Số lượng tồn", "Ngày nhập", "Giá trị tồn" };
        for (int i = 0; i < tieuDe.Length; i++)
            ws.Cell(1, i + 1).Value = tieuDe[i];

        int dong = 2;
        int stt = 1;
        foreach (var h in danhSach)
        {
            ws.Cell(dong, 1).Value = stt++;
            ws.Cell(dong, 2).Value = h.TenHang;
            ws.Cell(dong, 3).Value = h.LoaiHang ?? "";
            ws.Cell(dong, 4).Value = h.DonVi ?? "";
            ws.Cell(dong, 5).Value = h.GiaBan;
            ws.Cell(dong, 6).Value = h.SoLuongTon;
            ws.Cell(dong, 7).Value = h.NgayNhap;
            ws.Cell(dong, 8).FormulaA1 = $"E{dong}*F{dong}";
            dong++;
        }

        int cuoiDuLieu = dong - 1;
        ws.Cell(dong, 1).Value = "Tổng";
        ws.Cell(dong, 8).FormulaA1 = danhSach.Count == 0 ? "0" : $"SUM(H2:H{cuoiDuLieu})";
        ws.Row(dong).Style.Font.Bold = true;

        ws.Range(2, 5, dong, 6).Style.NumberFormat.Format = "#,##0";
        ws.Range(2, 8, dong, 8).Style.NumberFormat.Format = "#,##0";
        ws.Range(2, 7, dong, 7).Style.DateFormat.Format = "dd/MM/yyyy";
        ws.Range(2, 5, dong, 8).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
        ws.Range(2, 1, dong, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

        ws.Row(1).Style.Font.Bold = true;
        ws.Range(1, 1, cuoiDuLieu, 8).SetAutoFilter();
        ws.SheetView.FreezeRows(1);
        ws.Columns().AdjustToContents();

        wb.SaveAs(duongDan);
    }

    private static void GhiO(IXLCell o, object? giaTri)
    {
        switch (giaTri)
        {
            case decimal d:
                o.Value = d;
                o.Style.NumberFormat.Format = "#,##0";
                break;
            case int n:
                o.Value = n;
                break;
            case DateTime t:
                o.Value = t;
                o.Style.DateFormat.Format = "dd/MM/yyyy";
                break;
            case bool b:
                o.Value = b ? "Có" : "Không";
                break;
            default:
                o.Value = giaTri?.ToString() ?? "";
                break;
        }
    }
}