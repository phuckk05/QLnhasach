--- lay ma nhan vien 2
go
create proc SP_DSMaNhanV
as
select MaNV
from NhanVien
go

create proc SP_DSTenNhanVien
as
select TenNV
from NhanVien
go

create proc		(@ten varchar(50))
as
select MaNV 
from NhanVien
where @ten = TenNV
go
--exec SP_DSMaNhanV


--lay ma hoa don moi nhat 
go
CREATE PROCEDURE SP_GetLast3DigitsOfMaxMaHDdddd
AS

    SELECT RIGHT(
        (SELECT TOP 1 MaHD
         FROM HoaDon
         ORDER BY MaHD DESC), 3
    ) AS MaHD;

go
--exec SP_GetLast3DigitsOfMaxMaHDdddd
--drop proc SP_GetLast3DigitsOfMaxMaHDdddd

--drop proc SP_TenKH
create proc SP_TenKH(@sdt varchar(15))
as
select TenKH
from KhachHang
where @sdt = SDT
go
--exec SP_TenKH '0901234567';
---lay ma khach hang
create proc SP_MaKH1(@sdt varchar(15))
as
select MaKH
from KhachHang
where @sdt = SDT
go
--drop proc SP_TenDonGia
create proc SP_TenSach(@masach  varchar(50))
as
select TenSach
from Sach
where @masach = IDSach
go
create proc SP_TenDonGia(@masach  varchar(50))
as
select DonGia
from Sach
where @masach = IDSach
go
--exec SP_TenDonGia '005';


create proc SP_TongSLSach(@masach  varchar(50))
as
select TongSL
from Sach
where @masach = IDSach
go
--exec SP_TongSLSach '005';


create proc SP_TimSach10(@masach varchar(50))
as
select *
from Sach
where @masach = IDSach
 go



 --drop proc SP_GetMDCT
 ---lay id cao nhhat
 CREATE PROCEDURE SP_GetMDCT
AS
select  top 1 ID
from HoaDonChiTiet
 ORDER BY ID DESC
 go

--exec SP_GetMDCT

---proc HoaDOn
create proc	SP_HoaDon(@mahdct int,@masach varchar(50),@sl int, @thanhtien int, @mahd VARCHAR(50))
as

insert into HoaDonChiTiet  values (@mahdct ,@masach ,@sl, @thanhtien , @mahd )
go
--drop proc SP_HoaDon

create proc SP_DSCTHD
as
select * 
from HoaDonChiTiet


--exec SP_HoaDon 15, 'S003', 5, 225000, 'HD010';
go
---them du liệu
create proc SP_ThemHoaDOnn(@mahd varchar(50), @ngaylap date, @makh varchar(50), @manv varchar(50), @tongtien int)
as
insert into HoaDon values(@mahd ,@ngaylap, @makh, @manv, @tongtien)

exec SP_ThemHoaDOnn 'HD021','2024-01-21', 'KH001','NV002', 0;


go
create proc SP_DSHoaDon
as
select * 
from HoaDon
	
--exec SP_DSHoaDon
--exec SP_DSCTHD


--proc hoadon chi tiet
go
create proc SP_InhoaDonchiteit(@mahd varchar(10))
as
select k.ID, k.SL, k.SL, k.ThanhTien,k.MaHD , h.NgayLap
from HoaDonChiTiet k , HoaDon h
where @mahd = k.MaHD and k.MaHD = h.MaHD


--exec SP_InhoaDonchiteit 'HD011';
--drop proc SP_InhoaDonchiteit
---update Tong Tien 
go
create proc SP_UpdateTongTien(@mahd varchar(50), @tongtien int)
as
update HoaDon
set TongTien = @tongtien
where @mahd = MaHD

--exec SP_UpdateTongTien 'HD044', 1000;

go
--lay the laoi sách 
create  proc SP_TheLoai
as
select TheLoaiID
from Sach

go

--lay nha xuat ban
create proc SP_Nhaxuatban
as
select NXBID
from  NhaXuatBan
--drop proc SP_Nhaxuatban
--exec SP_Nhaxuatban

go

create proc SP_DSsach
as
select *
from  Sach

--exec SP_Nhaxuatban

---them sach
go
create proc SP_ThemSach(@masach varchar(50), @ten varchar(100), @tacgia varchar(100),@dongia int, @sl int, @theloai int, @nhaxb int)
as
insert into Sach values(@masach , @ten , @tacgia ,@dongia, @sl, @theloai, @nhaxb )



go
---tim sach

create proc SP_TimSach(@masach varchar(50))
as
select *
from Sach
where @masach = IDSach
go

--exec SP_TimSach 'S001'; 

---proc xoa DS sach

create proc SP_XoaSach(@masach varchar(50))
as
delete Sach
where @masach =IDSach



--sua Sach
go
create proc SP_SuaSach(@masach varchar(50), @ten varchar(100), @tacgia varchar(100),@dongia int, @sl int, @theloai int, @nhaxb int)
as
update  Sach
set
TenSach = @ten,
     TacGia= @tacgia ,
	DonGia  = @dongia ,
	 TongSL = @sl,
	 TheLoaiID =@theloai,
	NXBID = @nhaxb 
where IDSach = @masach;
go


---xap sep a -> z
--drop proc SP_XStang
create proc SP_XStang
as
select *
from Sach
 ORDER BY TenSach 
 go

 --exec SP_XStang
---xap sep Z -> A

create proc SP_XSgiam
as
select *
from Sach
 order by TenSach desc
 go

---DS sach

create proc SP_Dsach2
as
select *
from Sach

exec SP_Dsach2
go
---tim bang ma sach 

create proc SP_TimDsSach(@masach varchar(50))
as
select *
from Sach
where @masach = IDSach
go
---tim sach bang ten 
--exec SP_TimSachBangTen 'lao Hac';

create proc SP_TimSachBangTen(@tensach varchar(100))
as
select *
from Sach
where @tensach = TenSach
go
--PROC DS KHACK HÀNG 




create proc SP_DSKhachHang
as
select *
from KhachHang

--Them Khach
go
--exec SP_DSKhachHang

--MaKH VARCHAR(50) PRIMARY KEY,
--    TenKH VARCHAR(100),  
--    NgaySinh DATE,  
--    GT CHAR(3),
--    CCCD VARCHAR(12) UNIQUE, -- Không trùng lặp
--    SDT VARCHAR(15)
--drop proc SP_ThemKhachHang
CREATE PROCEDURE SP_ThemKhachHang
    @makh NVARCHAR(10),
    @tenkh NVARCHAR(50),
    @ngay NVARCHAR(10),
    @gt NVARCHAR(5),
    @cccd NVARCHAR(12),
    @sdt NVARCHAR(15)
AS
BEGIN
    INSERT INTO KhachHang (MaKH, TenKH, NgaySinh, GT, CCCD, SDT)
    VALUES (@makh, @tenkh, @ngay, @gt, @cccd, @sdt)
END
go
exec SP_ThemKhachHang 'KH016','Nguyễn Đình Phúc', '2024-01-10','Nam','012345678989','0898986598';
---Sủa Kach Hang
go
CREATE PROCEDURE SP_SuaKhachHang
    @makh NVARCHAR(10),
    @tenkh NVARCHAR(50),
    @ngay NVARCHAR(10),
    @gt NVARCHAR(5),
    @cccd NVARCHAR(12),
    @sdt NVARCHAR(15)
AS
BEGIN
    UPDATE KhachHang
    SET TenKH = @tenkh,
        NgaySinh = @ngay,
        GT = @gt,
        CCCD = @cccd,
        SDT = @sdt
    WHERE MaKH = @makh
END
--exec SP_SuaKhachHang 'KH001','Nguyen Van Tai ca2', '1990-05-15','Nam','123456789012','0901234567';
---Xoa Khach Hang

go
CREATE PROCEDURE SP_XoaKhachHang
    @makh NVARCHAR(10)
AS
BEGIN
    DELETE FROM KhachHang WHERE MaKH = @makh
END
go

--exec SP_XoaKhachHang 'KH010';
-- poc hóa đơn
-- Nạp toàn bộ HoaDon
--drop proc SP_SuaHoaDon


--poc Hoa Don
CREATE PROCEDURE SP_DSHoaDon2
AS
BEGIN
    SELECT * FROM HoaDon
END
go

-- Tìm kiếm HoaDon theo ngay

--exec SP_TimHoaDonTheoNgay '2024-01-11';
---load makh auto 
go
CREATE PROCEDURE SP_TimHoaDonTheoNgay
    @NgayLap DATE
AS
BEGIN
    SELECT * FROM HoaDon WHERE NgayLap = @NgayLap
END
go

--thêm HD
CREATE PROCEDURE SP_ThemHoaDon
    @MaHD VARCHAR(50),
    @NgayLap DATE,
    @MaKH VARCHAR(50),
    @MaNV VARCHAR(50),
    @TongTien DECIMAL(18, 2)
AS
BEGIN
    INSERT INTO HoaDon (MaHD, NgayLap, MaKH, MaNV, TongTien)
    VALUES (@MaHD, @NgayLap, @MaKH, @MaNV, @TongTien)
END
go

--sửa HD

CREATE PROCEDURE SP_SuaHoaDon
    @MaHD VARCHAR(50),
    @NgayLap DATE,
    @MaKH VARCHAR(50),
    @MaNV VARCHAR(50),
    @TongTien DECIMAL(18, 2)
AS
BEGIN
    UPDATE HoaDon
    SET NgayLap = @NgayLap, MaKH = @MaKH, MaNV = @MaNV, TongTien = @TongTien
    WHERE MaHD = @MaHD
END
go


--SELECT  * FROM HoaDon
--xóa HD
CREATE PROCEDURE SP_XoaHoaDon
    @MaHD VARCHAR(50)
AS
BEGIN
    DELETE FROM HoaDon WHERE MaHD = @MaHD
END
go 

CREATE PROCEDURE SP_MaKHAuTO
AS

    SELECT RIGHT(
        (SELECT TOP 1 MaKH
         FROM KhachHang
         ORDER BY MaKH DESC), 3
    ) AS MaKH;

go


-----thongke 

--CREATE proc SP_ThongKKeee(@thang int, @nam int)

--AS
--SELECT  Sum(ct.SL) as SoLuongThang , SUM(k.TongTien) AS TongTienThangNay
--FROM HoaDon k, HoaDonChiTiet ct
-- WHERE MONTH(k.NgayLap) = @thang   AND YEAR(k.NgayLap) = @nam 
    
--exec SP_ThongKKeee '02', '2024';

CREATE PROC SP_ThongKeTheoThanggh(    @Thang INT,
    @Nam INT)

AS
    SELECT 
	       
        COUNT(*) AS SoLuongHoaDon,
		COUnt(hd.MaNV) as SoLuongNhanVienGiaoDich
		,
        SUM(TongTien) AS TongTienThang,
        SUM(SL) AS TongSoLuongSach
    FROM 
        HoaDon hd , HoaDonChiTiet hdct 
   
    WHERE
	 hd.MaHD = hdct.MaHD and
        MONTH(hd.NgayLap) = @Thang
        AND YEAR(hd.NgayLap) = @Nam;



--exec SP_ThongKeTheoThanggh '01', '2025';
go

--them tai khoan 

create proc SP_ThemTKkk(@ten varchar(50), @mk varchar(50))
as
insert into TaiKhoan3 values (@ten, @mk)
go
---kirem tra  tai Khoan 



create proc DS_TK
as
select * from TaiKhoan3
go


--kieam tra 




--kirem tra tai khoan 
create proc DS_TKed(@ten varchar(50), @mk varchar(50))
as
Update TaiKhoan3
set TenDangNhap = @ten,
      MatKhau = @mk
where @ten = TenDangNhap and @mk = MatKhau

go
--- update so luong sach 
create proc SP_Update(@masach varchar(50), @sl int)
as
update Sach
set TongSL = @sl 
where @masach = IDSach
go




create proc sp_LayDSNV
as
  select * from NhanVien
  --test store chay 
exec
  go
  ----Them Nhân Vien
  create proc sp_Themnhanvien(@manv VARCHAR(50), @tennv VARCHAR(100), @ngaysinh DATE , @gioitinh CHAR(3), @cccd VARCHAR(12), @diachi VARCHAR(255), @sodt VARCHAR(15))
as
  insert into nhanvien values(@manv , @tennv , @ngaysinh, @gioitinh , @cccd , @diachi , @sodt )
  --test store chay
  exec sp_Themnhanvien  'NV021', 'Pham Van phat', '1980-03-25', 'Nam', '111222339784', 'Ha Noi', '0934560890'
  --- xoa Nhan vien
go

go
create proc sp_Xoanhanvien6(@manv varchar(50))
as
begin


Delete
from HoaDon
Where MaNV=@manv

Delete
from NhanVien
Where MaNV=@manv
end;
  --test store chay
  exec sp_Xoanhanvien6 'NV066';
 ---sua nhan vien
 go
create proc sp_Suanhanvien1(@manv VARCHAR(50), @tennv VARCHAR(100), @ngaysinh DATE , @gioitinh CHAR(3), @cccd VARCHAR(12), @diachi VARCHAR(255), @sodt VARCHAR(15))
as
Update NhanVien
set TenNV = @tennv,
    NgaySinh = @ngaysinh,
	GT = @gioitinh,
    CCCD = @cccd,
	DiaChi = @diachi,
	SDT=@sodt

Where @manv = MaNV
  --test store chay
go 


---------Nhà xuất bản (phát)
create proc sp_LayDSNXB
as
  select * from NhaXuatBan
  --test store chay 
go 

  ----Them nha xuat ban 
  create proc sp_Themnhaxuatban(@nhaxbid INT, @tennxb VARCHAR(100),@email VARCHAR(100),  @diachi VARCHAR(255), @sodt VARCHAR(15))
as
  insert into NhaXuatBan values(@nhaxbid, @tennxb ,@email ,  @diachi, @sodt )
  --test store chay
  --exec sp_Themnhaxuatban 12, 'NXB Phat', 'Phat@gmail.com', 'Ha Noi', '0123456789'

  ----xoa nha xuat ban 
  go
create proc sp_Xoanhaxuatban(@nhaxbid INT)
as
Delete NhaXuatBan
Where NXBID=@nhaxbid
--  --test store chay
--exec sp_Xoanhaxuatban 12

-----sua nha xuat ban 
go
create proc sp_Suanhaxuatban(@nhaxbid INT, @tennxb VARCHAR(100),@email VARCHAR(100),  @diachi VARCHAR(255), @sodt VARCHAR(15))
as
Update NhaXuatBan
set TenNXB = @tennxb,
    Email = @tennxb,
	DiaChi = @diachi,
	SDT=@sodt

Where NXBID=@nhaxbid

go
  --test store chay
--exec sp_Suanhaxuatban 1, 'NXB Phat', 'kimdong@gmail.com', 'Ha Noi', '0123456789'

---tim nha xuat ban theo ten

create proc SP_TimNXBBB(@nhaxbid INT)
as
select *
from NhaXuatBan
where @nhaxbid = NXBID



--exec SP_Update 'S004', '1000';
go
--report HoaDon
create proc SP_BaoCaoHoaDon
as
select *
from HoaDon

GO

CREATE PROC sp_HoaDOntheoNamThang(@thang int, @nam int)
as
SELECT 
	 *      
     
    FROM 
        HoaDon hd , HoaDonChiTiet hdct 
   
    WHERE
	 hd.MaHD = hdct.MaHD and
        MONTH(hd.NgayLap) = @Thang
        AND YEAR(hd.NgayLap) = @Nam;

		go

CREATE PROC sp_HoaDOntheoNamThang1(@thang int, @nam int)
as
SELECT 
	 *      
     
    FROM 
        HoaDon hd 
   
    WHERE

        MONTH(hd.NgayLap) = @Thang
        AND YEAR(hd.NgayLap) = @Nam;

go

---thong ke khach hang 

 create proc SP_BaoCaoKhachHang1(@thang int, @nam int)
 as
 select k.MaKH, k.TenKH, k.CCCD, k.GT, k.NgaySinh, k.SDT,sum(hdct.SL) as Tsl
 from KhachHang k, HoaDon h , HoaDonChiTiet hdct 
 where k.MaKH = h.MaKH and h.MaHD = hdct.MaHD and  MONTH(h.NgayLap) = @Thang
        AND YEAR(h.NgayLap) = @Nam
group by k.MaKH, k.TenKH, k.CCCD, k.GT, k.NgaySinh, k.SDT

----thong ke nhan vien 
--create proc SP_BaoCaoNhanVien(@thang int, @nam int)
-- as
-- select n.MaNV, n.TenNV, n.CCCD, n.GT, n.NgaySinh, n.SDT,sum(hdct.SL) as Tsl
-- from NhanVien n, HoaDon h , HoaDonChiTiet hdct 
-- where n.MaNV = h.MaNV and h.MaHD = hdct.MaHD and  MONTH(h.NgayLap) = @Thang
--        AND YEAR(h.NgayLap) = @Nam
--group by k.MaKH, k.TenKH, k.CCCD, k.GT, k.NgaySinh, k.SDT

go
create proc SP_LayMaNVTheoTent(@ten varchar(50))
as
select MaNV
fROM NhanVien
WHERE @ten = TenNV

go
create proc HOaDonInrakhachhang(@mahd varchar(50))
as
select *
from HoaDonChiTiet
where @mahd = MaHD


--lay ten 
create proc SP_LayNXB
as
select TenNXB
from NhaXuatBan

create proc SP_LayMaNV
as
select MaNV
from NhanVien



create proc SP_LayMaKH
as
select MaKH
from KhachHang