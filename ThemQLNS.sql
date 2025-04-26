--them bản nhà xuat bản
INSERT INTO NhaXuatBan (NXBID, TenNXB, Email, DiaChi, SDT)
VALUES 
(1, 'NXB Kim Dong', 'kimdong@gmail.com', 'Ha Noi', '0123456789'),
(2, 'NXB Tre', 'tre@gmail.com', 'TP.HCM', '0987654321'),
(3, 'NXB Giao Duc', 'giaoduc@gmail.com', 'Da Nang', '0912345678'),
(4, 'NXB Van Hoc', 'VanHoc@gmail.com', 'Binh Dinh', '0912345674'),
(5, 'NXB Trinh Chi', 'TrinhChi@gmail.com', 'Do lac', '091234987'),
(6, 'NXB Lao Dong', 'LaoDong@gmail.com', 'Dak lak', '0812345679'),
(7, 'NXB The Gioi', 'TheGioi@gmail.com', 'sai Gon', '0712345679'),
(8, 'NXB Bo Thuong Binh', 'ThuongBinh@gmail.com', 'Nam Dinh', '0712345129'),
(9, 'NXB Luat', 'Luat@gmail.com', 'Tien gian', '0712345569'),
(10, 'NXB Than Dong', 'ThanDong@gmail.com', 'Long Dong', '0912345346');
--Thêm bản Khach hàng
INSERT INTO KhachHang (MaKH, TenKH, NgaySinh, GT, CCCD, SDT)
VALUES 
('KH001', 'Nguyen Van Tai', '1990-05-15', 'Nam', '123456789012', '0901234567'),
('KH002', 'Tran Thi Loc', '1985-11-20', 'Nu', '987654321098', '0912345678'),
('KH003', 'Tran Van Luat', '1989-11-20', 'Nam', '987654321088', '0912345609'),
('KH004', 'Nguyen Thi Thanh', '1990-11-25', 'Nu', '987654321089', '0912345444'),
('KH005', 'Ly Van Luong', '1991-12-20', 'Nam', '987654321333', '0912345555'),
('KH006', 'Tran Van Tuan', '1985-12-21', 'Nam', '987654321444', '0912345666'),
('KH007', 'Le Thi Diem', '1985-12-22', 'Nu', '987654321666', '0912345777'),
('KH008', 'Le Tuan Kiet', '1985-12-27', 'Nam', '987654321101', '0912345102'),
('KH009', 'Le Gia Kiet', '1985-12-30', 'nam', '987654321999', '0912345999'),
('KH010', 'Le Van Khiem', '2000-01-01', 'Nam', '567890123456', '0923456789');
--Them Bản Nhân viên
INSERT INTO NhanVien (MaNV, TenNV, NgaySinh, GT, CCCD, DiaChi, SDT)
VALUES 
('NV001', 'Pham Van teo', '1980-03-25', 'Nam', '111222333444', 'Ha Noi', '0934567890'),
('NV002', 'Ngo Thi no', '1992-07-15', 'Nu', '555666777888', 'TP.HCM', '0945678901'),
('NV003', 'Do Van Manh', '1985-09-10', 'Nam', '999000111222', 'Da Nang', '0956789012'),
('NV004', 'Do Van Nam', '1985-09-11', 'Nam', '999000111223', 'Da Nang', '09567890111'),
('NV005', 'Le Thi Thu Nga', '1990-09-10', 'Nu', '111000111222', 'Dak Lak', '0956789222'),
('NV006', 'Le Van thanh', '1990-09-11', 'Nam', '999000111224', 'Nam Dinh', '09567890111'),
('NV007', 'Nguyen Anh Hao', '1985-09-10', 'Nam', '999000111278', 'Dak Lak', '0956789033'),
('NV008', 'Nguyen Dinh toan', '1991-09-12', 'Nam', '999000111332', 'Ca Mau', '0956789067'),
('NV009', 'Lieu Nhu Yen', '1995-10-22', 'Nu', '999000182821', 'Bac Lieu', '0956789009'),
('NV010', 'Tieu Cuong', '1999-11-19', 'Nam', '999000115421', 'Ben tre', '0956788271');

--thêm bản sách
INSERT INTO Sach (IDSach, TenSach, TacGia, DonGia, TongSL, TheLoaiID, NXBID)
VALUES 
('S001', 'De Men Phieu Luu Ky', 'To Hoai', 50000, 100, 1, 1),
('S002', 'Lao Hac', 'Nam Cao', 40000, 50, 2, 2),
('S003', 'Tat Denn', 'Ngo Tat To', 45000, 70, 3, 3);

--Thêm ban khóa đơn
INSERT INTO HoaDon (MaHD, NgayLap, MaKH, MaNV, TongTien)
VALUES 
('HD001', '2024-01-10', 'KH001', 'NV001', 200000),
('HD002', '2024-01-11', 'KH002', 'NV002', 180000),
('HD003', '2024-01-12', 'KH003', 'NV003', 250000),
('HD004', '2024-01-13', 'KH004', 'NV004', 260000),
('HD005', '2024-01-15', 'KH005', 'NV005', 290000),
('HD006', '2024-01-20', 'KH006', 'NV006', 300000),
('HD007', '2024-01-28', 'KH007', 'NV007', 350000),
('HD008', '2024-01-30', 'KH008', 'NV008', 400000),
('HD009', '2024-02-13', 'KH009', 'NV009', 440000),
('HD010', '2024-02-20', 'KH010', 'NV010', 500000);
--thêm bản Hóa Đơn Chi tiết
INSERT INTO HoaDonChiTiet (ID, MaSach, SL, ThanhTien, MaHD)
VALUES 
(1, 'S001', 2, 100000, 'HD001'),
(2, 'S002', 3, 120000, 'HD002'),
(3, 'S003', 5, 225000, 'HD003');

INSERT INTO Sach (IDSach, TenSach, TacGia, DonGia, TongSL, TheLoaiID, NXBID)
VALUES 
('004', 'Bếp Lửa', 'Tố Hữu', 45000, 70, 3, 3);

INSERT INTO Sach (IDSach, TenSach, TacGia, DonGia, TongSL, TheLoaiID, NXBID)
VALUES 
('005', '2 Bà Cháu', 'Nguyễn Đình Phúc', 45000, 70, 3, 3);
INSERT INTO Sach (IDSach, TenSach, TacGia, DonGia, TongSL, TheLoaiID, NXBID)
VALUES 
('006', '2 Bà Cháu', 'Nguyễn Đình Phúc', 45000, 50, 3, 3);
