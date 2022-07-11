use STT18_PhamDucHuy;

CREATE TABLE Khachhang(
	makhach CHAR(10) PRIMARY KEY,
	hoten NVARCHAR(20),
	dienthoai NVARCHAR(20),
	socmt NVARCHAR(50),
	diachi NVARCHAR(50),
	email NVARCHAR(20),
)

CREATE TABLE Hanghoa(
	mahang CHAR(10) PRIMARY KEY,
	tenhang NVARCHAR(20),
	donvitinh NVARCHAR(20),
	mota NVARCHAR(256),
	dongia FLOAT,
	tinhtrang NVARCHAR(20),
)

CREATE TABLE Phieuthu(
	sophieu CHAR(10) PRIMARY KEY,
	mahang CHAR(10),
	makhach CHAR(10),
	ngaylap DATE,
	soluong FLOAT,
	sotien REAL,
	loaiphieu NVARCHAR(20),
)

CREATE TABLE DANGNHAP(
	UserID int not null identity(1,1) PRIMARY KEY,
	Username CHAR(10),
	MatKhau VARCHAR(50),
)

INSERT INTO DANGNHAP(Username, MatKhau)
VALUES
	('User1','HS01123'),
	('User2','HS02123'),
	('User3','HS03123'),
	('User4','HS04123'),
	('User5','HS05123'),
	('User6','HS06123'),
	('User7','GV01123'),
	('User8','GV02123')



INSERT INTO Khachhang(makhach, hoten)
VALUES
	('KH01',N'Nguyen Van A'),
	('KH02',N'Nguyen Van B'),
	('KH03',N'Nguyen Van C'),
	('KH04',N'Nguyen Van D'),
	('KH05',N'Nguyen Van E')

	
INSERT INTO Hanghoa(mahang, tenhang, dongia)
VALUES
	('MH01',N'Hang hoa 1', 10000),
	('MH02',N'Hang hoa 2', 20000),
	('MH03',N'Hang hoa 3', 30000),
	('MH04',N'Hang hoa 4', 40000),
	('MH05',N'Hang hoa 5', 50000)

