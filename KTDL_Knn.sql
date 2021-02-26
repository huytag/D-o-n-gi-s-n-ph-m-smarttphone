CREATE DATABASE KTDL_DT
GO
USE KTDL_DT
GO
CREATE TABLE CHIP
(
	idChip INT IDENTITY NOT NULL,
	tenChip NVARCHAR(50),
	hieuNang FLOAT,
	PRIMARY KEY(idChip)
)
GO
CREATE TABLE HANG
(
	idHang INT IDENTITY NOT NULL,
	tenHang NVARCHAR(200),
	doTincay FLOAT,
	PRIMARY KEY(idHang)
)
GO
CREATE TABLE LOAIMH
(
	idLoaiMH INT IDENTITY NOT NULL,
	tenLoaiMH NVARCHAR(200),
	chatLuong FLOAT,
	PRIMARY KEY(idLoaiMH)
)
INSERT INTO dbo.CHIP
        (tenChip, hieuNang )
VALUES  ( N'Apple A13', -- tenChip - nvarchar(50)
          0.9  -- hieuNang - float
          ),
		  (N'Apple A12',0.9),
		  (N'Apple A11',0.8),
		  (N'Apple A10',0.8),
		  (N'Apple A9',0.7),
		  (N'Apple A8',0.7),
		  (N'Snap 810',0.7),
		  (N'Snap 820',0.7),
		  (N'Snap 835',0.7),
		  (N'Snap 845',0.8),
		  (N'Snap 855',0.8),
		  (N'Snap 865',0.9),
		  (N'Snap 7xx',0.7),
		  (N'Snap 6xx',0.6),
		  (N'Snap 4xx',0.4),
		  (N'Helio P1x',0.2),
		  (N'Helio P2x',0.3),
		  (N'Helio P3x',0.3),
		  (N'Helio P6x',0.4),
		  (N'Helio P7x',0.6),
		  (N'Helio P9x',0.7),
		  (N'Exynos 98xx',0.8),
		  (N'Exynos 88xx',0.7),
		  (N'Exynos 78xx',0.6),
		  (N'Exynos 79xx',0.4),
		  (N'Kirin 9xx',0.8),
		  (N'Kirin 8xx',0.7),
		  (N'Kirin 7xx',0.6),
		  (N'Kirin 6xx',0.4)
GO
INSERT INTO dbo.HANG
        (tenHang, doTincay )
VALUES  ( N'Apple', -- tenHang - nvarchar(200)
          0.9  -- doTincay - float
          ),
		  (N'VSmart',1),
		  (N'Samsung',0.8),
		  (N'Sony',0.7),
		  (N'Xiaomi',0.6),
		  (N'Oppo',0.5),
		  (N'Realme',0.4),
		  (N'Huawei',0.3),
		  (N'Vivo',0.2),
		  (N'LG',0.1)
GO
INSERT INTO dbo.LOAIMH
        (tenLoaiMH, chatLuong )
VALUES  (N'4K Amoled', -- tenLoaiMH - nvarchar(200)
          0.9  -- chatLuong - float
          ),
		  (N'2K Amoled',0.9),
		  (N'4K LCD',0.8),
		  (N'2K LCD',0.8),
		  (N'FullHD+ Amoled',0.8),
		  (N'HD+ Amoled',0.7),
		  (N'FullHD+ LCD',0.7),
		  (N'HD+ LCD',0.6)
GO
DECLARE @max INT
SET @max = (SELECT MAX(STT) FROM dbo.GiaDT)
PRINT @max
SELECT * FROM dbo.GiaDT WHERE STT BETWEEN 5 AND (SELECT MAX(STT) FROM dbo.GiaDT)

select * from dbo.GiaDT