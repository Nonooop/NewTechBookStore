//login
CREATE PROCEDURE spLogin @Username varchar(50), @Passwd varchar(50)
AS 
	select nama, password, level_user from tbUser where nama = @Username and password = @Passwd
GO

EXEC spLogin 'Luthfiyah Sakinah','pia123'
//tampil data
CREATE PROCEDURE spDataDashboard
AS
	SELECT tbTransaksi.id_transaksi,tbTransaksi.tgl_transaksi, tbUser.nama as nama_pelayan, tbPelanggan.nama as nama_pembeli, tbPelanggan.alamat,tbPelanggan.telepon, tbBuku.judul as judul_buku_yang_dibeli, tbBuku.harga,tbTransaksi.jumlah,tbTransaksi.total
	FROM tbTransaksi
	JOIN tbPelanggan
	ON tbPelanggan.id_pelanggan=tbTransaksi.id_pelanggan
	JOIN tbUser
	ON tbUser.id_user=tbTransaksi.id_user
	JOIN tbBuku
	ON tbBuku.id_buku=tbTransaksi.id_barang	
GO
EXEC spDataDashboard

//cari
CREATE PROCEDURE spCariData4tabel @Cari varchar(50)
AS 
	SELECT tbTransaksi.id_transaksi,tbTransaksi.tgl_transaksi, tbUser.nama as nama_pelayan, tbPelanggan.nama as nama_pembeli, tbPelanggan.alamat,tbPelanggan.telepon, tbBuku.judul as judul_buku_yang_dibeli, tbBuku.harga,tbTransaksi.jumlah,tbTransaksi.total
	FROM tbTransaksi
	JOIN tbPelanggan
	ON tbPelanggan.id_pelanggan=tbTransaksi.id_pelanggan
	JOIN tbUser
	ON tbUser.id_user=tbTransaksi.id_user
	JOIN tbBuku
	ON tbBuku.id_buku=tbTransaksi.id_barang	
	WHERE  tbTransaksi.id_transaksi LIKE '%' +@Cari+ '%' OR tbUser.nama LIKE '%' +@Cari+ '%' OR tbPelanggan.nama LIKE '%' +@Cari+ '%' OR tbPelanggan.alamat  LIKE '%' +@Cari+ '%'  OR tbPelanggan.telepon  LIKE '%' +@Cari+ '%' OR tbBuku.judul LIKE '%' +@Cari+ '%' 
	OR tbTransaksi.jumlah LIKE '%' +@Cari+ '%' OR tgl_transaksi LIKE '%' +@Cari+ '%' 
GO

EXEC spCariData4tabel 'nd'


//data user
CREATE PROC spDataUser
AS
	Select * from tbUser
Go
EXEC spDataUser

ALTER PROCEDURE spCariDataUser @Cari varchar(50)
AS 
	SELECT * FROM tbUser WHERE id_user LIKE '%' +@Cari+ '%' OR nama LIKE '%' +@Cari+ '%' OR email LIKE '%' +@Cari+ '%' OR password LIKE '%' +@Cari+ '%'  OR level_user LIKE '%' +@Cari+ '%'
GO

EXECUTE spCariDataUser 'kas'


CREATE PROCEDURE spIdUser
AS 
	select id_user from tbUser where id_user in(select max(id_user) from tbUser) order by id_user desc
GO

EXECUTE spIdUser


CREATE PROC spInputUser @ID varchar(50), @NAMA varchar(50),
						 @EMAIL varchar(50), @PASSWD varchar(50), @LEVEL varchar(50)
AS
	INSERT INTO tbUser(id_user,nama,email,password,level_user,input_date)
	VALUES(@ID, @NAMA, @EMAIL, @PASSWD, @LEVEL,GETDATE())
Go
EXEC spInputUser 'USR0004', 'Pia','piasan@gmail.com', 'pia1','Kasir'

CREATE PROC spUpdateUser @ID varchar(50), @NAMA varchar(50),
						 @EMAIL varchar(50), @PASSWD varchar(50), @LEVEL varchar(50)
AS
	UPDATE tbUser SET  nama= @NAMA, email = @EMAIL, password=@PASSWD, level_user = @LEVEL
	WHERE id_user= @ID
GO

EXEC spUpdateUser 'USR0004', 'Piasan','piasan@gmail.com', 'pia1','Kasir'


CREATE PROC spHapusUser @ID AS VARCHAR(50)
AS
	DELETE FROM tbUser WHERE id_user= @ID
GO

EXEC spHapusUser 'USR0004'


//data buku
CREATE PROC spDataBuku
AS
	Select * from tbBuku
Go
EXEC spDataBuku

CREATE PROCEDURE spCariDataBuku @Cari varchar(50)
AS 
	SELECT * FROM tbBuku WHERE id_buku LIKE '%' +@Cari+ '%' OR judul LIKE '%' +@Cari+ '%' OR penerbit LIKE '%' +@Cari+ '%' OR penulis LIKE '%' +@Cari+ '%' 
	OR tahun LIKE '%' +@Cari+ '%' OR harga LIKE '%' +@Cari+ '%' OR stok LIKE '%' +@Cari+ '%' OR kategori LIKE '%' +@Cari+ '%' OR ISBN LIKE '%' +@Cari+ '%'
GO

EXECUTE spCariDataBuku 'pen'


CREATE PROCEDURE spIdBuku
AS 
	select id_buku from tbBuku where id_buku in(select max(id_buku) from tbBuku) order by id_buku desc
GO

EXECUTE spIdBuku


ALTER PROC spInputBuku @ID varchar(50), @JUDUL varchar(50),
						 @PENULIS varchar(50), @PENERBIT varchar(50), @TAHUN varchar(50), @HARGA int, @STOK int, @KATEGORI varchar(50), @ISBN varchar(50)
AS
	INSERT INTO tbBuku(id_buku,judul,penulis,penerbit,tahun,harga,stok,kategori,ISBN)
	VALUES(@ID, @JUDUL ,@PENULIS, @PENERBIT, @TAHUN, @HARGA, @STOK, @KATEGORI, @ISBN)
Go
EXEC spInputBuku 'BK0006', 'History of Madura','Drs.H.Muhammad Syamsudin', 'Araska','2019',63000,60,'Non Fiksi','978-602-300-072-2'

CREATE PROC spUpdateBuku @ID varchar(50), @JUDUL varchar(50),
						 @PENULIS varchar(50), @PENERBIT varchar(50), @TAHUN varchar(50), @HARGA int, @STOK int, @KATEGORI varchar(50), @ISBN varchar(50)
AS
	UPDATE tbBuku SET  judul= @JUDUL, penulis = @PENULIS, penerbit=@PENERBIT, tahun = @TAHUN, harga=@HARGA, stok=@STOK, kategori=@KATEGORI, ISBN=@ISBN
	WHERE id_buku= @ID
GO

EXEC spUpdateBuku 'BK0006', 'History of Madura','Drs.H.Muhammad Syamsudin', 'Araska Bentang','2019',63000,60,'Non Fiksi','978-602-300-072-2'


CREATE PROC spHapusBuku @ID AS VARCHAR(50)
AS
	DELETE FROM tbBuku WHERE id_buku= @ID
GO

EXEC spHapusBuku 'BK0006'


//data pelanggan
CREATE PROC spDataPelanggan
AS
	Select * from tbPelanggan
Go
EXEC spDataPelanggan

CREATE PROCEDURE spCariDataPelanggan @Cari varchar(50)
AS 
	SELECT * FROM tbPelanggan WHERE id_pelanggan LIKE '%' +@Cari+ '%' OR nama LIKE '%' +@Cari+ '%' OR alamat LIKE '%' +@Cari+ '%' OR telepon LIKE '%' +@Cari+ '%' 
GO

EXECUTE spCariDataPelanggan 'ay'


CREATE PROCEDURE spIdPelanggan
AS 
	select id_pelanggan from tbPelanggan where id_pelanggan in(select max(id_pelanggan) from tbPelanggan) order by id_pelanggan desc
GO

EXECUTE spIdPelanggan


CREATE PROC spInputPelanggan @ID varchar(50), @NAMA varchar(50),
						 @ALAMAT varchar(50), @TELEPON varchar(50)
AS
	INSERT INTO tbPelanggan(id_pelanggan,nama,alamat,telepon)
	VALUES(@ID, @NAMA, @ALAMAT, @TELEPON)
Go
EXEC spInputPelanggan 'CST0004', 'Syamsudin', 'Pasar Rebo', '083648729312'

CREATE PROC spUpdatePelanggan @ID varchar(50), @NAMA varchar(50),
						 @ALAMAT varchar(50), @TELEPON varchar(50)
AS
	UPDATE tbPelanggan SET  nama= @NAMA, alamat = @ALAMAT, telepon=@TELEPON
	WHERE id_pelanggan= @ID
GO

EXEC spUpdatePelanggan 'CST0004', 'Muhammad Syamsudin', 'Pasar Rebo', '083648729312'


CREATE PROC spHapusPelanggan @ID AS VARCHAR(50)
AS
	DELETE FROM tbPelanggan WHERE id_pelanggan= @ID
GO

EXEC spHapusPelanggan 'CST0004'


//data transaksi
ALTER PROC spDataNamaUser @NAMA varchar(50)
AS
	Select id_user from tbUser where nama=@NAMA
Go
EXEC spDataNamaUser 'Luthfiyah Sakinah'

ALTER PROC spDataNamaPelanggan
AS
	Select id_pelanggan from tbPelanggan 
Go
EXEC spDataNamaPelanggan

ALTER PROC spDataNamaBuku
AS
	Select id_buku from tbBuku
Go
EXEC spDataNamaBuku

CREATE PROC spDataTransaksi
AS
	Select * from tbTransaksi
Go
EXEC spDataTransaksi

CREATE PROCEDURE spCariDataTransaksi @Cari varchar(50)
AS 
	SELECT * FROM tbTransaksi WHERE id_transaksi LIKE '%' +@Cari+ '%' OR id_user LIKE '%' +@Cari+ '%' OR id_pelanggan LIKE '%' +@Cari+ '%' OR id_barang LIKE '%' +@Cari+ '%'  OR jumlah LIKE '%' +@Cari+ '%' OR total LIKE '%' +@Cari+ '%' 
GO

EXECUTE spCariDataTransaksi '8'


CREATE PROCEDURE spIdTransaksi
AS 
	select id_transaksi from tbTransaksi where id_transaksi in(select max(id_transaksi) from tbTransaksi) order by id_transaksi desc
GO

EXECUTE spIdTransaksi


CREATE PROC spInputTransaksi @ID varchar(50), @PELAYAN VARCHAR(50),
						 @PELANGGAN varchar(50), @BARANG varchar(50), @JUMLAH varchar(50), @TOTAL varchar(50)
AS
	INSERT INTO tbTransaksi(id_transaksi,tgl_transaksi,id_user,id_pelanggan,id_barang,jumlah,total)
	VALUES(@ID, GETDATE(),@PELAYAN, @PELANGGAN, @BARANG,@JUMLAH,@TOTAL)
Go
EXEC spInputTransaksi 'TSR0004', 'USR0003','CST0004', 'BK0002',4, '280000'

CREATE PROC spUpdateTransaksi @ID varchar(50),
						 @PELANGGAN varchar(50), @BARANG varchar(50), @JUMLAH varchar(50), @TOTAL varchar(50)
AS
	UPDATE tbTransaksi SET  id_pelanggan= @PELANGGAN, id_barang = @BARANG, jumlah=@JUMLAH
	WHERE id_transaksi= @ID
GO

EXEC spUpdateTransaksi 'TSR0004', 'CST0002', 'BK0002',40, '280000'
EXEC spDataTransaksi

CREATE PROC spHapusTransaksi @ID AS VARCHAR(50)
AS
	DELETE FROM tbTransaksi WHERE id_transaksi= @ID
GO

EXEC spHapusTransaksi 'TSR0004'