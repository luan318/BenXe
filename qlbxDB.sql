USE [master]
GO
/****** Object:  Database [QuanLyBenXe]    Script Date: 06/12/2017 7:03:07 PM ******/
CREATE DATABASE [QuanLyBenXe1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyBenXe', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QuanLyBenXe.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyBenXe_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QuanLyBenXe_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

USE [QuanLyBenXe1]
GO
/****** Object:  UserDefinedFunction [dbo].[AddmasoChuyen]    Script Date: 06/12/2017 7:03:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[AddmasoChuyen](@makt char(2))
RETURNS char(6)
AS
BEGIN 
	DECLARE @iMaso int 
  	DECLARE @vMaso varchar(9) 
  	IF @makt='CX' SET @iMaso= (SELECT MAX(RIGHT(IdChuyen, 4)) FROM ChuyenXe)  	
	IF (@iMaso IS NULL) SET @vMaso= @makt+ CONVERT(varchar(6),'0001')
	ELSE
	BEGIN
		SET @iMaso= @iMaso+1
	    	SET @vMaso= '000'+ CONVERT(varchar,@iMaso) 
	    	SET @vMaso= @makt+ RIGHT(@vMaso,4)
	END
RETURN @vMaso 
END

GO
/****** Object:  UserDefinedFunction [dbo].[AddmasoVe]    Script Date: 06/12/2017 7:03:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--------------------------Function cho bang ban ve
CREATE FUNCTION [dbo].[AddmasoVe](@makt char(2))
RETURNS char(6)
AS
BEGIN 
	DECLARE @iMaso int 
  	DECLARE @vMaso varchar(9) 
  	IF @makt='VE' SET @iMaso= (SELECT MAX(RIGHT(IdVe, 4)) FROM BanVe)  	
	IF (@iMaso IS NULL) SET @vMaso= @makt+ CONVERT(varchar(6),'0001')
	ELSE
	BEGIN
		SET @iMaso= @iMaso+1
	    	SET @vMaso= '000'+ CONVERT(varchar,@iMaso) 
	    	SET @vMaso= @makt+ RIGHT(@vMaso,4)
	END
RETURN @vMaso 
END

GO
/****** Object:  Table [dbo].[BanVe]    Script Date: 06/12/2017 7:03:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BanVe](
	[IdVe] [varchar](30) NOT NULL CONSTRAINT [def_BanVe]  DEFAULT ([dbo].[AddmasoVe]('VE')),
	[IdChuyen] [varchar](30) NULL,
	[TenHanhKhach] [nvarchar](30) NULL,
	[SDTHanhKhach] [int] NULL,
 CONSTRAINT [pk_BanVe] PRIMARY KEY CLUSTERED 
(
	[IdVe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChoNgoi]    Script Date: 06/12/2017 7:03:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChoNgoi](
	[IdChuyen] [varchar](30) NOT NULL,
	[So_Xe] [varchar](15) NOT NULL,
	[TenChoNgoi] [nvarchar](10) NOT NULL,
	[IdVe] [varchar](30) NULL,
 CONSTRAINT [pk_ChoNgoi] PRIMARY KEY CLUSTERED 
(
	[IdChuyen] ASC,
	[So_Xe] ASC,
	[TenChoNgoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChuyenXe]    Script Date: 06/12/2017 7:03:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChuyenXe](
	[IdChuyen] [varchar](30) NOT NULL CONSTRAINT [def_ChuyenXe]  DEFAULT ([dbo].[AddmasoChuyen]('CX')),
	[IdTuyen] [varchar](30) NULL,
	[NgayDi] [datetime] NULL,
	[Gio] [varchar](10) NULL,
	[So_Xe] [varchar](15) NULL,
 CONSTRAINT [pk_ChuyenXe] PRIMARY KEY CLUSTERED 
(
	[IdChuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 06/12/2017 7:03:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[id_khach_hang] [int] NOT NULL,
	[ten_khach_hang] [nvarchar](256) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_khach_hang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ManHinh]    Script Date: 06/12/2017 7:03:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ManHinh](
	[id_man_hinh] [int] IDENTITY(1,1) NOT NULL,
	[ten_man_hinh] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_man_hinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 06/12/2017 7:03:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[id_nhan_vien] [int] IDENTITY(1,1) NOT NULL,
	[TaiKhoan] [varchar](50) NOT NULL,
	[MatKhau] [varchar](1000) NOT NULL CONSTRAINT [DF_SomeName]  DEFAULT ((1)),
	[HoatDong] [bit] NULL CONSTRAINT [DF_luan]  DEFAULT ((1)),
PRIMARY KEY CLUSTERED 
(
	[id_nhan_vien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhomNguoiDung]    Script Date: 06/12/2017 7:03:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomNguoiDung](
	[id_nhom_nguoi_dung] [int] IDENTITY(1,1) NOT NULL,
	[ten_nhom_nguoi_dung] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_nhom_nguoi_dung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhanQuyenNguoiDung]    Script Date: 06/12/2017 7:03:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanQuyenNguoiDung](
	[id_nhan_vien] [int] NOT NULL,
	[id_nhom_nguoi_dung] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_nhan_vien] ASC,
	[id_nhom_nguoi_dung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhanQuyenNhom]    Script Date: 06/12/2017 7:03:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanQuyenNhom](
	[id_nhom_nguoi_dung] [int] NOT NULL,
	[id_man_hinh] [int] NOT NULL,
	[quyen] [bit] NULL CONSTRAINT [DF__PhanQuyen__quyen__1ED998B2]  DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[id_nhom_nguoi_dung] ASC,
	[id_man_hinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TuyenXe]    Script Date: 06/12/2017 7:03:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TuyenXe](
	[IdTuyen] [varchar](30) NOT NULL,
	[TenTuyen] [nvarchar](30) NULL,
	[DiaDiemDi] [nvarchar](30) NULL,
	[DiaDiemDen] [nvarchar](30) NULL,
	[GiaVe] [int] NULL,
 CONSTRAINT [pk_TuyenXe] PRIMARY KEY CLUSTERED 
(
	[IdTuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Xe]    Script Date: 06/12/2017 7:03:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Xe](
	[So_Xe] [varchar](15) NOT NULL,
	[Hieu_Xe] [varchar](50) NULL,
	[Doi_Xe] [varchar](4) NULL,
	[So_Cho_Ngoi] [int] NULL,
 CONSTRAINT [pk_Xe] PRIMARY KEY CLUSTERED 
(
	[So_Xe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[BanVe] ([IdVe], [IdChuyen], [TenHanhKhach], [SDTHanhKhach]) VALUES (N'VE0001', N'CX0001', N'Nguyễn Hoàng Luân', 1634140780)
INSERT [dbo].[BanVe] ([IdVe], [IdChuyen], [TenHanhKhach], [SDTHanhKhach]) VALUES (N'VE0002', N'CX0001', N'Nguyễn Thiệu Luân', 982086808)
INSERT [dbo].[BanVe] ([IdVe], [IdChuyen], [TenHanhKhach], [SDTHanhKhach]) VALUES (N'VE0003', N'CX0001', N'Võ Minh Tri', 1674988285)
INSERT [dbo].[BanVe] ([IdVe], [IdChuyen], [TenHanhKhach], [SDTHanhKhach]) VALUES (N'VE0004', N'CX0001', N'Đào Khả Linh', 982300900)
INSERT [dbo].[BanVe] ([IdVe], [IdChuyen], [TenHanhKhach], [SDTHanhKhach]) VALUES (N'VE0005', N'CX0001', N'luana nguyen', 125365)
INSERT [dbo].[BanVe] ([IdVe], [IdChuyen], [TenHanhKhach], [SDTHanhKhach]) VALUES (N'VE0006', N'CX0003', N'123', 456)
INSERT [dbo].[BanVe] ([IdVe], [IdChuyen], [TenHanhKhach], [SDTHanhKhach]) VALUES (N'VE0007', N'CX0002', N'klmdrg', 1236454)
INSERT [dbo].[BanVe] ([IdVe], [IdChuyen], [TenHanhKhach], [SDTHanhKhach]) VALUES (N'VE0008', N'CX0002', N'klmdrg', 1236454)
INSERT [dbo].[BanVe] ([IdVe], [IdChuyen], [TenHanhKhach], [SDTHanhKhach]) VALUES (N'VE0009', N'CX0002', N'klmdrg', 1236454)
INSERT [dbo].[BanVe] ([IdVe], [IdChuyen], [TenHanhKhach], [SDTHanhKhach]) VALUES (N'VE0010', N'CX0002', N'klmdrg', 1236454)
INSERT [dbo].[BanVe] ([IdVe], [IdChuyen], [TenHanhKhach], [SDTHanhKhach]) VALUES (N'VE0011', N'CX0002', N'klmdrg', 1236454)
INSERT [dbo].[BanVe] ([IdVe], [IdChuyen], [TenHanhKhach], [SDTHanhKhach]) VALUES (N'VE0012', N'CX0002', N'jnj', 10012)
INSERT [dbo].[BanVe] ([IdVe], [IdChuyen], [TenHanhKhach], [SDTHanhKhach]) VALUES (N'VE0013', N'CX0005', N'5trfg', 97865421)
INSERT [dbo].[BanVe] ([IdVe], [IdChuyen], [TenHanhKhach], [SDTHanhKhach]) VALUES (N'VE0014', N'CX0005', N'dfxcv ', 5961230)
INSERT [dbo].[BanVe] ([IdVe], [IdChuyen], [TenHanhKhach], [SDTHanhKhach]) VALUES (N'VE0015', N'CX0007', N'aaa', 111)
INSERT [dbo].[BanVe] ([IdVe], [IdChuyen], [TenHanhKhach], [SDTHanhKhach]) VALUES (N'VE0016', N'CX0002', N'ccc', 321)
INSERT [dbo].[BanVe] ([IdVe], [IdChuyen], [TenHanhKhach], [SDTHanhKhach]) VALUES (N'VE0017', N'CX0007', N'nguyen aa', 321)
INSERT [dbo].[BanVe] ([IdVe], [IdChuyen], [TenHanhKhach], [SDTHanhKhach]) VALUES (N'VE0018', N'CX0007', N'nguyen bb', 321123)
INSERT [dbo].[ChoNgoi] ([IdChuyen], [So_Xe], [TenChoNgoi], [IdVe]) VALUES (N'CX0001', N'55Y-7777', N'1', N've0001')
INSERT [dbo].[ChoNgoi] ([IdChuyen], [So_Xe], [TenChoNgoi], [IdVe]) VALUES (N'CX0001', N'55Y-7777', N'14', N'VE0005')
INSERT [dbo].[ChoNgoi] ([IdChuyen], [So_Xe], [TenChoNgoi], [IdVe]) VALUES (N'CX0001', N'55Y-7777', N'15', N've0004')
INSERT [dbo].[ChoNgoi] ([IdChuyen], [So_Xe], [TenChoNgoi], [IdVe]) VALUES (N'CX0001', N'55Y-7777', N'5', N've0002')
INSERT [dbo].[ChoNgoi] ([IdChuyen], [So_Xe], [TenChoNgoi], [IdVe]) VALUES (N'CX0002', N'53Y-7788', N'1', N'VE0012')
INSERT [dbo].[ChoNgoi] ([IdChuyen], [So_Xe], [TenChoNgoi], [IdVe]) VALUES (N'CX0002', N'53Y-7788', N'2', N'VE0007')
INSERT [dbo].[ChoNgoi] ([IdChuyen], [So_Xe], [TenChoNgoi], [IdVe]) VALUES (N'CX0002', N'53Y-7788', N'5', N'VE0016')
INSERT [dbo].[ChoNgoi] ([IdChuyen], [So_Xe], [TenChoNgoi], [IdVe]) VALUES (N'CX0003', N'50S-2934', N'10', N'VE0006')
INSERT [dbo].[ChoNgoi] ([IdChuyen], [So_Xe], [TenChoNgoi], [IdVe]) VALUES (N'CX0003', N'50S-2934', N'11', N'VE0006')
INSERT [dbo].[ChoNgoi] ([IdChuyen], [So_Xe], [TenChoNgoi], [IdVe]) VALUES (N'CX0003', N'50S-2934', N'12', N'VE0006')
INSERT [dbo].[ChoNgoi] ([IdChuyen], [So_Xe], [TenChoNgoi], [IdVe]) VALUES (N'CX0003', N'50S-2934', N'13', N'VE0006')
INSERT [dbo].[ChoNgoi] ([IdChuyen], [So_Xe], [TenChoNgoi], [IdVe]) VALUES (N'CX0003', N'50S-2934', N'14', N'VE0006')
INSERT [dbo].[ChoNgoi] ([IdChuyen], [So_Xe], [TenChoNgoi], [IdVe]) VALUES (N'CX0003', N'50S-2934', N'15', N'VE0006')
INSERT [dbo].[ChoNgoi] ([IdChuyen], [So_Xe], [TenChoNgoi], [IdVe]) VALUES (N'CX0003', N'50S-2934', N'2', N'VE0006')
INSERT [dbo].[ChoNgoi] ([IdChuyen], [So_Xe], [TenChoNgoi], [IdVe]) VALUES (N'CX0003', N'50S-2934', N'3', N'VE0006')
INSERT [dbo].[ChoNgoi] ([IdChuyen], [So_Xe], [TenChoNgoi], [IdVe]) VALUES (N'CX0003', N'50S-2934', N'4', N'VE0006')
INSERT [dbo].[ChoNgoi] ([IdChuyen], [So_Xe], [TenChoNgoi], [IdVe]) VALUES (N'CX0003', N'50S-2934', N'5', N'VE0006')
INSERT [dbo].[ChoNgoi] ([IdChuyen], [So_Xe], [TenChoNgoi], [IdVe]) VALUES (N'CX0003', N'50S-2934', N'6', N'VE0006')
INSERT [dbo].[ChoNgoi] ([IdChuyen], [So_Xe], [TenChoNgoi], [IdVe]) VALUES (N'CX0003', N'50S-2934', N'7', N'VE0006')
INSERT [dbo].[ChoNgoi] ([IdChuyen], [So_Xe], [TenChoNgoi], [IdVe]) VALUES (N'CX0003', N'50S-2934', N'8', N'VE0006')
INSERT [dbo].[ChoNgoi] ([IdChuyen], [So_Xe], [TenChoNgoi], [IdVe]) VALUES (N'CX0005', N'54H-1234', N'2', N'VE0013')
INSERT [dbo].[ChoNgoi] ([IdChuyen], [So_Xe], [TenChoNgoi], [IdVe]) VALUES (N'CX0005', N'54H-1234', N'5', N'VE0013')
INSERT [dbo].[ChoNgoi] ([IdChuyen], [So_Xe], [TenChoNgoi], [IdVe]) VALUES (N'CX0005', N'54H-1234', N'8', N'VE0014')
INSERT [dbo].[ChoNgoi] ([IdChuyen], [So_Xe], [TenChoNgoi], [IdVe]) VALUES (N'CX0007', N'aesrth', N'21', N'VE0017')
INSERT [dbo].[ChoNgoi] ([IdChuyen], [So_Xe], [TenChoNgoi], [IdVe]) VALUES (N'CX0007', N'aesrth', N'26', N'VE0018')
INSERT [dbo].[ChuyenXe] ([IdChuyen], [IdTuyen], [NgayDi], [Gio], [So_Xe]) VALUES (N'CX0001', N'107', CAST(N'2017-11-12 00:00:00.000' AS DateTime), N'5h35', N'55Y-7777')
INSERT [dbo].[ChuyenXe] ([IdChuyen], [IdTuyen], [NgayDi], [Gio], [So_Xe]) VALUES (N'CX0002', N'107', CAST(N'2017-11-14 00:00:00.000' AS DateTime), N'8h30', N'53Y-7788')
INSERT [dbo].[ChuyenXe] ([IdChuyen], [IdTuyen], [NgayDi], [Gio], [So_Xe]) VALUES (N'CX0003', N'250', CAST(N'2017-11-13 00:00:00.000' AS DateTime), N'15h', N'50S-2934')
INSERT [dbo].[ChuyenXe] ([IdChuyen], [IdTuyen], [NgayDi], [Gio], [So_Xe]) VALUES (N'CX0004', N'284', CAST(N'2017-11-14 00:00:00.000' AS DateTime), N'13h', N'52N-3333')
INSERT [dbo].[ChuyenXe] ([IdChuyen], [IdTuyen], [NgayDi], [Gio], [So_Xe]) VALUES (N'CX0005', N'284', CAST(N'2017-11-14 00:00:00.000' AS DateTime), N'6h', N'54H-1234')
INSERT [dbo].[ChuyenXe] ([IdChuyen], [IdTuyen], [NgayDi], [Gio], [So_Xe]) VALUES (N'CX0006', N'23', CAST(N'2017-03-12 00:00:00.000' AS DateTime), N'0h0', N'aesrth')
INSERT [dbo].[ChuyenXe] ([IdChuyen], [IdTuyen], [NgayDi], [Gio], [So_Xe]) VALUES (N'CX0007', N'603', CAST(N'2017-05-12 00:00:00.000' AS DateTime), N'0h0', N'aesrth')
INSERT [dbo].[ChuyenXe] ([IdChuyen], [IdTuyen], [NgayDi], [Gio], [So_Xe]) VALUES (N'CX0008', N'107', CAST(N'2017-05-12 00:00:00.000' AS DateTime), N'0h0', N'123')
INSERT [dbo].[ChuyenXe] ([IdChuyen], [IdTuyen], [NgayDi], [Gio], [So_Xe]) VALUES (N'CX0009', N'284', CAST(N'2017-05-12 00:00:00.000' AS DateTime), N'1h0', N'50S-2934')
INSERT [dbo].[ChuyenXe] ([IdChuyen], [IdTuyen], [NgayDi], [Gio], [So_Xe]) VALUES (N'CX0010', N'23', CAST(N'2017-06-12 00:00:00.000' AS DateTime), N'1h0', N'50S-2934')
INSERT [dbo].[ChuyenXe] ([IdChuyen], [IdTuyen], [NgayDi], [Gio], [So_Xe]) VALUES (N'CX0011', N'503', CAST(N'2017-12-12 00:00:00.000' AS DateTime), N'1h0', N'52N-3333')
INSERT [dbo].[ChuyenXe] ([IdChuyen], [IdTuyen], [NgayDi], [Gio], [So_Xe]) VALUES (N'CX0012', N'107', CAST(N'2017-06-12 00:00:00.000' AS DateTime), N'0h0', N'123')
INSERT [dbo].[ChuyenXe] ([IdChuyen], [IdTuyen], [NgayDi], [Gio], [So_Xe]) VALUES (N'CX0013', N'107', CAST(N'2018-09-01 00:00:00.000' AS DateTime), N'0h0', N'123')
INSERT [dbo].[ChuyenXe] ([IdChuyen], [IdTuyen], [NgayDi], [Gio], [So_Xe]) VALUES (N'CX0014', N'107', CAST(N'2017-04-12 00:00:00.000' AS DateTime), N'0h0', N'123')
SET IDENTITY_INSERT [dbo].[ManHinh] ON 

INSERT [dbo].[ManHinh] ([id_man_hinh], [ten_man_hinh]) VALUES (1, N'GioiThieu')
INSERT [dbo].[ManHinh] ([id_man_hinh], [ten_man_hinh]) VALUES (2, N'QuanLyKhachHang')
INSERT [dbo].[ManHinh] ([id_man_hinh], [ten_man_hinh]) VALUES (3, N'DatVe')
INSERT [dbo].[ManHinh] ([id_man_hinh], [ten_man_hinh]) VALUES (4, N'QuanLyChuyen')
INSERT [dbo].[ManHinh] ([id_man_hinh], [ten_man_hinh]) VALUES (5, N'QuanLyNhanVien')
INSERT [dbo].[ManHinh] ([id_man_hinh], [ten_man_hinh]) VALUES (6, N'ThongKe')
SET IDENTITY_INSERT [dbo].[ManHinh] OFF
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([id_nhan_vien], [TaiKhoan], [MatKhau], [HoatDong]) VALUES (4, N'manager', N'1', 1)
INSERT [dbo].[NhanVien] ([id_nhan_vien], [TaiKhoan], [MatKhau], [HoatDong]) VALUES (6, N'user', N'1', 1)
INSERT [dbo].[NhanVien] ([id_nhan_vien], [TaiKhoan], [MatKhau], [HoatDong]) VALUES (71, N'luan', N'1', 1)
INSERT [dbo].[NhanVien] ([id_nhan_vien], [TaiKhoan], [MatKhau], [HoatDong]) VALUES (74, N'hoang', N'1', 1)
INSERT [dbo].[NhanVien] ([id_nhan_vien], [TaiKhoan], [MatKhau], [HoatDong]) VALUES (78, N'admin3', N'1', 0)
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
SET IDENTITY_INSERT [dbo].[NhomNguoiDung] ON 

INSERT [dbo].[NhomNguoiDung] ([id_nhom_nguoi_dung], [ten_nhom_nguoi_dung]) VALUES (1, N'Admin')
INSERT [dbo].[NhomNguoiDung] ([id_nhom_nguoi_dung], [ten_nhom_nguoi_dung]) VALUES (22, N'FullQuyen')
INSERT [dbo].[NhomNguoiDung] ([id_nhom_nguoi_dung], [ten_nhom_nguoi_dung]) VALUES (23, N'Quản Lýyy')
SET IDENTITY_INSERT [dbo].[NhomNguoiDung] OFF
INSERT [dbo].[PhanQuyenNguoiDung] ([id_nhan_vien], [id_nhom_nguoi_dung]) VALUES (71, 1)
INSERT [dbo].[PhanQuyenNguoiDung] ([id_nhan_vien], [id_nhom_nguoi_dung]) VALUES (71, 22)
INSERT [dbo].[PhanQuyenNguoiDung] ([id_nhan_vien], [id_nhom_nguoi_dung]) VALUES (71, 23)
INSERT [dbo].[PhanQuyenNhom] ([id_nhom_nguoi_dung], [id_man_hinh], [quyen]) VALUES (1, 1, 1)
INSERT [dbo].[PhanQuyenNhom] ([id_nhom_nguoi_dung], [id_man_hinh], [quyen]) VALUES (1, 2, 0)
INSERT [dbo].[PhanQuyenNhom] ([id_nhom_nguoi_dung], [id_man_hinh], [quyen]) VALUES (1, 3, 0)
INSERT [dbo].[PhanQuyenNhom] ([id_nhom_nguoi_dung], [id_man_hinh], [quyen]) VALUES (1, 4, 1)
INSERT [dbo].[PhanQuyenNhom] ([id_nhom_nguoi_dung], [id_man_hinh], [quyen]) VALUES (1, 5, 1)
INSERT [dbo].[PhanQuyenNhom] ([id_nhom_nguoi_dung], [id_man_hinh], [quyen]) VALUES (1, 6, 1)
INSERT [dbo].[PhanQuyenNhom] ([id_nhom_nguoi_dung], [id_man_hinh], [quyen]) VALUES (22, 1, 1)
INSERT [dbo].[PhanQuyenNhom] ([id_nhom_nguoi_dung], [id_man_hinh], [quyen]) VALUES (22, 2, 1)
INSERT [dbo].[PhanQuyenNhom] ([id_nhom_nguoi_dung], [id_man_hinh], [quyen]) VALUES (22, 3, 1)
INSERT [dbo].[PhanQuyenNhom] ([id_nhom_nguoi_dung], [id_man_hinh], [quyen]) VALUES (22, 4, 1)
INSERT [dbo].[PhanQuyenNhom] ([id_nhom_nguoi_dung], [id_man_hinh], [quyen]) VALUES (22, 5, 1)
INSERT [dbo].[PhanQuyenNhom] ([id_nhom_nguoi_dung], [id_man_hinh], [quyen]) VALUES (22, 6, 1)
INSERT [dbo].[PhanQuyenNhom] ([id_nhom_nguoi_dung], [id_man_hinh], [quyen]) VALUES (23, 1, 0)
INSERT [dbo].[PhanQuyenNhom] ([id_nhom_nguoi_dung], [id_man_hinh], [quyen]) VALUES (23, 2, 1)
INSERT [dbo].[PhanQuyenNhom] ([id_nhom_nguoi_dung], [id_man_hinh], [quyen]) VALUES (23, 3, 1)
INSERT [dbo].[PhanQuyenNhom] ([id_nhom_nguoi_dung], [id_man_hinh], [quyen]) VALUES (23, 4, 0)
INSERT [dbo].[PhanQuyenNhom] ([id_nhom_nguoi_dung], [id_man_hinh], [quyen]) VALUES (23, 5, 0)
INSERT [dbo].[PhanQuyenNhom] ([id_nhom_nguoi_dung], [id_man_hinh], [quyen]) VALUES (23, 6, 0)
INSERT [dbo].[TuyenXe] ([IdTuyen], [TenTuyen], [DiaDiemDi], [DiaDiemDen], [GiaVe]) VALUES (N'107', N'Sài Gòn - Nha Trang', N'Sài Gòn', N'Nha Trang', 200000)
INSERT [dbo].[TuyenXe] ([IdTuyen], [TenTuyen], [DiaDiemDi], [DiaDiemDen], [GiaVe]) VALUES (N'153', N'Sài Gòn - Kiên Giang', N'Sài Gòn', N'Kiên Giang', 900000)
INSERT [dbo].[TuyenXe] ([IdTuyen], [TenTuyen], [DiaDiemDi], [DiaDiemDen], [GiaVe]) VALUES (N'173', N'Sài Gòn - Bến Tre', N'Sài Gòn', N'Bến Tre', 100000)
INSERT [dbo].[TuyenXe] ([IdTuyen], [TenTuyen], [DiaDiemDi], [DiaDiemDen], [GiaVe]) VALUES (N'23', N'Sài Gòn - Đà Lạt', N'Sài Gòn', N'Đà Lạt', 180000)
INSERT [dbo].[TuyenXe] ([IdTuyen], [TenTuyen], [DiaDiemDi], [DiaDiemDen], [GiaVe]) VALUES (N'250', N'Sài Gòn - Cần Thơ', N'Sài Gòn', N'Cần Thơ', 80000)
INSERT [dbo].[TuyenXe] ([IdTuyen], [TenTuyen], [DiaDiemDi], [DiaDiemDen], [GiaVe]) VALUES (N'284', N'Sài Gòn - Bình Thuận', N'Sài Gòn', N'Bình Thuận', 150000)
INSERT [dbo].[TuyenXe] ([IdTuyen], [TenTuyen], [DiaDiemDi], [DiaDiemDen], [GiaVe]) VALUES (N'303', N'Sài Gòn - Tiền Giang', N'Sài Gòn', N'Tiền Giang', 170000)
INSERT [dbo].[TuyenXe] ([IdTuyen], [TenTuyen], [DiaDiemDi], [DiaDiemDen], [GiaVe]) VALUES (N'503', N'Sài Gòn - Kon Tum', N'Sài Gòn', N'Kon Tom', 200000)
INSERT [dbo].[TuyenXe] ([IdTuyen], [TenTuyen], [DiaDiemDi], [DiaDiemDen], [GiaVe]) VALUES (N'547', N'Sài Gòn - Phan Thiết', N'Sài Gòn', N'Phan Thiết', 220000)
INSERT [dbo].[TuyenXe] ([IdTuyen], [TenTuyen], [DiaDiemDi], [DiaDiemDen], [GiaVe]) VALUES (N'602', N'Sài Gòn - Vũng Tàu', N'Sài Gòn', N'Vũng Tàu', 200000)
INSERT [dbo].[TuyenXe] ([IdTuyen], [TenTuyen], [DiaDiemDi], [DiaDiemDen], [GiaVe]) VALUES (N'603', N'Sài Gòn - Vũng', N'Sài Gòn', N'Vũng', 100)
INSERT [dbo].[Xe] ([So_Xe], [Hieu_Xe], [Doi_Xe], [So_Cho_Ngoi]) VALUES (N'123', N'dfv12', N'199', 15)
INSERT [dbo].[Xe] ([So_Xe], [Hieu_Xe], [Doi_Xe], [So_Cho_Ngoi]) VALUES (N'50S-2934', N'Hyundai Country', N'2005', 15)
INSERT [dbo].[Xe] ([So_Xe], [Hieu_Xe], [Doi_Xe], [So_Cho_Ngoi]) VALUES (N'50S-9999', N'Huyndai', N'2003', 15)
INSERT [dbo].[Xe] ([So_Xe], [Hieu_Xe], [Doi_Xe], [So_Cho_Ngoi]) VALUES (N'50Y-3669', N'Toyota', N'2009', 15)
INSERT [dbo].[Xe] ([So_Xe], [Hieu_Xe], [Doi_Xe], [So_Cho_Ngoi]) VALUES (N'52N-3333', N'Huyndai Country', N'2008', 15)
INSERT [dbo].[Xe] ([So_Xe], [Hieu_Xe], [Doi_Xe], [So_Cho_Ngoi]) VALUES (N'53Y-7788', N'Ford Everest', N'2009', 15)
INSERT [dbo].[Xe] ([So_Xe], [Hieu_Xe], [Doi_Xe], [So_Cho_Ngoi]) VALUES (N'54H-1234', N'Hyundai Country', N'2008', 15)
INSERT [dbo].[Xe] ([So_Xe], [Hieu_Xe], [Doi_Xe], [So_Cho_Ngoi]) VALUES (N'55Y-7777', N'Ford Transit', N'2010', 15)
INSERT [dbo].[Xe] ([So_Xe], [Hieu_Xe], [Doi_Xe], [So_Cho_Ngoi]) VALUES (N'aesrth', N'uiytr', N'1999', 40)
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__NhanVien__677E7793BBA528D1]    Script Date: 06/12/2017 7:03:07 PM ******/
ALTER TABLE [dbo].[NhanVien] ADD UNIQUE NONCLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__TuyenXe__1BFA862573574128]    Script Date: 06/12/2017 7:03:07 PM ******/
ALTER TABLE [dbo].[TuyenXe] ADD UNIQUE NONCLUSTERED 
(
	[TenTuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[KhachHang] ADD  DEFAULT ('no name') FOR [ten_khach_hang]
GO
ALTER TABLE [dbo].[BanVe]  WITH CHECK ADD  CONSTRAINT [fk_BanVe_ChuyenXe] FOREIGN KEY([IdChuyen])
REFERENCES [dbo].[ChuyenXe] ([IdChuyen])
GO
ALTER TABLE [dbo].[BanVe] CHECK CONSTRAINT [fk_BanVe_ChuyenXe]
GO
ALTER TABLE [dbo].[ChoNgoi]  WITH CHECK ADD  CONSTRAINT [fk_ChoNgoi_BanVe] FOREIGN KEY([IdVe])
REFERENCES [dbo].[BanVe] ([IdVe])
GO
ALTER TABLE [dbo].[ChoNgoi] CHECK CONSTRAINT [fk_ChoNgoi_BanVe]
GO
ALTER TABLE [dbo].[ChoNgoi]  WITH CHECK ADD  CONSTRAINT [fk_ChoNgoi_ChuyenXe] FOREIGN KEY([IdChuyen])
REFERENCES [dbo].[ChuyenXe] ([IdChuyen])
GO
ALTER TABLE [dbo].[ChoNgoi] CHECK CONSTRAINT [fk_ChoNgoi_ChuyenXe]
GO
ALTER TABLE [dbo].[ChoNgoi]  WITH CHECK ADD  CONSTRAINT [fk_ChoNgoi_Xe] FOREIGN KEY([So_Xe])
REFERENCES [dbo].[Xe] ([So_Xe])
GO
ALTER TABLE [dbo].[ChoNgoi] CHECK CONSTRAINT [fk_ChoNgoi_Xe]
GO
ALTER TABLE [dbo].[ChuyenXe]  WITH CHECK ADD  CONSTRAINT [fk_ChuyenXe_TuyenXe] FOREIGN KEY([IdTuyen])
REFERENCES [dbo].[TuyenXe] ([IdTuyen])
GO
ALTER TABLE [dbo].[ChuyenXe] CHECK CONSTRAINT [fk_ChuyenXe_TuyenXe]
GO
ALTER TABLE [dbo].[ChuyenXe]  WITH CHECK ADD  CONSTRAINT [fk_ChuyenXe_Xe] FOREIGN KEY([So_Xe])
REFERENCES [dbo].[Xe] ([So_Xe])
GO
ALTER TABLE [dbo].[ChuyenXe] CHECK CONSTRAINT [fk_ChuyenXe_Xe]
GO
ALTER TABLE [dbo].[PhanQuyenNguoiDung]  WITH CHECK ADD FOREIGN KEY([id_nhan_vien])
REFERENCES [dbo].[NhanVien] ([id_nhan_vien])
GO
ALTER TABLE [dbo].[PhanQuyenNguoiDung]  WITH CHECK ADD FOREIGN KEY([id_nhom_nguoi_dung])
REFERENCES [dbo].[NhomNguoiDung] ([id_nhom_nguoi_dung])
GO
ALTER TABLE [dbo].[PhanQuyenNhom]  WITH CHECK ADD FOREIGN KEY([id_man_hinh])
REFERENCES [dbo].[ManHinh] ([id_man_hinh])
GO
ALTER TABLE [dbo].[PhanQuyenNhom]  WITH CHECK ADD FOREIGN KEY([id_nhom_nguoi_dung])
REFERENCES [dbo].[NhomNguoiDung] ([id_nhom_nguoi_dung])
GO
/****** Object:  StoredProcedure [dbo].[InfoNhanVien]    Script Date: 06/12/2017 7:03:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InfoNhanVien]
AS
BEGIN
	SELECT nv.*, nnd.ten_nhom_nguoi_dung 
	FROM dbo.NhanVien nv, dbo.NhomNguoiDung nnd, dbo.PhanQuyenNguoiDung pqnd
	WHERE nv.id_nhan_vien=pqnd.id_nhan_vien AND pqnd.id_nhom_nguoi_dung=nnd.id_nhom_nguoi_dung
END




GO
/****** Object:  StoredProcedure [dbo].[pro_delete_PhanQuyenNguoiDung]    Script Date: 06/12/2017 7:03:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pro_delete_PhanQuyenNguoiDung]
(
	@IdNhanVien INT,
	@IdNhomNguoiDung INT
)
AS
BEGIN
	DELETE FROM dbo.PhanQuyenNguoiDung WHERE id_nhan_vien=@IdNhanVien AND id_nhom_nguoi_dung = @IdNhomNguoiDung
END

GO
/****** Object:  StoredProcedure [dbo].[pro_delete_PhanQuyenNhom]    Script Date: 06/12/2017 7:03:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pro_delete_PhanQuyenNhom]
(
@id_nhom_nguoi_dung_del INT
)
AS
	DELETE FROM dbo.PhanQuyenNhom WHERE id_nhom_nguoi_dung = @id_nhom_nguoi_dung_del



GO
/****** Object:  StoredProcedure [dbo].[pro_insert_PhanQuyenNguoiung]    Script Date: 06/12/2017 7:03:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pro_insert_PhanQuyenNguoiung]
(
	@IdNhanVien INT,
	@IdNhomNguoiDung int
)
AS
BEGIN
	INSERT INTO dbo.PhanQuyenNguoiDung
	        ( id_nhan_vien ,id_nhom_nguoi_dung) VALUES ( @IdNhanVien , @IdNhomNguoiDung)
END

GO
/****** Object:  StoredProcedure [dbo].[pro_KiemTraDangNhap]    Script Date: 06/12/2017 7:03:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pro_KiemTraDangNhap]
(
	@TaiKhoan VARCHAR(100),
	@MatKhau VARCHAR(100)
)
AS
BEGIN
	SELECT * FROM dbo.NhanVien nv WHERE nv.TaiKhoan = @TaiKhoan AND nv.MatKhau = @MatKhau
END

GO
/****** Object:  StoredProcedure [dbo].[pro_KiemTraHoatDong]    Script Date: 06/12/2017 7:03:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pro_KiemTraHoatDong]
(
	@TaiKhoan VARCHAR(100)
)
AS
BEGIN
	SELECT * FROM dbo.NhanVien nv WHERE nv.TaiKhoan=@TaiKhoan
END

GO
/****** Object:  StoredProcedure [dbo].[pro_KiemTraQuyen]    Script Date: 06/12/2017 7:03:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[pro_KiemTraQuyen]
(
	@TaiKhoan varchar(100)
)
AS
BEGIN
	 SELECT pqn.id_man_hinh
	 FROM dbo.NhanVien nv, dbo.PhanQuyenNguoiDung pqnd, dbo.NhomNguoiDung nnd, dbo.PhanQuyenNhom pqn
	 WHERE nv.id_nhan_vien=pqnd.id_nhan_vien AND pqnd.id_nhom_nguoi_dung = nnd.id_nhom_nguoi_dung AND nnd.id_nhom_nguoi_dung = pqn.id_nhom_nguoi_dung
		AND pqn.quyen=1	AND nv.TaiKhoan = @TaiKhoan
END

GO
/****** Object:  StoredProcedure [dbo].[pro_show_DanhSachNguoiDung_DK]    Script Date: 06/12/2017 7:03:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pro_show_DanhSachNguoiDung_DK]
(
	@IdNhom INT
)
AS
BEGIN
	SELECT nv.*
		FROM dbo.NhanVien nv,dbo.NhomNguoiDung nnd,dbo.PhanQuyenNguoiDung pqnd
		WHERE (nv.id_nhan_vien=pqnd.id_nhan_vien
		AND pqnd.id_nhom_nguoi_dung = nnd.id_nhom_nguoi_dung)
		AND nv.id_nhan_vien NOT IN 
		(SELECT nv.id_nhan_vien FROM dbo.NhanVien nv, dbo.NhomNguoiDung nnd, dbo.PhanQuyenNguoiDung pqnnd
				WHERE nv.id_nhan_vien = pqnnd.id_nhan_vien AND pqnnd.id_nhom_nguoi_dung= nnd.id_nhom_nguoi_dung
															 AND nnd.id_nhom_nguoi_dung=@IdNhom)
		UNION

		SELECT nv.* FROM dbo.NhanVien nv
		WHERE		id_nhan_vien NOT IN 
					(SELECT pqnd.id_nhan_vien FROM dbo.PhanQuyenNguoiDung pqnd)

END

GO
/****** Object:  StoredProcedure [dbo].[pro_show_DanhSachNguoiDung_TheoNhom]    Script Date: 06/12/2017 7:03:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pro_show_DanhSachNguoiDung_TheoNhom]
(
	@IdNhom INT
)
AS
BEGIN
	SELECT nv.*
	FROM dbo.NhanVien nv, dbo.PhanQuyenNguoiDung pqnd, dbo.NhomNguoiDung nnd
	WHERE nv.id_nhan_vien = pqnd.id_nhan_vien AND pqnd.id_nhom_nguoi_dung = nnd.id_nhom_nguoi_dung
			AND nnd.id_nhom_nguoi_dung= @IdNhom
END

GO
/****** Object:  StoredProcedure [dbo].[pro_show_PhanQuyen]    Script Date: 06/12/2017 7:03:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pro_show_PhanQuyen]
(
	@IdNhom INT
)
AS
BEGIN
	SELECT nnd.id_nhom_nguoi_dung, nnd.ten_nhom_nguoi_dung, mh.id_man_hinh, mh.ten_man_hinh, pqn.quyen
	 FROM dbo.NhomNguoiDung nnd, dbo.PhanQuyenNhom pqn, dbo.ManHinh mh
		WHERE nnd.id_nhom_nguoi_dung= pqn.id_nhom_nguoi_dung AND pqn.id_man_hinh=mh.id_man_hinh
			AND nnd.id_nhom_nguoi_dung=@IdNhom
END

GO
/****** Object:  StoredProcedure [dbo].[pro_ThemPhanQuyenNhom]    Script Date: 06/12/2017 7:03:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pro_ThemPhanQuyenNhom]
(
	@Id_nhom int
)
AS
BEGIN
	DECLARE idManHinhCursor CURSOR FOR SELECT id_man_hinh FROM dbo.ManHinh
	OPEN idManHinhCursor
	DECLARE @id_man_hinh INT
	FETCH NEXT FROM idManHinhCursor INTO @id_man_hinh
	WHILE @@FETCH_STATUS = 0
	BEGIN
		INSERT INTO dbo.PhanQuyenNhom( id_nhom_nguoi_dung ,id_man_hinh ,quyen)
		VALUES  ( @Id_nhom ,@id_man_hinh , 0)
		FETCH NEXT FROM idManHinhCursor INTO @id_man_hinh
	END
CLOSE idManHinhCursor
DEALLOCATE idManHinhCursor
END

GO
/****** Object:  StoredProcedure [dbo].[SuaNhomNguoiDung]    Script Date: 06/12/2017 7:03:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Sua Nhom Nguoi Dung
CREATE PROC [dbo].[SuaNhomNguoiDung]
(
	@ten_nhom_nguoi_dung VARCHAR(100),
	@id_nhom_nguoi_dung INT
)
AS
BEGIN
	UPDATE dbo.NhomNguoiDung SET ten_nhom_nguoi_dung=@ten_nhom_nguoi_dung WHERE id_nhom_nguoi_dung=@id_nhom_nguoi_dung
END




GO
/****** Object:  StoredProcedure [dbo].[ThemNhomNguoiDung]    Script Date: 06/12/2017 7:03:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemNhomNguoiDung]
(
	@TenNhom varchar(100)
)
AS
BEGIN
	INSERT INTO dbo.NhomNguoiDung
( ten_nhom_nguoi_dung )VALUES  ( @TenNhom)
END




GO
/****** Object:  StoredProcedure [dbo].[USP_DSXe]    Script Date: 06/12/2017 7:03:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--pro lay tao xe
Create proc [dbo].[USP_DSXe]
as select * from dbo.Xe



GO
/****** Object:  StoredProcedure [dbo].[USP_TenChoNgoi]    Script Date: 06/12/2017 7:03:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--pro ten cho ngoi
Create proc [dbo].[USP_TenChoNgoi]
@idChuyen nvarchar(100)
as
begin
	select TenChoNgoi from ChoNgoi where @idChuyen=IdChuyen
end






GO
/****** Object:  StoredProcedure [dbo].[USP_TenGhe]    Script Date: 06/12/2017 7:03:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--
create proc [dbo].[USP_TenGhe]
@idtuyen varchar(100)
as
Begin
select * from ChuyenXe,ChoNgoi 
where ChuyenXe.IdChuyen=ChoNgoi.IdChuyen and @idtuyen=ChuyenXe.IdTuyen
END



GO
/****** Object:  StoredProcedure [dbo].[USP_TenGhe3]    Script Date: 06/12/2017 7:03:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[USP_TenGhe3]
@idchuyen varchar(100)
as 
begin
select * from ChuyenXe,ChoNgoi where @idchuyen=ChoNgoi.IdChuyen and @idchuyen=ChuyenXe.IdChuyen
end



GO
/****** Object:  StoredProcedure [dbo].[XemNhomNguoiDung]    Script Date: 06/12/2017 7:03:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XemNhomNguoiDung]
AS
BEGIN
	SELECT * FROM dbo.NhomNguoiDung
END




GO
/****** Object:  StoredProcedure [dbo].[XoaNhomNguoiDung]    Script Date: 06/12/2017 7:03:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Xoa Nhom Nguoi Dung
CREATE PROC [dbo].[XoaNhomNguoiDung]
(
	@id_nhom_nguoi_dung INT
)
AS
BEGIN
	DELETE FROM dbo.NhomNguoiDung WHERE id_nhom_nguoi_dung=@id_nhom_nguoi_dung
END




GO
USE [master]
GO
ALTER DATABASE [QuanLyBenXe] SET  READ_WRITE 
GO
