using System.Diagnostics;
using Bai1C9.Models;
using Bai1C9.Services;

namespace Bai1C9;

public partial class Form1 : Form
{
    private static readonly string[] DanhSachLoai = { "Đồ uống", "Thực phẩm khô", "Gia vị", "Đồ gia dụng" };
    private static readonly string[] DanhSachDonVi = { "Chai", "Gói", "Hộp", "Túi" };

    private readonly HangHoaService _dichVu = new();
    private int? _maDangChon;
    private bool _sanSang;

    public Form1()
    {
        InitializeComponent();
        CauHinhGiaoDien();
        TaoCotLuoi();
    }

    private void CauHinhGiaoDien()
    {
        cboLoai.Items.AddRange(DanhSachLoai);
        cboDonVi.Items.AddRange(DanhSachDonVi);
        cboLocLoai.Items.Add("Tất cả loại");
        cboLocLoai.Items.AddRange(DanhSachLoai);
        cboLocLoai.SelectedIndex = 0;

        nudGiaBan.Minimum = 0;
        nudGiaBan.Maximum = 1_000_000_000;
        nudGiaBan.Increment = 500;
        nudGiaBan.ThousandsSeparator = true;

        nudSoLuong.Minimum = 0;
        nudSoLuong.Maximum = 1_000_000;

        dtpNgayNhap.Format = DateTimePickerFormat.Custom;
        dtpNgayNhap.CustomFormat = "dd/MM/yyyy";

        dgvHangHoa.AutoGenerateColumns = false;
        dgvHangHoa.AllowUserToAddRows = false;
        dgvHangHoa.AllowUserToDeleteRows = false;
        dgvHangHoa.ReadOnly = true;
        dgvHangHoa.MultiSelect = false;
        dgvHangHoa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvHangHoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        XoaForm();
    }

    private void TaoCotLuoi()
    {
        dgvHangHoa.Columns.Clear();
        dgvHangHoa.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MaHang", HeaderText = "Mã", FillWeight = 40 });
        dgvHangHoa.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TenHang", HeaderText = "Tên hàng", FillWeight = 200 });
        dgvHangHoa.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "LoaiHang", HeaderText = "Loại hàng", FillWeight = 100 });
        dgvHangHoa.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DonVi", HeaderText = "Đơn vị", FillWeight = 70 });
        dgvHangHoa.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "GiaBan",
            HeaderText = "Giá bán",
            FillWeight = 80,
            DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight }
        });
        dgvHangHoa.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "SoLuongTon",
            HeaderText = "Tồn",
            FillWeight = 50,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight }
        });
        dgvHangHoa.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "NgayNhap",
            HeaderText = "Ngày nhập",
            FillWeight = 90,
            DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
        });
        dgvHangHoa.Columns.Add(new DataGridViewCheckBoxColumn { DataPropertyName = "ConKinhDoanh", HeaderText = "Kinh doanh", FillWeight = 70 });
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        _sanSang = true;
        try
        {
            TaiLaiLuoi();
        }
        catch (Exception ex)
        {
            ThongBaoLoi(ex);
        }
    }

    private void txtTim_TextChanged(object sender, EventArgs e)
    {
        if (!_sanSang) return;
        timerTim.Stop();
        timerTim.Interval = 350;
        timerTim.Start();
    }

    private void timerTim_Tick(object sender, EventArgs e)
    {
        timerTim.Stop();
        try
        {
            TaiLaiLuoi();
        }
        catch (Exception ex)
        {
            ThongBaoLoi(ex);
        }
    }

    private void cboLocLoai_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (!_sanSang) return;
        try
        {
            TaiLaiLuoi();
        }
        catch (Exception ex)
        {
            ThongBaoLoi(ex);
        }
    }

    private void chkChiConBan_CheckedChanged(object sender, EventArgs e)
    {
        if (!_sanSang) return;
        try
        {
            TaiLaiLuoi();
        }
        catch (Exception ex)
        {
            ThongBaoLoi(ex);
        }
    }

    private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        if (dgvHangHoa.Rows[e.RowIndex].DataBoundItem is HangHoa h)
            DoLenForm(h);
    }

    private void btnThem_Click(object sender, EventArgs e)
    {
        try
        {
            if (!KiemTra()) return;
            var h = DocTuForm();
            _dichVu.Them(h);
            TaiLaiLuoi(h.MaHang);
            MessageBox.Show("Đã thêm mặt hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            ThongBaoLoi(ex);
        }
    }

    private void btnSua_Click(object sender, EventArgs e)
    {
        try
        {
            if (_maDangChon == null)
            {
                MessageBox.Show("Hãy chọn một dòng trên lưới để sửa.", "Chưa chọn hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!KiemTra()) return;
            var h = DocTuForm();
            h.MaHang = _maDangChon.Value;
            _dichVu.Sua(h);
            TaiLaiLuoi(h.MaHang);
            MessageBox.Show("Đã cập nhật mặt hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            ThongBaoLoi(ex);
        }
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
        try
        {
            if (_maDangChon == null)
            {
                MessageBox.Show("Hãy chọn một dòng trên lưới để xóa.", "Chưa chọn hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var kq = MessageBox.Show($"Bạn có chắc muốn xóa mặt hàng \"{txtTenHang.Text}\"?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq != DialogResult.Yes) return;

            _dichVu.Xoa(_maDangChon.Value);
            XoaForm();
            TaiLaiLuoi();
        }
        catch (Exception ex)
        {
            ThongBaoLoi(ex);
        }
    }

    private void btnLamMoi_Click(object sender, EventArgs e)
    {
        try
        {
            _sanSang = false;
            XoaForm();
            txtTim.Text = "";
            timerTim.Stop();
            cboLocLoai.SelectedIndex = 0;
            chkChiConBan.Checked = false;
            _sanSang = true;
            TaiLaiLuoi();
        }
        catch (Exception ex)
        {
            _sanSang = true;
            ThongBaoLoi(ex);
        }
    }

    private void btnXemBangGia_Click(object sender, EventArgs e)
    {
        try
        {
            using var r = BangGiaReport.Tao(_dichVu.LayConBan());
            BangGiaReport.XemTruoc(r);
        }
        catch (Exception ex)
        {
            ThongBaoLoi(ex);
        }
    }

    private void btnXuatPdf_Click(object sender, EventArgs e)
    {
        try
        {
            using var dlg = new SaveFileDialog { Filter = "PDF (*.pdf)|*.pdf", FileName = "BangGia.pdf" };
            if (dlg.ShowDialog(this) != DialogResult.OK) return;

            using var r = BangGiaReport.Tao(_dichVu.LayConBan());
            BangGiaReport.XuatPdf(r, dlg.FileName);
            HoiMoFile(dlg.FileName);
        }
        catch (IOException)
        {
            ThongBaoFileDangMo();
        }
        catch (UnauthorizedAccessException)
        {
            ThongBaoFileDangMo();
        }
        catch (Exception ex)
        {
            ThongBaoLoi(ex);
        }
    }

    private void btnExcelLuoi_Click(object sender, EventArgs e)
    {
        try
        {
            using var dlg = new SaveFileDialog { Filter = "Excel (*.xlsx)|*.xlsx", FileName = "HangHoa.xlsx" };
            if (dlg.ShowDialog(this) != DialogResult.OK) return;

            ExcelExporter.XuatLuoi(dgvHangHoa, dlg.FileName);
            HoiMoFile(dlg.FileName);
        }
        catch (IOException)
        {
            ThongBaoFileDangMo();
        }
        catch (UnauthorizedAccessException)
        {
            ThongBaoFileDangMo();
        }
        catch (Exception ex)
        {
            ThongBaoLoi(ex);
        }
    }

    private void btnExcelTonKho_Click(object sender, EventArgs e)
    {
        try
        {
            using var dlg = new SaveFileDialog { Filter = "Excel (*.xlsx)|*.xlsx", FileName = "TonKho.xlsx" };
            if (dlg.ShowDialog(this) != DialogResult.OK) return;

            ExcelExporter.XuatTonKho(_dichVu.LayConBan(), dlg.FileName);
            HoiMoFile(dlg.FileName);
        }
        catch (IOException)
        {
            ThongBaoFileDangMo();
        }
        catch (UnauthorizedAccessException)
        {
            ThongBaoFileDangMo();
        }
        catch (Exception ex)
        {
            ThongBaoLoi(ex);
        }
    }

    private void TaiLaiLuoi(int? giuMa = null)
    {
        string? loai = cboLocLoai.SelectedIndex > 0 ? cboLocLoai.SelectedItem as string : null;
        var ds = _dichVu.TimKiem(txtTim.Text.Trim(), loai, chkChiConBan.Checked);

        dgvHangHoa.DataSource = ds;
        dgvHangHoa.ClearSelection();
        lblTrangThai.Text = $"Tìm thấy {ds.Count} mặt hàng";

        if (giuMa != null)
            ChonDong(giuMa.Value);
        else
            _maDangChon = null;
    }

    private void ChonDong(int maHang)
    {
        foreach (DataGridViewRow r in dgvHangHoa.Rows)
        {
            if (r.DataBoundItem is HangHoa h && h.MaHang == maHang)
            {
                dgvHangHoa.ClearSelection();
                r.Selected = true;
                dgvHangHoa.CurrentCell = r.Cells[1];
                DoLenForm(h);
                return;
            }
        }
        _maDangChon = null;
    }

    private void DoLenForm(HangHoa h)
    {
        _maDangChon = h.MaHang;
        txtTenHang.Text = h.TenHang;
        cboLoai.SelectedItem = h.LoaiHang;
        cboDonVi.SelectedItem = h.DonVi;
        nudGiaBan.Value = Math.Min(h.GiaBan, nudGiaBan.Maximum);
        nudSoLuong.Value = Math.Min(h.SoLuongTon, (int)nudSoLuong.Maximum);
        dtpNgayNhap.Value = h.NgayNhap;
        chkConKinhDoanh.Checked = h.ConKinhDoanh;
    }

    private HangHoa DocTuForm()
    {
        return new HangHoa
        {
            TenHang = txtTenHang.Text.Trim(),
            LoaiHang = cboLoai.SelectedItem as string,
            DonVi = cboDonVi.SelectedItem as string,
            GiaBan = nudGiaBan.Value,
            SoLuongTon = (int)nudSoLuong.Value,
            NgayNhap = dtpNgayNhap.Value,
            ConKinhDoanh = chkConKinhDoanh.Checked
        };
    }

    private void XoaForm()
    {
        _maDangChon = null;
        txtTenHang.Clear();
        cboLoai.SelectedIndex = -1;
        cboDonVi.SelectedIndex = -1;
        nudGiaBan.Value = 0;
        nudSoLuong.Value = 0;
        dtpNgayNhap.Value = DateTime.Now;
        chkConKinhDoanh.Checked = true;
    }

    private bool KiemTra()
    {
        if (string.IsNullOrWhiteSpace(txtTenHang.Text))
        {
            MessageBox.Show("Tên hàng không được để trống.", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtTenHang.Focus();
            return false;
        }
        if (nudGiaBan.Value <= 0)
        {
            MessageBox.Show("Giá bán phải lớn hơn 0.", "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            nudGiaBan.Focus();
            return false;
        }
        return true;
    }

    private void HoiMoFile(string duongDan)
    {
        var hoi = MessageBox.Show("Đã lưu file thành công. Bạn có muốn mở file không?",
            "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (hoi == DialogResult.Yes)
            Process.Start(new ProcessStartInfo(duongDan) { UseShellExecute = true });
    }

    private void ThongBaoFileDangMo()
    {
        MessageBox.Show("Không ghi được file. Có thể file đang được mở trong chương trình khác (ví dụ Excel).\nHãy đóng file rồi thử lại.",
            "Không thể lưu file", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    private void ThongBaoLoi(Exception ex)
    {
        MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}