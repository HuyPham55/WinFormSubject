
use QLNS_QLLUONG

    
insert into CHUCVU (ma_CV, ten_CV, phu_cap) values ('GD',N'GIÁM ĐỐC ', 1)
insert into CHUCVU values ('TRP', N'TRƯỞNG PHÒNG',0.8)
insert into CHUCVU values ('PTP', N'PHÓ TRƯỞNG PHÒNG',0.4)
insert into CHUCVU values ('NV',N'NHÂN VIÊN',0)
select * from CHUCVU


insert into PHONGBAN values ('KTO',N'KẾ TOÁN','03503222333')
insert into PHONGBAN values ('KTH',N'KỸ THUẬT','03503666999')
insert into PHONGBAN values ('TKE',N'THIẾT KẾ','03503444777')


select * from PHONGBAN


insert into NHANVIEN values ('KT01',N' TRIỆU THỊ NGỌC',5.0, 'TRP','KTO')
insert into NHANVIEN values ('KT02',N'NGÔ NGỌC ÁNH',3.5, 'NV','KTO')
insert into NHANVIEN values ('KT03',N'NGUYỄN HỮU HIỆP',6.0,'GD','KTO')


insert into NHANVIEN values ('KTH01',N'LÊ HUY HOANG',3.5,'NV','KTH')
insert into NHANVIEN values ('KTH02',N'LÊ TIẾN DŨNG',4.0,'PTP','KTH')



insert into NHANVIEN values ('TK01',N'NGUYỄN THU THỦY',3.5,'NV','TKE')
insert into NHANVIEN values ('TK02',N'NGUYỄN HỮU TRÍ',5.0,'TRP','TKE')
select * from NHANVIEN



select * from LUONG
insert into LUONG (ma_luong, ma_NV, luong_co_ban, khoan_cong_them, khoan_tru) values ('L1','KT01',1950,1000,200)
insert into LUONG (ma_luong, ma_NV, luong_co_ban, khoan_cong_them, khoan_tru)values ('L2','KT02',1950,500,0)
insert into LUONG (ma_luong, ma_NV, luong_co_ban, khoan_cong_them, khoan_tru)values ('L3','KT03',1950,5000,1000)
insert into LUONG (ma_luong, ma_NV, luong_co_ban, khoan_cong_them, khoan_tru)values ('L4','KTH01',1950,500,0)
insert into LUONG (ma_luong, ma_NV, luong_co_ban, khoan_cong_them, khoan_tru)values ('L5','KTH02',1950,1000,200)
insert into LUONG (ma_luong, ma_NV, luong_co_ban, khoan_cong_them, khoan_tru)values ('L6','TK01',1950,500,0)
insert into LUONG (ma_luong, ma_NV, luong_co_ban, khoan_cong_them, khoan_tru)values ('L7','TK02',1950,1000,200)
insert into LUONG (ma_luong, ma_NV, luong_co_ban, khoan_cong_them, khoan_tru)values ('L8','TK02',2000,1000,0)
insert into LUONG (ma_luong, ma_NV, luong_co_ban, khoan_cong_them, khoan_tru)values ('L9','TK02',2000,1000,0)
insert into LUONG (ma_luong, ma_NV, luong_co_ban, khoan_cong_them, khoan_tru)values ('L10','TK02',2000,0,0)
insert into LUONG (ma_luong, ma_NV, luong_co_ban, khoan_cong_them, khoan_tru)values ('L11','TK02',1500,0,0)
insert into LUONG (ma_luong, ma_NV, luong_co_ban, khoan_cong_them, khoan_tru)values ('L91','TK02',1500,0,0)
 








