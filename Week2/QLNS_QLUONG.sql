
use QLNS_QLLUONG

create database QLNS_QLLUONG;
use QLNS_QLLUONG;

create table CHUCVU(
	ma_CV char(10) primary key,
	ten_CV nchar(100),
	phu_cap float check(phu_cap >= 0));

create table PHONGBAN(
	ma_PB char(10) primary key,
	ten_PB nchar(100),
	dien_thoai char(12));

create table NHANVIEN(
	ma_NV char(10) primary key,
	ten_NV nchar(40) not null,
	he_so_luong float check(he_so_luong >= 0),
	ma_CV char(10),
	ma_PB char(10),
	foreign key (ma_CV) references CHUCVU(ma_CV),
	foreign key (ma_PB) references PHONGBAN(ma_PB));

create table LUONG(
	ma_luong char(10) primary key,
	ma_NV char(10) references NHANVIEN(ma_NV),
	luong_co_ban float check(luong_co_ban > 0),
	khoan_cong_them float check(khoan_cong_them >= 0),
	khoan_tru float check(khoan_tru >= 0),
        thuc_linh float);


Select * from NHANVIEN
Select * from NHANVIEN where Ma_NV like '2'

select ma_NV as Mã, ten_NV, nhanvien.ma_PB, ten_PB, he_so_luong, ma_CV, dien_thoai
from NHANVIEN, PHONGBAN
where PHONGBAN.ma_PB = NHANVIEN.ma_PB and ma_CV = 'TRP'

Alter Proc SP_TIM_CHUCVU @ma_CV char(10)
as
begin
select ma_NV as Mã, ten_NV as TênNV, nhanvien.ma_PB as MãPB, ten_PB, he_so_luong, ma_CV, dien_thoai
from NHANVIEN, PHONGBAN
where PHONGBAN.ma_PB = NHANVIEN.ma_PB and ma_CV = @ma_CV
end;

EXEC SP_TIM_CHUCVU 'TRP'

select ma_NV, ten_NV, nhanvien.ma_PB, ten_PB, he_so_luong, ma_CV, dien_thoai
from NHANVIEN, PHONGBAN
where PHONGBAN.ma_PB = NHANVIEN.ma_PB and ma_CV = 'TRP'

select ma_NV as [Mã Nhân viên], ten_NV as [Tên nhân viên], nhanvien.ma_PB, ten_PB, 
		he_so_luong,CHUCVU.ma_CV, CHUCVU.ten_CV, dien_thoai
from NHANVIEN, PHONGBAN, CHUCVU
where PHONGBAN.ma_PB = NHANVIEN.ma_PB and nhanvien.ma_PB = 'P4'