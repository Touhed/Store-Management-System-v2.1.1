USE [master]
GO
/****** Object:  Database [Store_Management_System]    Script Date: 10/7/2019 11:33:20 AM ******/
CREATE DATABASE [Store_Management_System]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Store_Management_System', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Store_Management_System.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Store_Management_System_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Store_Management_System_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Store_Management_System] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Store_Management_System].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Store_Management_System] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Store_Management_System] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Store_Management_System] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Store_Management_System] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Store_Management_System] SET ARITHABORT OFF 
GO
ALTER DATABASE [Store_Management_System] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Store_Management_System] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Store_Management_System] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Store_Management_System] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Store_Management_System] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Store_Management_System] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Store_Management_System] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Store_Management_System] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Store_Management_System] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Store_Management_System] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Store_Management_System] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Store_Management_System] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Store_Management_System] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Store_Management_System] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Store_Management_System] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Store_Management_System] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Store_Management_System] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Store_Management_System] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Store_Management_System] SET RECOVERY FULL 
GO
ALTER DATABASE [Store_Management_System] SET  MULTI_USER 
GO
ALTER DATABASE [Store_Management_System] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Store_Management_System] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Store_Management_System] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Store_Management_System] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
USE [Store_Management_System]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 10/7/2019 11:33:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[SN] [bigint] IDENTITY(1,1) NOT NULL,
	[AdminId] [bigint] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Contact] [nvarchar](50) NULL,
	[Photo] [nvarchar](50) NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[AdminId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Customer]    Script Date: 10/7/2019 11:33:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[Customer_Id] [bigint] NOT NULL,
	[Customer_Name] [nvarchar](50) NOT NULL,
	[Customer_Address] [nvarchar](50) NULL,
	[Customer_Contact] [nvarchar](50) NULL,
	[Customer_Email] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[Customer_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Employee]    Script Date: 10/7/2019 11:33:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[Employee_Id] [bigint] NOT NULL,
	[Employee_Name] [nvarchar](50) NOT NULL,
	[Employee_Address] [nvarchar](50) NULL,
	[Employee_Contact] [nvarchar](50) NULL,
	[Employee_Email] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[Employee_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Payment]    Script Date: 10/7/2019 11:33:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payment](
	[Payment_Id] [bigint] NOT NULL,
	[Date] [date] NULL,
	[Payment_Type] [nvarchar](50) NULL,
	[No_Of_Items] [nvarchar](50) NULL,
	[Percentage_Of_Vat] [nvarchar](50) NULL,
	[Amount_Of_Vat] [nvarchar](50) NULL,
	[Total_Cost] [nvarchar](50) NULL,
	[P_Id] [bigint] NOT NULL,
	[E_Id] [bigint] NOT NULL,
	[C_Id] [bigint] NOT NULL,
 CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED 
(
	[Payment_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Product]    Script Date: 10/7/2019 11:33:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Product_Id] [bigint] NOT NULL,
	[Product_Name] [nvarchar](50) NOT NULL,
	[Brand_Name] [nvarchar](50) NULL,
	[Product_Quantity] [nvarchar](50) NOT NULL,
	[Product_Price] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Product_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserRole]    Script Date: 10/7/2019 11:33:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRole](
	[UserId] [bigint] IDENTITY(1,1) NOT NULL,
	[UserType] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_UserRole] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 10/7/2019 11:33:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[LoginId] [bigint] IDENTITY(1,1) NOT NULL,
	[UserId] [bigint] NOT NULL,
	[UserType] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[LoginId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Admin] ON 

INSERT [dbo].[Admin] ([SN], [AdminId], [Name], [Email], [Contact], [Photo]) VALUES (1, 1, N'Touhedur Rahman', N'rtouhedur@gmail.com', N'01775396637', N'1.PNG')
SET IDENTITY_INSERT [dbo].[Admin] OFF
INSERT [dbo].[Customer] ([Customer_Id], [Customer_Name], [Customer_Address], [Customer_Contact], [Customer_Email]) VALUES (1, N'aaa', N'uttara', N'11111111', N'customer1@gmail.com')
INSERT [dbo].[Customer] ([Customer_Id], [Customer_Name], [Customer_Address], [Customer_Contact], [Customer_Email]) VALUES (2, N'bbb', N'uttara', N'22222222', N'customer2@gmail.com')
INSERT [dbo].[Employee] ([Employee_Id], [Employee_Name], [Employee_Address], [Employee_Contact], [Employee_Email]) VALUES (1, N'Employee 1', N'Sector 10, Uttara, Dhaka ', N'111111', N'employee1@gmail.com')
INSERT [dbo].[Employee] ([Employee_Id], [Employee_Name], [Employee_Address], [Employee_Contact], [Employee_Email]) VALUES (2, N'Employee 2', N'uttara', N'22222', N'employee2@gmail.com')
INSERT [dbo].[Employee] ([Employee_Id], [Employee_Name], [Employee_Address], [Employee_Contact], [Employee_Email]) VALUES (3, N'Employee 3', N'Sector 10, Uttara, Dhaka ', N'33333', N'employee3@gmail.com')
INSERT [dbo].[Product] ([Product_Id], [Product_Name], [Brand_Name], [Product_Quantity], [Product_Price]) VALUES (1, N'Car', N'BMW', N'1', N'15000000')
INSERT [dbo].[Product] ([Product_Id], [Product_Name], [Brand_Name], [Product_Quantity], [Product_Price]) VALUES (2, N'Bike', N'Honda', N'1', N'205000')
SET IDENTITY_INSERT [dbo].[UserRole] ON 

INSERT [dbo].[UserRole] ([UserId], [UserType]) VALUES (1, N'Admin')
INSERT [dbo].[UserRole] ([UserId], [UserType]) VALUES (2, N'Employee')
INSERT [dbo].[UserRole] ([UserId], [UserType]) VALUES (3, N'Customer')
SET IDENTITY_INSERT [dbo].[UserRole] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([LoginId], [UserId], [UserType], [FirstName], [LastName], [Email], [Password]) VALUES (1, 1, N'Admin', N'Touhedur', N'Rahman', N'rtouhedur@gmail.com', N'17103081')
SET IDENTITY_INSERT [dbo].[Users] OFF
ALTER TABLE [dbo].[Payment]  WITH CHECK ADD  CONSTRAINT [FK_Payment_Customer] FOREIGN KEY([C_Id])
REFERENCES [dbo].[Customer] ([Customer_Id])
GO
ALTER TABLE [dbo].[Payment] CHECK CONSTRAINT [FK_Payment_Customer]
GO
ALTER TABLE [dbo].[Payment]  WITH CHECK ADD  CONSTRAINT [FK_Payment_Employee] FOREIGN KEY([E_Id])
REFERENCES [dbo].[Employee] ([Employee_Id])
GO
ALTER TABLE [dbo].[Payment] CHECK CONSTRAINT [FK_Payment_Employee]
GO
ALTER TABLE [dbo].[Payment]  WITH CHECK ADD  CONSTRAINT [FK_Payment_Product] FOREIGN KEY([P_Id])
REFERENCES [dbo].[Product] ([Product_Id])
GO
ALTER TABLE [dbo].[Payment] CHECK CONSTRAINT [FK_Payment_Product]
GO
ALTER TABLE [dbo].[UserRole]  WITH CHECK ADD  CONSTRAINT [FK_UserRole_UserRole] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserRole] ([UserId])
GO
ALTER TABLE [dbo].[UserRole] CHECK CONSTRAINT [FK_UserRole_UserRole]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_UserRole] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserRole] ([UserId])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_UserRole]
GO
USE [master]
GO
ALTER DATABASE [Store_Management_System] SET  READ_WRITE 
GO
