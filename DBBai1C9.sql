IF DB_ID(N'TiemTapHoa') IS NULL
    CREATE DATABASE TiemTapHoa;
GO

USE TiemTapHoa;
GO

IF OBJECT_ID(N'dbo.HangHoa', N'U') IS NOT NULL
    DROP TABLE dbo.HangHoa;
GO

CREATE TABLE dbo.HangHoa
(
    MaHang INT IDENTITY(1,1) NOT NULL,
    TenHang NVARCHAR(100) NOT NULL,
    LoaiHang NVARCHAR(50) NULL,
    DonVi NVARCHAR(20) NULL,
    GiaBan DECIMAL(18,0) NOT NULL,
    SoLuongTon INT NOT NULL CONSTRAINT DF_HangHoa_SoLuongTon DEFAULT (0),
    NgayNhap DATETIME NOT NULL CONSTRAINT DF_HangHoa_NgayNhap DEFAULT (GETDATE()),
    ConKinhDoanh BIT NOT NULL CONSTRAINT DF_HangHoa_ConKinhDoanh DEFAULT (1),
    CONSTRAINT PK_HangHoa PRIMARY KEY (MaHang),
    CONSTRAINT CK_HangHoa_GiaBan CHECK (GiaBan > 0),
    CONSTRAINT CK_HangHoa_SoLuongTon CHECK (SoLuongTon >= 0)
);
GO

INSERT INTO dbo.HangHoa (TenHang, LoaiHang, DonVi, GiaBan, SoLuongTon, NgayNhap, ConKinhDoanh)
VALUES
 (N'Nước suối Aquafina 500ml', N'Đồ uống',       N'Chai', 6000,  120, '20261002', 1),
 (N'Mì Hảo Hảo tôm chua cay',  N'Thực phẩm khô', N'Gói',  4500,  200, '20261002', 1),
 (N'Dầu ăn Tường An 1L',       N'Gia vị',        N'Chai', 48000, 35,  '20261005', 1),
 (N'Bột giặt OMO 800g',        N'Đồ gia dụng',   N'Túi',  52000, 40,  '20261005', 1),
 (N'Sữa tươi Vinamilk 1L',     N'Đồ uống',       N'Hộp',  32000, 60,  '20261008', 1),
 (N'Nước mắm Nam Ngư 500ml',   N'Gia vị',        N'Chai', 38000, 25,  '20261001', 0);
GO

SELECT * FROM dbo.HangHoa ORDER BY MaHang;
GO