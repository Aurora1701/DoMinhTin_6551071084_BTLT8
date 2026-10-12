using System.Data;
using FastReport;
using FastReport.Export.Pdf;
using Bai1C9.Models;

namespace Bai1C9.Services;

public static class BangGiaReport
{
    private static readonly string DuongDanMau =
        System.IO.Path.Combine(AppContext.BaseDirectory, "Reports", "BangGia.frx");

    public static Report Tao(IEnumerable<HangHoa> danhSach)
    {
        var bang = new DataTable("HangHoa");
        bang.Columns.Add("TenHang", typeof(string));
        bang.Columns.Add("DonVi", typeof(string));
        bang.Columns.Add("GiaBan", typeof(decimal));

        foreach (var h in danhSach)
            bang.Rows.Add(h.TenHang, h.DonVi ?? "", h.GiaBan);

        var report = new Report();
        report.Load(DuongDanMau);
        report.RegisterData(bang, "HangHoa");
        report.GetDataSource("HangHoa").Enabled = true;
        report.SetParameterValue("NgayIn", DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
        return report;
    }

    public static void XemTruoc(Report report)
    {
        if (report.Prepare())
            report.ShowPrepared(true);
    }

    public static void XuatPdf(Report report, string duongDan)
    {
        report.Prepare();
        using var pdf = new PDFExport();
        report.Export(pdf, duongDan);
    }
}