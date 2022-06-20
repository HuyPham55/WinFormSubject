create table loai (
maloaits nvarchar(10) not null primary key,
tenloai nvarchar(50) not null,
dviqly nvarchar(50) not null,
chucnang nchar(10) null,
ghichu nchar(10) null,
);

create table taisan (
	mats nvarchar(10) not null primary key,
	tents nvarchar(50) not null,
	maloaits nvarchar(10) not null,
	namsd int null,
	nuocsx nvarchar(50) null, 
	madv nvarchar(10) not null,
	foreign key (maloaits) references loai(maloaits),
);

create table donvi (
madv nvarchar(10) not null primary key,
tendonvi nvarchar(50) not null,
nguoipt nvarchar(50) not null, 
chucnang nvarchar(50) null,
);

create table dieuchuyen (
madc nvarchar(10) not null primary key,
mats nvarchar(10) not null,
ngaydc datetime not null,
madonvi_den nvarchar(10) not null,
madonvi_di nvarchar(10) not null,
tinhtrang nvarchar(20) null,
foreign key (madonvi_den) references donvi(madv),
foreign key (madonvi_di) references donvi(madv)
)
