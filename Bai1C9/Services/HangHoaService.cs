using Microsoft.EntityFrameworkCore;
using Bai1C9.Models;

namespace Bai1C9.Services;

public class HangHoaService
{
    public List<HangHoa> TimKiem(string tuKhoa, string? loai, bool chiConBan)
    {
        using var db = new TiemTapHoaContext();
        IQueryable<HangHoa> q = db.Set<HangHoa>().AsNoTracking();

        if (!string.IsNullOrWhiteSpace(tuKhoa))
            q = q.Where(h => h.TenHang.Contains(tuKhoa));
        if (!string.IsNullOrEmpty(loai))
            q = q.Where(h => h.LoaiHang == loai);
        if (chiConBan)
            q = q.Where(h => h.ConKinhDoanh);

        return q.OrderBy(h => h.MaHang).ToList();
    }

    public List<HangHoa> LayConBan() => TimKiem("", null, true);

    public void Them(HangHoa h)
    {
        using var db = new TiemTapHoaContext();
        db.Set<HangHoa>().Add(h);
        db.SaveChanges();
    }

    public void Sua(HangHoa h)
    {
        using var db = new TiemTapHoaContext();
        var cu = db.Set<HangHoa>().Find(h.MaHang)
                 ?? throw new InvalidOperationException("Không tìm thấy mặt hàng cần sửa.");
        cu.TenHang = h.TenHang;
        cu.LoaiHang = h.LoaiHang;
        cu.DonVi = h.DonVi;
        cu.GiaBan = h.GiaBan;
        cu.SoLuongTon = h.SoLuongTon;
        cu.NgayNhap = h.NgayNhap;
        cu.ConKinhDoanh = h.ConKinhDoanh;
        db.SaveChanges();
    }

    public void Xoa(int maHang)
    {
        using var db = new TiemTapHoaContext();
        var cu = db.Set<HangHoa>().Find(maHang);
        if (cu == null) return;
        db.Set<HangHoa>().Remove(cu);
        db.SaveChanges();
    }
}