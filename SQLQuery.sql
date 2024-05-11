

CREATE DATABASE QuanLyDiem
GO

USE QuanLyDiem
GO

--===================================================================================================================================================

-- Tao Bang Nguoi Dung --
CREATE TABLE NguoiDung
(
	TaiKhoan VARCHAR(30) NOT NULL PRIMARY KEY,
	MatKhau VARCHAR(64) NOT NULL,
	MaQuyen int
)

-- Tao Bang Mon Hoc --
Create Table MonHoc
 (
   MaMH nvarchar(30) primary key,
   TenMH nvarchar(30) not null,
   SoTrinh int not null check ( (SoTrinh>0)and (SoTrinh<7) )
 )
--- Tao Bang He Dao Tao ---
Create Table HeDT
 (
   MaHeDT nvarchar(30) primary key,
   TenHeDT nvarchar(30) not null
 )

--- Tao Bang Khoa Hoc ---
Create Table KhoaHoc
 (
   MaKhoaHoc nvarchar(30) primary key,
   TenKhoaHoc nvarchar(30) not null
 )
--- Tao Bang Khoa --
Create Table Khoa
 (
   MaKhoa nvarchar(30) primary key,
   TenKhoa nvarchar(30) not null,
 )
-- Tao Bang Lop ---
Create Table Lop
 (
   MaLop nvarchar(30) primary key,
   TenLop nvarchar(30) not null,
   
 )
--- Tao Bang Sinh Vien ---
Create Table SinhVien
 (
   MaSV nvarchar(30) primary key,
   TenSV nvarchar(30) ,
   GioiTinh nvarchar(30) ,
   NgaySinh datetime ,
   QueQuan nvarchar(30) ,

   MaLop nvarchar(30) ,
   MaKhoa nvarchar(30) , 
   MaHeDT nvarchar(30) , 
   MaKhoaHoc nvarchar(30) 
 )
--- Tao Bang Diem ---
Create Table Diem
 (
   MaSV nvarchar(30) foreign key references SinhVien(MaSV),
   MaMH nvarchar(30) foreign key references MonHoc(MaMH),
   HocKy int check(HocKy>0) not null,
   DiemLan1 int ,
   DiemLan2 int
)

--===================================================================================================================================================

---Nhap Du Lieu Cho Bang He Dao Tao --
insert into HeDT values('A01',N'Ðại Học')
insert into HeDT values('B01',N'Cao Ðẳng')
insert into HeDT values('C01',N'Trung Cấp')

  Select * from HeDT

-- Nhap Du Lieu Bang Ma Khoa Hoc ---
insert into KhoaHoc values('K1',N'Ðại học khóa 1')
insert into KhoaHoc values('K2',N'Ðại học khóa 2')
insert into KhoaHoc values('K3',N'Ðại học khóa 3')
insert into KhoaHoc values('K9',N'Ðại học khóa 4')
insert into KhoaHoc values('K10',N'Ðại học khóa 5')
insert into KhoaHoc values('K11',N'Ðại học khóa 6')

  Select * from KhoaHoc

-- Nhap Du Lieu bang Khoa --
insert into Khoa values('CNTT',N'Công nghệ thông tin')
insert into Khoa values('CK',N'Nông Nghiệp')
insert into Khoa values('DT',N'Sư Phạm')
insert into Khoa values('KT',N'Kinh Tế')

  Select * from Khoa

--- Nhap Du Lieu Cho Bang Lop --
insert into Lop values('MT1',N'Máy Tính 1')
insert into Lop values('MT2',N'Máy Tính 2')
insert into Lop values('MT3',N'Máy Tính 3')
insert into Lop values('MT4',N'Máy Tính 4')
insert into Lop values('KT1',N'Kinh Tế 1')

 select * from Lop

-- Nhap Du Lieu Bang Sinh Vien --
insert into SinhVien values('DTH210001',N'Nguyễn Văn Một',N'Nam','08/27/2003',N'An Giang','MT3','CNTT','A01','K2')
insert into SinhVien values('DTH210010',N'Nguyễn Văn Hai',N'Nam','02/16/2003',N'Nam Định','MT1','KT','A01','K9')
insert into SinhVien values('DTH210011',N'Nguyễn Văn Ba',N'Nam','07/14/2003',N'Ninh Bình','MT2','CNTT','A01','K3')
insert into SinhVien values('DTH210123',N'Nguyễn Văn Bốn',N'Nam','01/26/2003',N'Cần Thơ','MT1','CNTT','A01','K1')
insert into SinhVien values('DTH210101',N'Nguyễn Thị Mầu',N'Nữ','03/08/2003',N'An Giang','MT3','CNTT','A01','K1')
insert into SinhVien values('DTH210022',N'Nguyễn Văn Sáu',N'Nam','03/24/2003',N'Kiên Giang','MT3','CNTT','A01','K1')
insert into SinhVien values('DTH211126',N'Nguyễn Văn Bảy',N'Nam','02/12/2003',N'An Giang','MT3','KT','A01','K11')
insert into SinhVien values('DTH210987',N'Nguyễn Văn Tám',N'Nam','01/29/2003',N'An Giang','MT2','CNTT','A01','K2')
insert into SinhVien values('DTH210527',N'Nguyễn Văn Chín',N'Nam','05/01/2003',N'An Giang','MT2','CNTT','A01','K3')
insert into SinhVien values('DTH219476',N'Lê Văn Luyện',N'Nam','07/24/2003',N'An Giang','MT2','CNTT','A01','K3')
insert into SinhVien values('DTH213759',N'Nguyễn Thị Tuyết',N'Nữ','01/18/2003',N'An Giang','MT4','CNTT','A01','K10')
insert into SinhVien values('DTH213785',N'Mạc Thị Cam',N'Nữ','02/25/2003',N'An Giang','MT4','KT','A01','K9')
insert into SinhVien values('DTH224367',N'Lê Thị Mười',N'Nữ','05/11/2003',N'Bạc Liêu','MT4','CNTT','A01','K1')
insert into SinhVien values('DTH219999',N'Trần Văn C',N'Nam','07/17/2003',N'Cần Thơ','MT1','CNTT','A01','K2')
insert into SinhVien values('DTH215566',N'Nguyễn Văn F',N'Nam','09/27/2003',N'An Giang','KT1','KT','A01','K9')

select * from SinhVien

-- Nhap Du Lieu Bang Mon Hoc --
insert into MonHoc values('SQL','SQL',5)
insert into MonHoc values('JV','Java',6)
insert into MonHoc values('CNPM',N'Công Nghệ phần mềm',4)
insert into MonHoc values('PTHT',N'Phân tích hệ thống',4)
insert into MonHoc values('MMT',N'Mạng máy tính',5)

  select * from MonHoc

-- Nhap Du Lieu Bang Diem --
insert into Diem(MaSV,MaMH,HocKy,DiemLan1) values('DTH213759','SQL',5,7)
insert into Diem(MaSV,MaMH,HocKy,DiemLan1) values('DTH210987','SQL',5,6)
insert into Diem(MaSV,MaMH,HocKy,DiemLan1) values('DTH219999','CNPM',5,8)
insert into Diem values('DTH213785','SQL',3,4,6)
insert into Diem values('DTH211126','MMT',5,4,5)
insert into Diem values('DTH213759','JV',2,4,4)
insert into Diem values('DTH210987','JV',2,4,6)
insert into Diem values('DTH219999','PTHT',1,2,5)
insert into Diem(MaSV,MaMH,HocKy,DiemLan1) values('DTH215566','SQL',4,9)
insert into Diem(MaSV,MaMH,HocKy,DiemLan1) values('DTH213759','SQL',4,8)
insert into Diem values('DTH210527','MMT',3,3,4)
insert into Diem values('DTH211126','MMT',4,4,4)
insert into Diem(MaSV,MaMH,HocKy,DiemLan1) values('DTH213785','MMT',5,8)

  select * from Diem

--===================================================================================================================================================

select distinct  sv.masv as 'Mã sinh viên' ,sv.tensv as 'Tên sinh viên' ,m.tenmh as 'Tên môn học' ,d.hocky as 'Học kỳ' ,d.diemlan1 as 'Điểm lần 1' ,d.diemlan2 as 'Điểm lần 2'
from diem d , sinhvien sv , MonHoc m
where d.masv = sv.masv and m.mamh = d.mamh
