CREATE DATABASE QLNS;
GO
--2
USE QLNS;
GO

SET DATEFORMAT DMY;
GO

-- Tạo bảng NhaXuatBan
CREATE TABLE NhaXuatBan
(
    NXBID INT PRIMARY KEY,  
    TenNXB VARCHAR(100), 
    Email VARCHAR(100),  
    DiaChi VARCHAR(255),  
    SDT VARCHAR(15)
);
GO

-- Tạo bảng KhachHang
CREATE TABLE KhachHang
(
    MaKH VARCHAR(50) PRIMARY KEY,
    TenKH VARCHAR(100),  
    NgaySinh DATE,  
    GT CHAR(3),
    CCCD VARCHAR(12) UNIQUE, -- Không trùng lặp
    SDT VARCHAR(15)
);
GO

-- Tạo bảng NhanVien
CREATE TABLE NhanVien
(
    MaNV VARCHAR(50) PRIMARY KEY, 
    TenNV VARCHAR(100),  
    NgaySinh DATE,
    GT CHAR(3), 
    CCCD VARCHAR(12) UNIQUE, -- Không trùng lặp
    DiaChi VARCHAR(255), 
    SDT VARCHAR(15)
);
GO

-- Tạo bảng Sach
CREATE TABLE Sach
(
    IDSach VARCHAR(50) PRIMARY KEY, 
    TenSach VARCHAR(100), 
    TacGia VARCHAR(100),  
    DonGia INT,  
    TongSL INT,  
    TheLoaiID INT,  
    NXBID INT, 
    FOREIGN KEY (NXBID) REFERENCES NhaXuatBan(NXBID)
);
GO

-- Tạo bảng HoaDon
CREATE TABLE HoaDon
(
    MaHD VARCHAR(50) PRIMARY KEY, 
    NgayLap DATE,  
    MaKH VARCHAR(50),  
    MaNV VARCHAR(50),  
    TongTien DECIMAL(18, 2),  
    FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH),
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);
GO

-- Tạo bảng HoaDonChiTiet
CREATE TABLE HoaDonChiTiet
(
    ID INT PRIMARY KEY, 
    MaSach VARCHAR(50),  
    SL INT, 
    ThanhTien int,  
    MaHD VARCHAR(50),  
    FOREIGN KEY (MaSach) REFERENCES Sach(IDSach),
    FOREIGN KEY (MaHD) REFERENCES HoaDon(MaHD)
);
GO

CREATE TABLE TaiKhoan3
(

    TenDangNhap VARCHAR(50),  
     MatKhau varchar(50) 
  
);
GO
ALTER TABLE HoaDon
ALTER COLUMN TongTien int;
go
