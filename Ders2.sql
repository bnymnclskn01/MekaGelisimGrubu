﻿--Create Database FunctionsDatabase
--Create Table Ogrenci(
--Id int primary key identity(1,1),
--Name nvarchar(30),
--Surname nvarchar(30),
--Age int,
--City nvarchar(30)
--)
--Create Function MusteriArasindaEnBuyukYasi
--(
--@Id int
--)
--Returns int 
--As
--Begin
--Declare @Result int Set @Result =(Select max(Age) From Ogrenci Where Id >=@Id)
--return (@Result)
--End
--DECLARE @Id int
--Set @Id=5
--Select
--dbo.MusteriArasindaEnBuyukYasi(@Id)
--Create Function karekterDegistir -- burada function isimi yazıyoruz
--(@metin VARCHAR(30)) --değer ve tipini belirliyoruz.
--RETURNS VARCHAR(30) --döndürülecek değer ve tipi
--AS
--Begin
--SET @metin = LOWER(@metin)
--Set @metin = REPLACE(@metin,'ü','u');
--SET @metin = REPLACE(@metin,'ğ','g');
--SET @metin = REPLACE(@metin,'ı','i');
--set @metin = REPLACE(@metin,'ş','s');
--set @metin = REPLACE(@metin,'ö','o');
--set @metin = REPLACE(@metin,'İ','i');
--set @metin = REPLACE(@metin,'ç','c');
--Return @metin
--END;
--DECLARE @Metin varchar(30)
--Set @Metin='Bünyamin'
--Select
--dbo.karekterDegistir(@Metin)

--select * from Ogrenci
--Create Proc IstanbulOlanlar
--As
--select * from dbo.Ogrenci where City='istanbul'

--Exec IstanbulOlanlar
--Create Proc Yasi20denBuyukOlan
--As
--Select * from dbo.Ogrenci where Age>20
--Exec Yasi20denBuyukOlan
--select * from Ogrenci
--Create Proc Yasi26danBuyukOlanBilisimdeOlanlar
--As
--select * from dbo.Ogrenci where Department='bilisim' and Age>26
--Exec Yasi26danBuyukOlanBilisimdeOlanlar