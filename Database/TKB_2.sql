USE [master]
GO
/****** Object:  Database [TKB_v2]    Script Date: 5/31/2021 5:15:13 PM ******/
CREATE DATABASE [TKB_v2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TKB_v2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\TKB_v2.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TKB_v2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\TKB_v2_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TKB_v2] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TKB_v2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TKB_v2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TKB_v2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TKB_v2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TKB_v2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TKB_v2] SET ARITHABORT OFF 
GO
ALTER DATABASE [TKB_v2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TKB_v2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TKB_v2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TKB_v2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TKB_v2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TKB_v2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TKB_v2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TKB_v2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TKB_v2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TKB_v2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TKB_v2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TKB_v2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TKB_v2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TKB_v2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TKB_v2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TKB_v2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TKB_v2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TKB_v2] SET RECOVERY FULL 
GO
ALTER DATABASE [TKB_v2] SET  MULTI_USER 
GO
ALTER DATABASE [TKB_v2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TKB_v2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TKB_v2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TKB_v2] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [TKB_v2] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'TKB_v2', N'ON'
GO
USE [TKB_v2]
GO
/****** Object:  Table [dbo].[GiaoVien]    Script Date: 5/31/2021 5:15:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaoVien](
	[IDGV] [int] IDENTITY(1,1) NOT NULL,
	[IDMon] [int] NULL CONSTRAINT [DF_GiaoVien_IDMon]  DEFAULT ((0)),
	[ChuyenKhoi] [int] NULL CONSTRAINT [DF_GiaoVien_ChuyenKhoi]  DEFAULT ((6)),
	[TenGV] [nvarchar](100) NULL,
	[NamSinh] [date] NULL,
	[GioiTinh] [bit] NULL CONSTRAINT [DF_GiaoVien_GioiTinh]  DEFAULT ((0)),
	[SoTiet] [int] NULL CONSTRAINT [DF_GiaoVien_SoTiet]  DEFAULT ((0)),
	[SoDT] [nvarchar](20) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[Username] [nvarchar](100) NULL,
	[Password] [nvarchar](100) NULL,
 CONSTRAINT [PK_GiaoVien] PRIMARY KEY CLUSTERED 
(
	[IDGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LopHoc]    Script Date: 5/31/2021 5:15:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LopHoc](
	[IDLop] [int] IDENTITY(1,1) NOT NULL,
	[IDGV] [int] NULL CONSTRAINT [DF_LopHoc_IDGV]  DEFAULT ((0)),
	[IDPH] [int] NULL CONSTRAINT [DF_LopHoc_IDPH]  DEFAULT ((0)),
	[Nam] [int] NULL CONSTRAINT [DF_LopHoc_Nam]  DEFAULT ((0)),
	[Khoi] [int] NULL CONSTRAINT [DF_LopHoc_Khoi]  DEFAULT ((6)),
	[TenLop] [nvarchar](50) NULL,
	[SiSo] [int] NULL CONSTRAINT [DF_LopHoc_SiSo]  DEFAULT ((0)),
	[BuoiHoc] [int] NULL CONSTRAINT [DF_LopHoc_BuoiHoc]  DEFAULT ((1)),
 CONSTRAINT [PK_Lop] PRIMARY KEY CLUSTERED 
(
	[IDLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 5/31/2021 5:15:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[IDMon] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](100) NULL,
	[Khoi6] [bit] NULL CONSTRAINT [DF_MonHoc_Khoi6]  DEFAULT ((0)),
	[Khoi7] [bit] NULL CONSTRAINT [DF_MonHoc_Khoi7]  DEFAULT ((0)),
	[Khoi8] [bit] NULL CONSTRAINT [DF_MonHoc_Khoi8]  DEFAULT ((0)),
	[Khoi9] [bit] NULL CONSTRAINT [DF_MonHoc_Khoi9]  DEFAULT ((0)),
	[SoTietK6] [int] NULL CONSTRAINT [DF_MonHoc_SoTietK6]  DEFAULT ((0)),
	[SoBuoiK6] [int] NULL CONSTRAINT [DF_MonHoc_SoBuoiK6]  DEFAULT ((0)),
	[SoTietK7] [int] NULL CONSTRAINT [DF_MonHoc_SoTietK7]  DEFAULT ((0)),
	[SoBuoiK7] [int] NULL CONSTRAINT [DF_MonHoc_SoBuoiK7]  DEFAULT ((0)),
	[SoTietK8] [int] NULL CONSTRAINT [DF_MonHoc_SoTietK8]  DEFAULT ((0)),
	[SoBuoiK8] [int] NULL CONSTRAINT [DF_MonHoc_SoBuoiK8]  DEFAULT ((0)),
	[SoTietK9] [int] NULL CONSTRAINT [DF_MonHoc_SoTietK9]  DEFAULT ((0)),
	[SoBuoiK9] [int] NULL CONSTRAINT [DF_MonHoc_SoBuoiK9]  DEFAULT ((0)),
	[Kep] [bit] NULL CONSTRAINT [DF_MonHoc_Kep]  DEFAULT ((0)),
	[Phu] [bit] NULL CONSTRAINT [DF_MonHoc_Phu]  DEFAULT ((0)),
 CONSTRAINT [PK_MonHoc] PRIMARY KEY CLUSTERED 
(
	[IDMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[NguoiDung]    Script Date: 5/31/2021 5:15:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fullName] [nvarchar](50) NOT NULL,
	[userName] [nvarchar](50) NOT NULL,
	[passWord] [nvarchar](200) NOT NULL,
	[id_role] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NguoiDung] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhongHoc]    Script Date: 5/31/2021 5:15:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongHoc](
	[IDPH] [int] IDENTITY(1,1) NOT NULL,
	[TenPH] [nvarchar](50) NULL,
	[SucChua] [int] NULL CONSTRAINT [DF_PhongHoc_SucChua]  DEFAULT ((0)),
	[ViTri] [nvarchar](50) NULL,
 CONSTRAINT [PK_PhongHoc] PRIMARY KEY CLUSTERED 
(
	[IDPH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Quyen]    Script Date: 5/31/2021 5:15:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Quyen](
	[id_role] [nvarchar](50) NOT NULL,
	[TenQuyen] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Quyen] PRIMARY KEY CLUSTERED 
(
	[id_role] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThoiKhoaBieu]    Script Date: 5/31/2021 5:15:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThoiKhoaBieu](
	[IDTKB] [int] IDENTITY(1,1) NOT NULL,
	[IDGV] [int] NULL,
	[IDLop] [int] NULL,
	[IDMon] [int] NULL,
	[Thu] [int] NULL,
	[Tiet] [int] NULL,
 CONSTRAINT [PK_ThoiKhoaBieu] PRIMARY KEY CLUSTERED 
(
	[IDTKB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vGiaoVien]
AS
SELECT        dbo.GiaoVien.IDGV, dbo.GiaoVien.TenGV, dbo.GiaoVien.IDMon, dbo.MonHoc.Ten AS TenMon, dbo.GiaoVien.ChuyenKhoi, dbo.GiaoVien.SoTiet, 
                         dbo.GiaoVien.NamSinh, dbo.GiaoVien.GioiTinh, dbo.GiaoVien.SoDT, dbo.GiaoVien.DiaChi
FROM            dbo.GiaoVien LEFT OUTER JOIN
                         dbo.MonHoc ON dbo.GiaoVien.IDMon = dbo.MonHoc.IDMon

GO
/****** Object:  View [dbo].[vLopHoc]    Script Date: 5/31/2021 4:28:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vLopHoc]
AS
SELECT        TOP (100) PERCENT dbo.LopHoc.IDLop, dbo.LopHoc.IDGV, dbo.LopHoc.IDPH, dbo.LopHoc.Nam, dbo.LopHoc.Khoi, dbo.LopHoc.TenLop, dbo.LopHoc.SiSo, 
                         dbo.LopHoc.BuoiHoc, dbo.GiaoVien.TenGV, dbo.PhongHoc.TenPH, dbo.PhongHoc.ViTri
FROM            dbo.LopHoc LEFT OUTER JOIN
                         dbo.PhongHoc ON dbo.LopHoc.IDPH = dbo.PhongHoc.IDPH LEFT OUTER JOIN
                         dbo.GiaoVien ON dbo.LopHoc.IDGV = dbo.GiaoVien.IDGV

GO
ALTER TABLE [dbo].[GiaoVien]  WITH CHECK ADD  CONSTRAINT [FK_GiaoVien_MonHoc] FOREIGN KEY([IDMon])
REFERENCES [dbo].[MonHoc] ([IDMon])
GO
ALTER TABLE [dbo].[GiaoVien] CHECK CONSTRAINT [FK_GiaoVien_MonHoc]
GO
ALTER TABLE [dbo].[LopHoc]  WITH CHECK ADD  CONSTRAINT [FK_LopHoc_GiaoVien] FOREIGN KEY([IDGV])
REFERENCES [dbo].[GiaoVien] ([IDGV])
GO
ALTER TABLE [dbo].[LopHoc] CHECK CONSTRAINT [FK_LopHoc_GiaoVien]
GO
ALTER TABLE [dbo].[LopHoc]  WITH CHECK ADD  CONSTRAINT [FK_LopHoc_PhongHoc] FOREIGN KEY([IDPH])
REFERENCES [dbo].[PhongHoc] ([IDPH])
GO
ALTER TABLE [dbo].[LopHoc] CHECK CONSTRAINT [FK_LopHoc_PhongHoc]
GO
ALTER TABLE [dbo].[NguoiDung]  WITH CHECK ADD  CONSTRAINT [FK_NguoiDung_Quyen] FOREIGN KEY([id_role])
REFERENCES [dbo].[Quyen] ([id_role])
GO
ALTER TABLE [dbo].[NguoiDung] CHECK CONSTRAINT [FK_NguoiDung_Quyen]
GO
ALTER TABLE [dbo].[ThoiKhoaBieu]  WITH CHECK ADD  CONSTRAINT [FK_ThoiKhoaBieu_GiaoVien] FOREIGN KEY([IDGV])
REFERENCES [dbo].[GiaoVien] ([IDGV])
GO
ALTER TABLE [dbo].[ThoiKhoaBieu] CHECK CONSTRAINT [FK_ThoiKhoaBieu_GiaoVien]
GO
ALTER TABLE [dbo].[ThoiKhoaBieu]  WITH CHECK ADD  CONSTRAINT [FK_ThoiKhoaBieu_LopHoc] FOREIGN KEY([IDLop])
REFERENCES [dbo].[LopHoc] ([IDLop])
GO
ALTER TABLE [dbo].[ThoiKhoaBieu] CHECK CONSTRAINT [FK_ThoiKhoaBieu_LopHoc]
GO
ALTER TABLE [dbo].[ThoiKhoaBieu]  WITH CHECK ADD  CONSTRAINT [FK_ThoiKhoaBieu_MonHoc] FOREIGN KEY([IDMon])
REFERENCES [dbo].[MonHoc] ([IDMon])
GO
ALTER TABLE [dbo].[ThoiKhoaBieu] CHECK CONSTRAINT [FK_ThoiKhoaBieu_MonHoc]
GO
/****** Object:  StoredProcedure [dbo].[loginGV]    Script Date: 5/31/2021 4:28:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[loginGV]
    @Username nvarchar(50), 
    @Password nvarchar(50) 
AS
    SET NOCOUNT ON;
    SELECT IDGV, IDMon, TenGV, NamSinh, GioiTinh, Username, [Password]
    FROM GiaoVien
    WHERE Username = @Username AND [Password] = @Password;

GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[20] 4[44] 2[14] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "GiaoVien"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 268
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "MonHoc"
            Begin Extent = 
               Top = 12
               Left = 379
               Bottom = 141
               Right = 549
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vGiaoVien'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vGiaoVien'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[21] 2[14] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "LopHoc"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 172
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "GiaoVien"
            Begin Extent = 
               Top = 18
               Left = 347
               Bottom = 164
               Right = 517
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "PhongHoc"
            Begin Extent = 
               Top = 46
               Left = 590
               Bottom = 176
               Right = 760
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 10
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vLopHoc'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vLopHoc'
GO
GO
ALTER DATABASE [TKB_v2] SET  READ_WRITE 
GO
