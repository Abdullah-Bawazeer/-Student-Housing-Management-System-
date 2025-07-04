USE [master]
GO
/****** Object:  Database [StudentManagmentDatabase]    Script Date: 24/06/2025 04:31:17 م ******/
CREATE DATABASE [StudentManagmentDatabase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StudentManagmentDatabase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\StudentManagmentDatabase.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'StudentManagmentDatabase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\StudentManagmentDatabase_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [StudentManagmentDatabase] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StudentManagmentDatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StudentManagmentDatabase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StudentManagmentDatabase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StudentManagmentDatabase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StudentManagmentDatabase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StudentManagmentDatabase] SET ARITHABORT OFF 
GO
ALTER DATABASE [StudentManagmentDatabase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [StudentManagmentDatabase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StudentManagmentDatabase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StudentManagmentDatabase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StudentManagmentDatabase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StudentManagmentDatabase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StudentManagmentDatabase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StudentManagmentDatabase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StudentManagmentDatabase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StudentManagmentDatabase] SET  DISABLE_BROKER 
GO
ALTER DATABASE [StudentManagmentDatabase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StudentManagmentDatabase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StudentManagmentDatabase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StudentManagmentDatabase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StudentManagmentDatabase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StudentManagmentDatabase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [StudentManagmentDatabase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StudentManagmentDatabase] SET RECOVERY FULL 
GO
ALTER DATABASE [StudentManagmentDatabase] SET  MULTI_USER 
GO
ALTER DATABASE [StudentManagmentDatabase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StudentManagmentDatabase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StudentManagmentDatabase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StudentManagmentDatabase] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [StudentManagmentDatabase] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [StudentManagmentDatabase] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'StudentManagmentDatabase', N'ON'
GO
ALTER DATABASE [StudentManagmentDatabase] SET QUERY_STORE = ON
GO
ALTER DATABASE [StudentManagmentDatabase] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [StudentManagmentDatabase]
GO
/****** Object:  Table [dbo].[Expenses]    Script Date: 24/06/2025 04:31:18 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Expenses](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ItemName] [varchar](50) NOT NULL,
	[Price] [decimal](18, 0) NOT NULL,
	[Amount] [int] NOT NULL,
	[TotalPrice] [decimal](18, 0) NOT NULL,
	[BuyerName] [nvarchar](50) NOT NULL,
	[BuyDate] [datetime] NULL,
 CONSTRAINT [PK_Expenses] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Levels]    Script Date: 24/06/2025 04:31:18 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Levels](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Level] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Majors]    Script Date: 24/06/2025 04:31:18 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Majors](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Major] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payments]    Script Date: 24/06/2025 04:31:18 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payments](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StudentID] [int] NULL,
	[FoodPrice] [decimal](18, 0) NULL,
	[PlacePrice] [decimal](18, 0) NULL,
	[TotalPayment] [decimal](18, 0) NULL,
	[Date] [date] NULL,
 CONSTRAINT [PK_Payments] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Periods]    Script Date: 24/06/2025 04:31:18 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Periods](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Period] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Statistic]    Script Date: 24/06/2025 04:31:18 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Statistic](
	[Name] [nvarchar](max) NULL,
	[Percentage] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 24/06/2025 04:31:18 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Phone] [varchar](30) NULL,
	[WhatsappPhone] [varchar](30) NULL,
	[DateOfBirth] [datetime] NULL,
	[Stutus] [bit] NULL,
	[EntryDate] [datetime] NULL,
	[FatherName] [nvarchar](100) NULL,
	[IdentityPicture] [varchar](50) NULL,
	[TheArea] [nvarchar](50) NULL,
	[PersonalPhoto] [varchar](100) NULL,
	[FatherPhone] [varchar](30) NULL,
	[ProofPhoto] [varchar](100) NULL,
	[FormImage] [varchar](100) NULL,
	[LevelID] [int] NULL,
	[MajorID] [int] NULL,
	[WingsID] [int] NULL,
	[PeriodID] [int] NULL,
	[UniverstyID] [int] NULL,
	[PlaceLiving] [nvarchar](50) NULL,
 CONSTRAINT [PK__Students__3214EC27E5C61F00] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Universtys]    Script Date: 24/06/2025 04:31:18 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Universtys](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Universty] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 24/06/2025 04:31:18 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](30) NOT NULL,
	[Password] [varchar](20) NOT NULL,
	[Permmions] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Violations]    Script Date: 24/06/2025 04:31:18 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Violations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Evaluations] [int] NULL,
 CONSTRAINT [PK_Violations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ViolationsDetails]    Script Date: 24/06/2025 04:31:18 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ViolationsDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StudentID] [int] NOT NULL,
	[ViolationID] [int] NOT NULL,
	[ViolationDate] [date] NULL,
	[ViolationDescription] [nvarchar](max) NULL,
 CONSTRAINT [PK_ViolationsDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Wings]    Script Date: 24/06/2025 04:31:18 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Wings](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[RoomsCoun] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Expenses] ON 

INSERT [dbo].[Expenses] ([ID], [ItemName], [Price], [Amount], [TotalPrice], [BuyerName], [BuyDate]) VALUES (2, N'فاصوليا', CAST(1000 AS Decimal(18, 0)), 3, CAST(3000 AS Decimal(18, 0)), N'عبدالله باوزير', NULL)
INSERT [dbo].[Expenses] ([ID], [ItemName], [Price], [Amount], [TotalPrice], [BuyerName], [BuyDate]) VALUES (3, N'بازاليا', CAST(500 AS Decimal(18, 0)), 10, CAST(5000 AS Decimal(18, 0)), N'يحيى حوري', NULL)
INSERT [dbo].[Expenses] ([ID], [ItemName], [Price], [Amount], [TotalPrice], [BuyerName], [BuyDate]) VALUES (5, N'hi', CAST(200 AS Decimal(18, 0)), 3, CAST(2000 AS Decimal(18, 0)), N'adadkajakda', CAST(N'2025-03-01T14:21:16.437' AS DateTime))
INSERT [dbo].[Expenses] ([ID], [ItemName], [Price], [Amount], [TotalPrice], [BuyerName], [BuyDate]) VALUES (6, N'حليب', CAST(1000 AS Decimal(18, 0)), 2, CAST(2000 AS Decimal(18, 0)), N'عبدالله باوزبر', CAST(N'2025-02-28T17:10:57.277' AS DateTime))
INSERT [dbo].[Expenses] ([ID], [ItemName], [Price], [Amount], [TotalPrice], [BuyerName], [BuyDate]) VALUES (7, N'رز', CAST(900 AS Decimal(18, 0)), 4, CAST(3600 AS Decimal(18, 0)), N'همام', CAST(N'2025-02-28T17:10:57.000' AS DateTime))
INSERT [dbo].[Expenses] ([ID], [ItemName], [Price], [Amount], [TotalPrice], [BuyerName], [BuyDate]) VALUES (8, N'asa', CAST(100 AS Decimal(18, 0)), 7, CAST(700 AS Decimal(18, 0)), N'hgjgh', CAST(N'2025-02-28T17:10:57.277' AS DateTime))
INSERT [dbo].[Expenses] ([ID], [ItemName], [Price], [Amount], [TotalPrice], [BuyerName], [BuyDate]) VALUES (9, N'تونه', CAST(1000 AS Decimal(18, 0)), 6, CAST(6000 AS Decimal(18, 0)), N'بولعبد', CAST(N'2025-02-28T17:10:57.277' AS DateTime))
SET IDENTITY_INSERT [dbo].[Expenses] OFF
GO
SET IDENTITY_INSERT [dbo].[Levels] ON 

INSERT [dbo].[Levels] ([ID], [Level]) VALUES (1, N'الاول')
INSERT [dbo].[Levels] ([ID], [Level]) VALUES (2, N'الثاني')
INSERT [dbo].[Levels] ([ID], [Level]) VALUES (3, N'الثالث')
INSERT [dbo].[Levels] ([ID], [Level]) VALUES (4, N'الرابع')
INSERT [dbo].[Levels] ([ID], [Level]) VALUES (5, N'الخامس')
INSERT [dbo].[Levels] ([ID], [Level]) VALUES (6, N'السادس')
SET IDENTITY_INSERT [dbo].[Levels] OFF
GO
SET IDENTITY_INSERT [dbo].[Majors] ON 

INSERT [dbo].[Majors] ([ID], [Major]) VALUES (1, N'محاسبة')
INSERT [dbo].[Majors] ([ID], [Major]) VALUES (2, N'ادارة اعمال')
INSERT [dbo].[Majors] ([ID], [Major]) VALUES (3, N'تقنية معلومات')
INSERT [dbo].[Majors] ([ID], [Major]) VALUES (4, N'طب بشري')
INSERT [dbo].[Majors] ([ID], [Major]) VALUES (5, N'قانون')
INSERT [dbo].[Majors] ([ID], [Major]) VALUES (6, N'هندسة مدنية')
INSERT [dbo].[Majors] ([ID], [Major]) VALUES (7, N'هندسة معمارية')
INSERT [dbo].[Majors] ([ID], [Major]) VALUES (8, N'تمريض')
SET IDENTITY_INSERT [dbo].[Majors] OFF
GO
SET IDENTITY_INSERT [dbo].[Payments] ON 

INSERT [dbo].[Payments] ([ID], [StudentID], [FoodPrice], [PlacePrice], [TotalPayment], [Date]) VALUES (1, 2012, CAST(20000 AS Decimal(18, 0)), CAST(30000 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(N'2025-02-28' AS Date))
INSERT [dbo].[Payments] ([ID], [StudentID], [FoodPrice], [PlacePrice], [TotalPayment], [Date]) VALUES (2, 4, CAST(20000 AS Decimal(18, 0)), CAST(10000 AS Decimal(18, 0)), CAST(30000 AS Decimal(18, 0)), CAST(N'2025-01-01' AS Date))
INSERT [dbo].[Payments] ([ID], [StudentID], [FoodPrice], [PlacePrice], [TotalPayment], [Date]) VALUES (3, 2014, CAST(20000 AS Decimal(18, 0)), CAST(10000 AS Decimal(18, 0)), CAST(30000 AS Decimal(18, 0)), CAST(N'2025-02-28' AS Date))
INSERT [dbo].[Payments] ([ID], [StudentID], [FoodPrice], [PlacePrice], [TotalPayment], [Date]) VALUES (4, 2015, CAST(20000 AS Decimal(18, 0)), CAST(10000 AS Decimal(18, 0)), CAST(30000 AS Decimal(18, 0)), CAST(N'2025-01-09' AS Date))
INSERT [dbo].[Payments] ([ID], [StudentID], [FoodPrice], [PlacePrice], [TotalPayment], [Date]) VALUES (5, 2011, CAST(20000 AS Decimal(18, 0)), CAST(10000 AS Decimal(18, 0)), CAST(20000 AS Decimal(18, 0)), CAST(N'2025-05-30' AS Date))
SET IDENTITY_INSERT [dbo].[Payments] OFF
GO
SET IDENTITY_INSERT [dbo].[Periods] ON 

INSERT [dbo].[Periods] ([ID], [Period]) VALUES (1, N'صباحي')
INSERT [dbo].[Periods] ([ID], [Period]) VALUES (2, N'موازي')
SET IDENTITY_INSERT [dbo].[Periods] OFF
GO
INSERT [dbo].[Statistic] ([Name], [Percentage]) VALUES (N'مخالفة الصلاة', 50)
INSERT [dbo].[Statistic] ([Name], [Percentage]) VALUES (N'مخالفة السلوك', 30)
INSERT [dbo].[Statistic] ([Name], [Percentage]) VALUES (N'مخالفة النظافة', 10)
INSERT [dbo].[Statistic] ([Name], [Percentage]) VALUES (N'مخالفة  حلقات الفجر', NULL)
INSERT [dbo].[Statistic] ([Name], [Percentage]) VALUES (N'مخالفة الانشطة', NULL)
GO
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([ID], [Name], [Phone], [WhatsappPhone], [DateOfBirth], [Stutus], [EntryDate], [FatherName], [IdentityPicture], [TheArea], [PersonalPhoto], [FatherPhone], [ProofPhoto], [FormImage], [LevelID], [MajorID], [WingsID], [PeriodID], [UniverstyID], [PlaceLiving]) VALUES (3, N'عبدالله باوزبر', N'712433749', N'777777777777', CAST(N'2000-01-02T00:00:00.000' AS DateTime), 0, CAST(N'2000-02-02T00:00:00.000' AS DateTime), N'علي باوزير', N'D:\New Computer\Resources\20241123_160348.png', NULL, N'D:\New Computer\Resources\IMG-20241112-WA0077.jpg', N'99999999', N'D:\New Computer\Resources\20241123_160938.png', N'D:\New Computer\Resources\20241112_095930.png', 1, 2, NULL, 2, 3, N'اليمن')
INSERT [dbo].[Students] ([ID], [Name], [Phone], [WhatsappPhone], [DateOfBirth], [Stutus], [EntryDate], [FatherName], [IdentityPicture], [TheArea], [PersonalPhoto], [FatherPhone], [ProofPhoto], [FormImage], [LevelID], [MajorID], [WingsID], [PeriodID], [UniverstyID], [PlaceLiving]) VALUES (4, N'اسامة باجاة', N'16628882', N'11111111111', CAST(N'1888-02-01T00:00:00.000' AS DateTime), 1, CAST(N'2999-02-02T00:00:00.000' AS DateTime), N'عمر باجاة', NULL, NULL, NULL, N'98766777', NULL, NULL, 2, 1, NULL, 1, 2, N'دوعن')
INSERT [dbo].[Students] ([ID], [Name], [Phone], [WhatsappPhone], [DateOfBirth], [Stutus], [EntryDate], [FatherName], [IdentityPicture], [TheArea], [PersonalPhoto], [FatherPhone], [ProofPhoto], [FormImage], [LevelID], [MajorID], [WingsID], [PeriodID], [UniverstyID], [PlaceLiving]) VALUES (1008, N'احمد فكري', N'33333', N'12121', CAST(N'2025-01-21T12:06:01.597' AS DateTime), 1, NULL, N'فكري', N'', NULL, N'', N'12213', N'', N'', 5, 3, NULL, 1, 5, N'اليمن')
INSERT [dbo].[Students] ([ID], [Name], [Phone], [WhatsappPhone], [DateOfBirth], [Stutus], [EntryDate], [FatherName], [IdentityPicture], [TheArea], [PersonalPhoto], [FatherPhone], [ProofPhoto], [FormImage], [LevelID], [MajorID], [WingsID], [PeriodID], [UniverstyID], [PlaceLiving]) VALUES (2009, N'ahmed bin darany', N'2222222', N'456456456', CAST(N'2025-01-21T12:06:01.597' AS DateTime), 1, NULL, N'ali bin darany', N'', NULL, N'', N'666666666666', N'', N'', 3, 4, NULL, 1, 4, N'mashaeer')
INSERT [dbo].[Students] ([ID], [Name], [Phone], [WhatsappPhone], [DateOfBirth], [Stutus], [EntryDate], [FatherName], [IdentityPicture], [TheArea], [PersonalPhoto], [FatherPhone], [ProofPhoto], [FormImage], [LevelID], [MajorID], [WingsID], [PeriodID], [UniverstyID], [PlaceLiving]) VALUES (2010, N'اسامة عمر باجاة', N'712433749', N'712433749', CAST(N'2025-01-21T12:06:01.597' AS DateTime), 1, NULL, N'عمر باجاة', N'D:\Abdullah Bawazeer PC\picture2\Boy.png', NULL, N'D:\Abdullah Bawazeer PC\picture2\Boy.png', N'712433749', N'D:\Abdullah Bawazeer PC\picture2\Boy.png', N'D:\Abdullah Bawazeer PC\picture2\Boy.png', 3, 3, NULL, 1, 1, N'الرشيد')
INSERT [dbo].[Students] ([ID], [Name], [Phone], [WhatsappPhone], [DateOfBirth], [Stutus], [EntryDate], [FatherName], [IdentityPicture], [TheArea], [PersonalPhoto], [FatherPhone], [ProofPhoto], [FormImage], [LevelID], [MajorID], [WingsID], [PeriodID], [UniverstyID], [PlaceLiving]) VALUES (2011, N'سعيد باوزير', N'712433749', N'712433749', CAST(N'2025-01-21T12:06:01.597' AS DateTime), 0, NULL, N'علي باوزير', N'', NULL, N'', N'712433749', N'', N'', 3, 4, NULL, 1, 5, N'السفيل')
INSERT [dbo].[Students] ([ID], [Name], [Phone], [WhatsappPhone], [DateOfBirth], [Stutus], [EntryDate], [FatherName], [IdentityPicture], [TheArea], [PersonalPhoto], [FatherPhone], [ProofPhoto], [FormImage], [LevelID], [MajorID], [WingsID], [PeriodID], [UniverstyID], [PlaceLiving]) VALUES (2012, N'سالم عبدالله دومان', N'712345775', N'783532421313', CAST(N'2025-01-21T12:06:01.597' AS DateTime), 1, NULL, N'عبدااله دومان', N'', NULL, N'', N'7777777777777', N'', N'', 4, 6, NULL, 1, 4, N'دوعن')
INSERT [dbo].[Students] ([ID], [Name], [Phone], [WhatsappPhone], [DateOfBirth], [Stutus], [EntryDate], [FatherName], [IdentityPicture], [TheArea], [PersonalPhoto], [FatherPhone], [ProofPhoto], [FormImage], [LevelID], [MajorID], [WingsID], [PeriodID], [UniverstyID], [PlaceLiving]) VALUES (2013, N'اسامة باجاة', N'121212121', N'2121212121212', CAST(N'2025-01-21T12:06:01.597' AS DateTime), 1, NULL, N'عمر باجاة', N'', NULL, N'', N'1211213131', N'', N'', 1, 3, NULL, 1, 4, N'دوعن')
INSERT [dbo].[Students] ([ID], [Name], [Phone], [WhatsappPhone], [DateOfBirth], [Stutus], [EntryDate], [FatherName], [IdentityPicture], [TheArea], [PersonalPhoto], [FatherPhone], [ProofPhoto], [FormImage], [LevelID], [MajorID], [WingsID], [PeriodID], [UniverstyID], [PlaceLiving]) VALUES (2014, N'عبدالله', N'714422488', N'730114850', CAST(N'2025-01-21T12:06:01.000' AS DateTime), 1, NULL, N'سالم', N'', NULL, N'', N'730114850', N'', N'', 1, 2, NULL, 1, 4, N'السفيل')
INSERT [dbo].[Students] ([ID], [Name], [Phone], [WhatsappPhone], [DateOfBirth], [Stutus], [EntryDate], [FatherName], [IdentityPicture], [TheArea], [PersonalPhoto], [FatherPhone], [ProofPhoto], [FormImage], [LevelID], [MajorID], [WingsID], [PeriodID], [UniverstyID], [PlaceLiving]) VALUES (2015, N'صالح باعباد', N'7123456622', N'5123123131313', CAST(N'2025-01-21T12:06:01.597' AS DateTime), 0, NULL, N'عمر باعباد', N'D:\New Computer\Resources\1726227263840.jpg', NULL, N'D:\New Computer\Resources\1726227263840.jpg', N'555555555', N'D:\New Computer\Resources\1726227263840.jpg', N'D:\New Computer\Resources\1726227263840.jpg', 2, 7, NULL, 1, 1, N'قصيعر')
INSERT [dbo].[Students] ([ID], [Name], [Phone], [WhatsappPhone], [DateOfBirth], [Stutus], [EntryDate], [FatherName], [IdentityPicture], [TheArea], [PersonalPhoto], [FatherPhone], [ProofPhoto], [FormImage], [LevelID], [MajorID], [WingsID], [PeriodID], [UniverstyID], [PlaceLiving]) VALUES (2016, N'عمار محمد باوزير', N'712433749', N'712433749', CAST(N'2025-01-21T12:06:01.597' AS DateTime), 1, NULL, N'محمد سالم باوزير', N'D:\New Computer\Resources\IMG_20241123_165255.jpg', NULL, N'D:\New Computer\Resources\IMG-20241112-WA0077.jpg', N'712433749', N'D:\New Computer\Resources\IMG_20241123_165255.jpg', N'D:\New Computer\Resources\IMG_20241123_165255.jpg', 4, 2, NULL, 1, 4, N'وادي العين')
INSERT [dbo].[Students] ([ID], [Name], [Phone], [WhatsappPhone], [DateOfBirth], [Stutus], [EntryDate], [FatherName], [IdentityPicture], [TheArea], [PersonalPhoto], [FatherPhone], [ProofPhoto], [FormImage], [LevelID], [MajorID], [WingsID], [PeriodID], [UniverstyID], [PlaceLiving]) VALUES (2017, N'محمد باعمروش', N'3435452', N'717217371', CAST(N'2025-01-21T12:06:01.597' AS DateTime), 1, NULL, N'علي باعمروش', N'D:\New Computer\Resources\ByAmroosh.jpg', NULL, N'D:\New Computer\Resources\ByAmroosh.jpg', N'71213242', N'D:\New Computer\Resources\ByAmroosh.jpg', N'D:\New Computer\Resources\ByAmroosh.jpg', 5, 5, NULL, 1, 3, N'دوعن')
SET IDENTITY_INSERT [dbo].[Students] OFF
GO
SET IDENTITY_INSERT [dbo].[Universtys] ON 

INSERT [dbo].[Universtys] ([ID], [Universty]) VALUES (1, N'حضرموت')
INSERT [dbo].[Universtys] ([ID], [Universty]) VALUES (2, N'العرب')
INSERT [dbo].[Universtys] ([ID], [Universty]) VALUES (3, N'الريان')
INSERT [dbo].[Universtys] ([ID], [Universty]) VALUES (4, N'العلوم والتكنلوجيا')
INSERT [dbo].[Universtys] ([ID], [Universty]) VALUES (5, N'الاحقاف')
SET IDENTITY_INSERT [dbo].[Universtys] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([ID], [UserName], [Password], [Permmions]) VALUES (1, N'', N'', 31)
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Permmions]) VALUES (2, N'Admin', N'12345', 31)
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Permmions]) VALUES (7, N'عبدالله', N'1231230', 13)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET IDENTITY_INSERT [dbo].[Violations] ON 

INSERT [dbo].[Violations] ([Id], [Name], [Evaluations]) VALUES (1, N'مخالفة الصلاة', 20)
INSERT [dbo].[Violations] ([Id], [Name], [Evaluations]) VALUES (2, N'مخالفة حلقات الفجر', 20)
INSERT [dbo].[Violations] ([Id], [Name], [Evaluations]) VALUES (3, N'مخالفة الانشطة', 10)
INSERT [dbo].[Violations] ([Id], [Name], [Evaluations]) VALUES (4, N'مخالفة السلوك', 20)
INSERT [dbo].[Violations] ([Id], [Name], [Evaluations]) VALUES (5, N'مخالفة النظافة', 20)
INSERT [dbo].[Violations] ([Id], [Name], [Evaluations]) VALUES (6, N'مخالفة حلقات الاسبوع', 10)
SET IDENTITY_INSERT [dbo].[Violations] OFF
GO
SET IDENTITY_INSERT [dbo].[ViolationsDetails] ON 

INSERT [dbo].[ViolationsDetails] ([Id], [StudentID], [ViolationID], [ViolationDate], [ViolationDescription]) VALUES (1, 3, 1, CAST(N'2002-01-01' AS Date), N'تخلف عن صلاة الفجر بسبب النوم')
INSERT [dbo].[ViolationsDetails] ([Id], [StudentID], [ViolationID], [ViolationDate], [ViolationDescription]) VALUES (2, 3, 1, CAST(N'2000-03-03' AS Date), N'تحلف عن صلاة الفجر بسبب النوم')
INSERT [dbo].[ViolationsDetails] ([Id], [StudentID], [ViolationID], [ViolationDate], [ViolationDescription]) VALUES (3, 3, 2, CAST(N'2222-04-02' AS Date), N'تخلف عن حلقات الفجر')
INSERT [dbo].[ViolationsDetails] ([Id], [StudentID], [ViolationID], [ViolationDate], [ViolationDescription]) VALUES (4, 4, 1, CAST(N'4000-02-02' AS Date), N'تخلف عن صلاة الفجر سبب النوم')
INSERT [dbo].[ViolationsDetails] ([Id], [StudentID], [ViolationID], [ViolationDate], [ViolationDescription]) VALUES (5, 4, 3, CAST(N'2014-01-02' AS Date), N'تخلف عن النظافة بدون عذر')
INSERT [dbo].[ViolationsDetails] ([Id], [StudentID], [ViolationID], [ViolationDate], [ViolationDescription]) VALUES (6, 1008, 1, CAST(N'2025-02-28' AS Date), N'تخبف عن صلاة الفجر سبب النوم')
INSERT [dbo].[ViolationsDetails] ([Id], [StudentID], [ViolationID], [ViolationDate], [ViolationDescription]) VALUES (7, 2011, 2, CAST(N'2025-02-28' AS Date), N'تخلف بسبب النوم')
SET IDENTITY_INSERT [dbo].[ViolationsDetails] OFF
GO
ALTER TABLE [dbo].[Payments]  WITH CHECK ADD  CONSTRAINT [FK_Payments_Students] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Students] ([ID])
GO
ALTER TABLE [dbo].[Payments] CHECK CONSTRAINT [FK_Payments_Students]
GO
ALTER TABLE [dbo].[ViolationsDetails]  WITH CHECK ADD  CONSTRAINT [FK_ViolationsDetails_Students] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Students] ([ID])
GO
ALTER TABLE [dbo].[ViolationsDetails] CHECK CONSTRAINT [FK_ViolationsDetails_Students]
GO
ALTER TABLE [dbo].[ViolationsDetails]  WITH CHECK ADD  CONSTRAINT [FK_ViolationsDetails_Violations] FOREIGN KEY([ViolationID])
REFERENCES [dbo].[Violations] ([Id])
GO
ALTER TABLE [dbo].[ViolationsDetails] CHECK CONSTRAINT [FK_ViolationsDetails_Violations]
GO
USE [master]
GO
ALTER DATABASE [StudentManagmentDatabase] SET  READ_WRITE 
GO
