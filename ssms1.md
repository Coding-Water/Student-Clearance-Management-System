USE [master]
GO
/****** Object:  Database [StudentClearanceDB]    Script Date: 5/27/2026 1:05:27 AM ******/
CREATE DATABASE [StudentClearanceDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StudentClearanceDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL17.MSSQLSERVER01\MSSQL\DATA\StudentClearanceDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'StudentClearanceDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL17.MSSQLSERVER01\MSSQL\DATA\StudentClearanceDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [StudentClearanceDB] SET COMPATIBILITY_LEVEL = 170
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StudentClearanceDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StudentClearanceDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StudentClearanceDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StudentClearanceDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StudentClearanceDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StudentClearanceDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [StudentClearanceDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [StudentClearanceDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StudentClearanceDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StudentClearanceDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StudentClearanceDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StudentClearanceDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StudentClearanceDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StudentClearanceDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StudentClearanceDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StudentClearanceDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [StudentClearanceDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StudentClearanceDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StudentClearanceDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StudentClearanceDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StudentClearanceDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StudentClearanceDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [StudentClearanceDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StudentClearanceDB] SET RECOVERY FULL 
GO
ALTER DATABASE [StudentClearanceDB] SET  MULTI_USER 
GO
ALTER DATABASE [StudentClearanceDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StudentClearanceDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StudentClearanceDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StudentClearanceDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [StudentClearanceDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [StudentClearanceDB] SET OPTIMIZED_LOCKING = OFF 
GO
ALTER DATABASE [StudentClearanceDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'StudentClearanceDB', N'ON'
GO
ALTER DATABASE [StudentClearanceDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [StudentClearanceDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [StudentClearanceDB]
GO
/****** Object:  Table [dbo].[AcademicTerms]    Script Date: 5/27/2026 1:05:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AcademicTerms](
	[TermID] [int] IDENTITY(1,1) NOT NULL,
	[SchoolYear] [varchar](20) NOT NULL,
	[Semester] [varchar](30) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TermID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClearanceRecords]    Script Date: 5/27/2026 1:05:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClearanceRecords](
	[ClearanceID] [int] IDENTITY(1,1) NOT NULL,
	[StudentID] [int] NOT NULL,
	[DepartmentID] [int] NOT NULL,
	[TermID] [int] NOT NULL,
	[Status] [varchar](20) NOT NULL,
	[Remarks] [varchar](100) NULL,
	[IsDeleted] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ClearanceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CourseDepartmentRequirements]    Script Date: 5/27/2026 1:05:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CourseDepartmentRequirements](
	[RequirementID] [int] IDENTITY(1,1) NOT NULL,
	[CourseID] [int] NOT NULL,
	[DepartmentID] [int] NOT NULL,
	[IsRequired] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RequirementID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Courses]    Script Date: 5/27/2026 1:05:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[CourseID] [int] IDENTITY(1,1) NOT NULL,
	[CourseCode] [varchar](20) NOT NULL,
	[CourseName] [varchar](100) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departments]    Script Date: 5/27/2026 1:05:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departments](
	[DepartmentID] [int] IDENTITY(1,1) NOT NULL,
	[DepartmentName] [varchar](100) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DepartmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RecycleBinLogs]    Script Date: 5/27/2026 1:05:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RecycleBinLogs](
	[LogID] [int] IDENTITY(1,1) NOT NULL,
	[RecordType] [varchar](50) NOT NULL,
	[RecordID] [varchar](50) NOT NULL,
	[RecordDetails] [varchar](255) NOT NULL,
	[ActionType] [varchar](20) NOT NULL,
	[ActionDate] [datetime] NOT NULL,
	[PerformedBy] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[LogID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 5/27/2026 1:05:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[StudentID] [int] NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[CourseID] [int] NOT NULL,
	[YearLevel] [varchar](20) NOT NULL,
	[Section] [varchar](20) NOT NULL,
	[ContactNumber] [varchar](15) NULL,
	[IsDeleted] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UpdateLogs]    Script Date: 5/27/2026 1:05:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UpdateLogs](
	[LogID] [int] IDENTITY(1,1) NOT NULL,
	[RecordType] [varchar](50) NOT NULL,
	[RecordID] [varchar](50) NOT NULL,
	[UpdateDetails] [nvarchar](max) NOT NULL,
	[PerformedBy] [varchar](50) NOT NULL,
	[UserRole] [varchar](20) NOT NULL,
	[ActionDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[LogID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 5/27/2026 1:05:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Role] [varchar](20) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UX_AcademicTerms_SchoolYear_Semester]    Script Date: 5/27/2026 1:05:27 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UX_AcademicTerms_SchoolYear_Semester] ON [dbo].[AcademicTerms]
(
	[SchoolYear] ASC,
	[Semester] ASC
)
WHERE ([IsDeleted]=(0))
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UX_ClearanceRecords_Student_Department_Term]    Script Date: 5/27/2026 1:05:27 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UX_ClearanceRecords_Student_Department_Term] ON [dbo].[ClearanceRecords]
(
	[StudentID] ASC,
	[DepartmentID] ASC,
	[TermID] ASC
)
WHERE ([IsDeleted]=(0))
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UX_CourseDepartmentRequirements_Course_Department]    Script Date: 5/27/2026 1:05:27 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UX_CourseDepartmentRequirements_Course_Department] ON [dbo].[CourseDepartmentRequirements]
(
	[CourseID] ASC,
	[DepartmentID] ASC
)
WHERE ([IsDeleted]=(0))
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UX_Courses_CourseCode]    Script Date: 5/27/2026 1:05:27 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UX_Courses_CourseCode] ON [dbo].[Courses]
(
	[CourseCode] ASC
)
WHERE ([IsDeleted]=(0))
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UX_Departments_DepartmentName]    Script Date: 5/27/2026 1:05:27 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UX_Departments_DepartmentName] ON [dbo].[Departments]
(
	[DepartmentName] ASC
)
WHERE ([IsDeleted]=(0))
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UX_Users_Username]    Script Date: 5/27/2026 1:05:27 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UX_Users_Username] ON [dbo].[Users]
(
	[Username] ASC
)
WHERE ([IsDeleted]=(0))
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AcademicTerms] ADD  DEFAULT ((0)) FOR [IsActive]
GO
ALTER TABLE [dbo].[AcademicTerms] ADD  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[ClearanceRecords] ADD  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[CourseDepartmentRequirements] ADD  DEFAULT ((1)) FOR [IsRequired]
GO
ALTER TABLE [dbo].[CourseDepartmentRequirements] ADD  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[Courses] ADD  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[Departments] ADD  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[RecycleBinLogs] ADD  DEFAULT (getdate()) FOR [ActionDate]
GO
ALTER TABLE [dbo].[Students] ADD  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[UpdateLogs] ADD  DEFAULT (getdate()) FOR [ActionDate]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[ClearanceRecords]  WITH CHECK ADD  CONSTRAINT [FK_ClearanceRecords_AcademicTerms] FOREIGN KEY([TermID])
REFERENCES [dbo].[AcademicTerms] ([TermID])
GO
ALTER TABLE [dbo].[ClearanceRecords] CHECK CONSTRAINT [FK_ClearanceRecords_AcademicTerms]
GO
ALTER TABLE [dbo].[ClearanceRecords]  WITH CHECK ADD  CONSTRAINT [FK_ClearanceRecords_Departments] FOREIGN KEY([DepartmentID])
REFERENCES [dbo].[Departments] ([DepartmentID])
GO
ALTER TABLE [dbo].[ClearanceRecords] CHECK CONSTRAINT [FK_ClearanceRecords_Departments]
GO
ALTER TABLE [dbo].[ClearanceRecords]  WITH CHECK ADD  CONSTRAINT [FK_ClearanceRecords_Students] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Students] ([StudentID])
GO
ALTER TABLE [dbo].[ClearanceRecords] CHECK CONSTRAINT [FK_ClearanceRecords_Students]
GO
ALTER TABLE [dbo].[CourseDepartmentRequirements]  WITH CHECK ADD  CONSTRAINT [FK_CourseDepartmentRequirements_Courses] FOREIGN KEY([CourseID])
REFERENCES [dbo].[Courses] ([CourseID])
GO
ALTER TABLE [dbo].[CourseDepartmentRequirements] CHECK CONSTRAINT [FK_CourseDepartmentRequirements_Courses]
GO
ALTER TABLE [dbo].[CourseDepartmentRequirements]  WITH CHECK ADD  CONSTRAINT [FK_CourseDepartmentRequirements_Departments] FOREIGN KEY([DepartmentID])
REFERENCES [dbo].[Departments] ([DepartmentID])
GO
ALTER TABLE [dbo].[CourseDepartmentRequirements] CHECK CONSTRAINT [FK_CourseDepartmentRequirements_Departments]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Courses] FOREIGN KEY([CourseID])
REFERENCES [dbo].[Courses] ([CourseID])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Courses]
GO
USE [master]
GO
ALTER DATABASE [StudentClearanceDB] SET  READ_WRITE 
GO
