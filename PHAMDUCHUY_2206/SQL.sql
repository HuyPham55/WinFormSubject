create table DM_CANBO (
MACB nvarchar(10) NOT NULL primary key, 
HOTEN nvarchar(50) NOT NULL,
NGAYSINH Date, 
GIOITINH nvarchar(3),
DIACHI nvarchar(100), 
CHUCVU nvarchar(50), 
MAPB nvarchar(10) NOT NULL, 
HOCHAM nvarchar(30), 
HOCVI nvarchar(30)
)


create table DM_DETAI (
MADT nvarchar(10) NOT NULL,
TENDT nvarchar(200) NOT NULL, 
LOAIDT nvarchar(30), 
KINHPHI int,
LINHVUC nvarchar(100), 
THOIGIAN int
)

create table DM_PHONGBAN (
MAPB nvarchar(10) NOT NULL,
TENPB nvarchar(100) NOT NULL,
CHUCNANG nvarchar(50), 
DIACHI nvarchar(100), 
DIENTHOAI nvarchar(12)
)


create table DANGKY (
MACB nvarchar(10) NOT NULL,
MADT nvarchar(10) NOT NULL,
NGAYDK Date, 
NGAYHT Date, 
KETQUA nvarchar(30), 
SOTV int, 
GHICHU nvarchar(200)
)

create table LOGIN (
ACC nvarchar(50) NOT NULL,
PASS nvarchar(100), 
QUYEN nvarchar(3)
)


 

 