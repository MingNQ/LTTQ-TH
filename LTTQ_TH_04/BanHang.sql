create database BanHang

use BanHang

create table tblMatHang(
	MaSP nchar(5) not null,
	TenSP nvarchar(30) not null,
	NgaySX date null,
	NgayHH date null,
	DonVi nvarchar(10) null,
	DonGia float null,
	GhiChu nvarchar(200) null

	primary key(MaSP)
)