namespace Bai1C9
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            grpThongTin = new GroupBox();
            lblTenHang = new Label();
            txtTenHang = new TextBox();
            lblLoaiHang = new Label();
            cboLoai = new ComboBox();
            lblDonVi = new Label();
            cboDonVi = new ComboBox();
            lblGiaBan = new Label();
            nudGiaBan = new NumericUpDown();
            lblSoLuong = new Label();
            nudSoLuong = new NumericUpDown();
            lblNgayNhap = new Label();
            dtpNgayNhap = new DateTimePicker();
            chkConKinhDoanh = new CheckBox();
            grpTimKiem = new GroupBox();
            txtTim = new TextBox();
            cboLocLoai = new ComboBox();
            chkChiConBan = new CheckBox();
            dgvHangHoa = new DataGridView();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            btnXemBangGia = new Button();
            btnXuatPdf = new Button();
            btnExcelLuoi = new Button();
            btnExcelTonKho = new Button();
            statusStrip1 = new StatusStrip();
            lblTrangThai = new ToolStripStatusLabel();
            timerTim = new System.Windows.Forms.Timer(components);
            grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudGiaBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
            grpTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHangHoa).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(lblTenHang);
            grpThongTin.Controls.Add(txtTenHang);
            grpThongTin.Controls.Add(lblLoaiHang);
            grpThongTin.Controls.Add(cboLoai);
            grpThongTin.Controls.Add(lblDonVi);
            grpThongTin.Controls.Add(cboDonVi);
            grpThongTin.Controls.Add(lblGiaBan);
            grpThongTin.Controls.Add(nudGiaBan);
            grpThongTin.Controls.Add(lblSoLuong);
            grpThongTin.Controls.Add(nudSoLuong);
            grpThongTin.Controls.Add(lblNgayNhap);
            grpThongTin.Controls.Add(dtpNgayNhap);
            grpThongTin.Controls.Add(chkConKinhDoanh);
            grpThongTin.Location = new Point(10, 16);
            grpThongTin.Margin = new Padding(3, 4, 3, 4);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Padding = new Padding(3, 4, 3, 4);
            grpThongTin.Size = new Size(539, 191);
            grpThongTin.TabIndex = 0;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin hàng hóa";
            // 
            // lblTenHang
            // 
            lblTenHang.AutoSize = true;
            lblTenHang.Location = new Point(16, 39);
            lblTenHang.Name = "lblTenHang";
            lblTenHang.Size = new Size(72, 20);
            lblTenHang.TabIndex = 0;
            lblTenHang.Text = "Tên hàng:";
            // 
            // txtTenHang
            // 
            txtTenHang.Location = new Point(90, 33);
            txtTenHang.Margin = new Padding(3, 4, 3, 4);
            txtTenHang.Name = "txtTenHang";
            txtTenHang.Size = new Size(426, 27);
            txtTenHang.TabIndex = 0;
            // 
            // lblLoaiHang
            // 
            lblLoaiHang.AutoSize = true;
            lblLoaiHang.Location = new Point(11, 75);
            lblLoaiHang.Name = "lblLoaiHang";
            lblLoaiHang.Size = new Size(77, 20);
            lblLoaiHang.TabIndex = 1;
            lblLoaiHang.Text = "Loại hàng:";
            // 
            // cboLoai
            // 
            cboLoai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoai.Location = new Point(90, 71);
            cboLoai.Margin = new Padding(3, 4, 3, 4);
            cboLoai.Name = "cboLoai";
            cboLoai.Size = new Size(167, 28);
            cboLoai.TabIndex = 1;
            // 
            // lblDonVi
            // 
            lblDonVi.AutoSize = true;
            lblDonVi.Location = new Point(16, 113);
            lblDonVi.Name = "lblDonVi";
            lblDonVi.Size = new Size(55, 20);
            lblDonVi.TabIndex = 2;
            lblDonVi.Text = "Đơn vị:";
            // 
            // cboDonVi
            // 
            cboDonVi.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDonVi.Location = new Point(90, 108);
            cboDonVi.Margin = new Padding(3, 4, 3, 4);
            cboDonVi.Name = "cboDonVi";
            cboDonVi.Size = new Size(167, 28);
            cboDonVi.TabIndex = 2;
            // 
            // lblGiaBan
            // 
            lblGiaBan.AutoSize = true;
            lblGiaBan.Location = new Point(17, 147);
            lblGiaBan.Name = "lblGiaBan";
            lblGiaBan.Size = new Size(63, 20);
            lblGiaBan.TabIndex = 3;
            lblGiaBan.Text = "Giá bán:";
            // 
            // nudGiaBan
            // 
            nudGiaBan.Location = new Point(90, 145);
            nudGiaBan.Margin = new Padding(3, 4, 3, 4);
            nudGiaBan.Name = "nudGiaBan";
            nudGiaBan.Size = new Size(168, 27);
            nudGiaBan.TabIndex = 3;
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(273, 74);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(98, 20);
            lblSoLuong.TabIndex = 4;
            lblSoLuong.Text = "Số lượng tồn:";
            // 
            // nudSoLuong
            // 
            nudSoLuong.Location = new Point(377, 71);
            nudSoLuong.Margin = new Padding(3, 4, 3, 4);
            nudSoLuong.Name = "nudSoLuong";
            nudSoLuong.Size = new Size(143, 27);
            nudSoLuong.TabIndex = 4;
            // 
            // lblNgayNhap
            // 
            lblNgayNhap.AutoSize = true;
            lblNgayNhap.Location = new Point(280, 113);
            lblNgayNhap.Name = "lblNgayNhap";
            lblNgayNhap.Size = new Size(84, 20);
            lblNgayNhap.TabIndex = 5;
            lblNgayNhap.Text = "Ngày nhập:";
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.Location = new Point(377, 108);
            dtpNgayNhap.Margin = new Padding(3, 4, 3, 4);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(142, 27);
            dtpNgayNhap.TabIndex = 5;
            // 
            // chkConKinhDoanh
            // 
            chkConKinhDoanh.AutoSize = true;
            chkConKinhDoanh.Checked = true;
            chkConKinhDoanh.CheckState = CheckState.Checked;
            chkConKinhDoanh.Location = new Point(377, 148);
            chkConKinhDoanh.Margin = new Padding(3, 4, 3, 4);
            chkConKinhDoanh.Name = "chkConKinhDoanh";
            chkConKinhDoanh.Size = new Size(134, 24);
            chkConKinhDoanh.TabIndex = 6;
            chkConKinhDoanh.Text = "Còn kinh doanh";
            chkConKinhDoanh.UseVisualStyleBackColor = true;
            // 
            // grpTimKiem
            // 
            grpTimKiem.Controls.Add(txtTim);
            grpTimKiem.Controls.Add(cboLocLoai);
            grpTimKiem.Controls.Add(chkChiConBan);
            grpTimKiem.Location = new Point(561, 16);
            grpTimKiem.Margin = new Padding(3, 4, 3, 4);
            grpTimKiem.Name = "grpTimKiem";
            grpTimKiem.Padding = new Padding(3, 4, 3, 4);
            grpTimKiem.Size = new Size(334, 191);
            grpTimKiem.TabIndex = 1;
            grpTimKiem.TabStop = false;
            grpTimKiem.Text = "Tìm kiếm";
            // 
            // txtTim
            // 
            txtTim.Location = new Point(17, 33);
            txtTim.Margin = new Padding(3, 4, 3, 4);
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(299, 27);
            txtTim.TabIndex = 0;
            txtTim.TextChanged += txtTim_TextChanged;
            // 
            // cboLocLoai
            // 
            cboLocLoai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocLoai.Location = new Point(17, 75);
            cboLocLoai.Margin = new Padding(3, 4, 3, 4);
            cboLocLoai.Name = "cboLocLoai";
            cboLocLoai.Size = new Size(299, 28);
            cboLocLoai.TabIndex = 1;
            cboLocLoai.SelectedIndexChanged += cboLocLoai_SelectedIndexChanged;
            // 
            // chkChiConBan
            // 
            chkChiConBan.AutoSize = true;
            chkChiConBan.Location = new Point(17, 119);
            chkChiConBan.Margin = new Padding(3, 4, 3, 4);
            chkChiConBan.Name = "chkChiConBan";
            chkChiConBan.Size = new Size(226, 24);
            chkChiConBan.TabIndex = 2;
            chkChiConBan.Text = "Chỉ hiện hàng còn kinh doanh";
            chkChiConBan.UseVisualStyleBackColor = true;
            chkChiConBan.CheckedChanged += chkChiConBan_CheckedChanged;
            // 
            // dgvHangHoa
            // 
            dgvHangHoa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHangHoa.ColumnHeadersHeight = 29;
            dgvHangHoa.Location = new Point(10, 219);
            dgvHangHoa.Margin = new Padding(3, 4, 3, 4);
            dgvHangHoa.Name = "dgvHangHoa";
            dgvHangHoa.RowHeadersWidth = 51;
            dgvHangHoa.Size = new Size(885, 267);
            dgvHangHoa.TabIndex = 2;
            dgvHangHoa.CellClick += dgvHangHoa_CellClick;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnThem.Location = new Point(10, 496);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(80, 37);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSua.Location = new Point(99, 496);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(80, 37);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnXoa.Location = new Point(189, 496);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(80, 37);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLamMoi.Location = new Point(278, 496);
            btnLamMoi.Margin = new Padding(3, 4, 3, 4);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(86, 37);
            btnLamMoi.TabIndex = 6;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXemBangGia
            // 
            btnXemBangGia.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnXemBangGia.Location = new Point(412, 496);
            btnXemBangGia.Margin = new Padding(3, 4, 3, 4);
            btnXemBangGia.Name = "btnXemBangGia";
            btnXemBangGia.Size = new Size(109, 37);
            btnXemBangGia.TabIndex = 7;
            btnXemBangGia.Text = "Xem bảng giá";
            btnXemBangGia.UseVisualStyleBackColor = true;
            btnXemBangGia.Click += btnXemBangGia_Click;
            // 
            // btnXuatPdf
            // 
            btnXuatPdf.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnXuatPdf.Location = new Point(529, 496);
            btnXuatPdf.Margin = new Padding(3, 4, 3, 4);
            btnXuatPdf.Name = "btnXuatPdf";
            btnXuatPdf.Size = new Size(86, 37);
            btnXuatPdf.TabIndex = 8;
            btnXuatPdf.Text = "Xuất PDF";
            btnXuatPdf.UseVisualStyleBackColor = true;
            btnXuatPdf.Click += btnXuatPdf_Click;
            // 
            // btnExcelLuoi
            // 
            btnExcelLuoi.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExcelLuoi.Location = new Point(621, 496);
            btnExcelLuoi.Margin = new Padding(3, 4, 3, 4);
            btnExcelLuoi.Name = "btnExcelLuoi";
            btnExcelLuoi.Size = new Size(120, 37);
            btnExcelLuoi.TabIndex = 9;
            btnExcelLuoi.Text = "Xuất Excel (lưới)";
            btnExcelLuoi.UseVisualStyleBackColor = true;
            btnExcelLuoi.Click += btnExcelLuoi_Click;
            // 
            // btnExcelTonKho
            // 
            btnExcelTonKho.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExcelTonKho.Location = new Point(747, 496);
            btnExcelTonKho.Margin = new Padding(3, 4, 3, 4);
            btnExcelTonKho.Name = "btnExcelTonKho";
            btnExcelTonKho.Size = new Size(147, 37);
            btnExcelTonKho.TabIndex = 10;
            btnExcelTonKho.Text = "Xuất Excel tồn kho";
            btnExcelTonKho.UseVisualStyleBackColor = true;
            btnExcelTonKho.Click += btnExcelTonKho_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTrangThai });
            statusStrip1.Location = new Point(0, 547);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(905, 26);
            statusStrip1.TabIndex = 11;
            // 
            // lblTrangThai
            // 
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(145, 20);
            lblTrangThai.Text = "Tìm thấy 0 mặt hàng";
            // 
            // timerTim
            // 
            timerTim.Interval = 350;
            timerTim.Tick += timerTim_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 573);
            Controls.Add(grpThongTin);
            Controls.Add(grpTimKiem);
            Controls.Add(dgvHangHoa);
            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXemBangGia);
            Controls.Add(btnXuatPdf);
            Controls.Add(btnExcelLuoi);
            Controls.Add(btnExcelTonKho);
            Controls.Add(statusStrip1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý hàng hóa - Tạp hóa UTC2";
            Load += Form1_Load;
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudGiaBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
            grpTimKiem.ResumeLayout(false);
            grpTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHangHoa).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private GroupBox grpThongTin;
        private Label lblTenHang;
        private TextBox txtTenHang;
        private Label lblLoaiHang;
        private ComboBox cboLoai;
        private Label lblDonVi;
        private ComboBox cboDonVi;
        private Label lblGiaBan;
        private NumericUpDown nudGiaBan;
        private Label lblSoLuong;
        private NumericUpDown nudSoLuong;
        private Label lblNgayNhap;
        private DateTimePicker dtpNgayNhap;
        private CheckBox chkConKinhDoanh;
        private GroupBox grpTimKiem;
        private TextBox txtTim;
        private ComboBox cboLocLoai;
        private CheckBox chkChiConBan;
        private DataGridView dgvHangHoa;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private Button btnXemBangGia;
        private Button btnXuatPdf;
        private Button btnExcelLuoi;
        private Button btnExcelTonKho;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblTrangThai;
        private System.Windows.Forms.Timer timerTim;
    }
        #endregion
}
