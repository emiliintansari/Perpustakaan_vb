-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 06 Agu 2023 pada 15.58
-- Versi server: 10.4.27-MariaDB
-- Versi PHP: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `perpustakaan_uas`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `anggota`
--

CREATE TABLE `anggota` (
  `nim` int(10) NOT NULL,
  `nama` text NOT NULL,
  `jk` varchar(10) NOT NULL,
  `tgl_lhir` varchar(10) NOT NULL,
  `alamat` text NOT NULL,
  `tahun_masuk` varchar(4) NOT NULL,
  `prodi` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `anggota`
--

INSERT INTO `anggota` (`nim`, `nama`, `jk`, `tgl_lhir`, `alamat`, `tahun_masuk`, `prodi`) VALUES
(202001043, 'Dudung Sugito', 'L', '18/08/2000', '22, Jalan Purworejo, Menteng, Special Capital Region of Jakarta', '2020', 'SI'),
(202201051, 'Adele Lillie', 'P', '2001-10-12', 'Graha Bethany Nginden, 29, Jalan Nginden Intan Timur I, Ngiden Jangkungan, Surabaya', '2022', 'TI'),
(202201053, 'Zainab Eve', 'P', '2002-05-27', '79, Jalan Jenderal Gatot Subroto, Ngiden Setiabudi, Special Capital Region of Jakarta', '2022', 'KA'),
(202201062, 'Brian Archie', 'L', '2003-08-21', '15, Jalan Teuku Umar,Menteng, Special Capital Region of Jakarta', '2022', 'KA'),
(202203002, 'Hamzae Bruce', 'L', '2003-01-08', '30, Jalan Nusantara VI, Jatimulya, Bekasi', '2022', 'TI');

-- --------------------------------------------------------

--
-- Struktur dari tabel `buku`
--

CREATE TABLE `buku` (
  `id_buku` int(11) NOT NULL,
  `kode_buku` char(50) NOT NULL,
  `judul_buku` varchar(50) NOT NULL,
  `penulis_buku` varchar(50) NOT NULL,
  `penerbit_buku` varchar(50) NOT NULL,
  `tahun_terbit` char(4) NOT NULL,
  `stok` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data untuk tabel `buku`
--

INSERT INTO `buku` (`id_buku`, `kode_buku`, `judul_buku`, `penulis_buku`, `penerbit_buku`, `tahun_terbit`, `stok`) VALUES
(1, '978-979-107-882-5', 'Akuntansi Pengantar 1', 'Supardi', 'Gava Media', '2009', 2),
(2, '978-979-128-365-6', 'Bangsa gagal ; Mencari identitas kebangsaan', 'Nasruddin Anshoriy', 'LKiS', '2008', 2),
(3, '979-896-678-3', 'Hantu Digoel; Politik Pengamanan Politik Zaman Kol', 'Takashi Shiraishi', 'LKiS', '2001', 2),
(4, '978-979-128-355-7', 'Kesadaran Nasional ; dari kolonialisme sampai keme', 'Slamet Muljana', 'LKiS', '2008', 2),
(5, '978-979-128-357-1', 'Kesadaran Nasional ; dari kolonialisme sampai keme', 'Slamet Muljana', 'LKiS', '2008', 2),
(6, '978-979-769-600-9', 'Kesehjateraan Sosial', 'Isbandi Rukminto Adi', 'Rajagrafindo Persada', '2015', 2),
(7, '978-979-294-344-3', 'Kolaborasi PHP 5 dan Mysql untuk pengembangan webs', 'Eko Priyo Utomo', 'Andi Offset', '2014', 2),
(8, '979-290-349-2', 'Kumpulan Undang undang Sistem peradilan Pidana', 'Lincon Arsyad', 'Andi Offset', '2007', 1),
(9, '978-979-295-172-1', 'Langsung Praktik Komputerisasi Akuntansi Dengan MY', 'Wahana Komputer', 'Andi Offset', '2015', 1),
(10, '978-979-128-303-8', 'Makna Budaya Dalam Komunikasi Antar Budaya', 'Alo Liliweri', 'LKiS', '2009', 3),
(11, '978-602-867-471-3', 'Manajemen Penerbitan Jurnal Ilmiah', 'Lukman S', 'Sagung Seto', '2012', 2),
(12, '978-979-290-742-1', 'Metode Riset Bisnis Edisi II', 'Suliyanto', 'Andi Offset', '2009', 2),
(13, '978-979-254-856-3', 'Pengantar Cultural Studies : Sejarah, Pendekatan, ', 'Sandi Suwardi Hasan', 'Ar-Ruzz Media', '2016', 2),
(14, '978-979-293-499-1', 'Quick Reference Windows 8', 'Wahana Komputer', 'Andi Offset', '2013', 2),
(15, '979-346-964-1', 'Strategi Bahasa Assembler + CD', 'Jason P', 'Gava Media', '2005', 2),
(16, '978-979-769-632-0', 'Strategic Management', 'Sofjan Assauri', 'Rajagrafindo Persada', '2016', 2),
(17, '978-979-107-870-2', 'Tuntunan Praktis : Pengembangan Aplikasi Sistem In', 'Riyanto', 'Gava Media', '2009', 2),
(18, '978-979-107-853-5', 'Aplikasi Program Akutansi dengan Visual FoxPro 9.0', 'Peter Wanto', 'Gava Media', '2008', 2),
(19, '978-979-294-016-9', 'Busines And Personal Development', 'Josua Taringan dan Swenjiadi Yenawan', 'Andi Offset', '2013', 2),
(20, '978-979-292-342-1', 'IMS (IP Multimedia Subsystem), Framework Dan Arsit', 'M. Azwir', 'Andi Offset', '2014', 2),
(21, '978-979-294-506-5', 'Kupas Tuntas : Microsoft Windows 8.1', 'Madcoms', 'Andi Offset', '2014', 2),
(22, '978-979-291-769-7', 'Langkah Mudah Belajar Kalkulus For IT(Khusus P. Ja', 'Sudaryono, Untung Rahardja, Edi S. Mulyanta', 'Andi Offset', '2012', 2),
(23, '978-602-752-391-3', 'Membuat Aplikasi Sistem Aplikasi Menggunakan VB.NE', 'Yulius Ekaq Agung Saputro', 'MITRA WACANA', '2013', 2),
(24, '978-979-295-094-6', 'Panduan Aplikasi dan Solusi: Pemodelan Obyek Denga', 'Wahana Komputer', 'Andi Offset', '2014', 2),
(25, '978-979-295-109-7', 'Panduan Praktis Sistem Kendali Digital', 'Azwardi Dan Cekmas Cekdin', 'Andi Offset', '2015', 2),
(26, '978-602-786-966-0', 'Pemrograman Web Membuat Sistem Informasi Akademik ', 'Bunafit Nugroho', 'Gava Media', '2014', 2),
(27, '978-979-346-982-X', 'Pengantar Membuat Robot', 'M. Ibnu Malik', 'Gava Media', '2006', 2),
(28, '978-979-294-249-1', 'Pengantar Teknologi Informasi', 'Tata Sutabri', 'Andi Offset', '2014', 2),
(29, '979-970-886-9', 'Pengenalan Dasar-Dasar PLC (Progamable Logic Contr', 'M. Budiyanto', 'Gava Media', '2006', 2),
(30, '978-979–293-119-8', 'Pengolahan Citra Digital : Konsep dan Teori', 'Fajar Astuti Hermawati', 'Andi Offset', '2013', 2);

-- --------------------------------------------------------

--
-- Struktur dari tabel `buku_tamu`
--

CREATE TABLE `buku_tamu` (
  `nama` varchar(100) NOT NULL,
  `nim` int(10) NOT NULL,
  `program_studi` varchar(10) NOT NULL,
  `keperluan` varchar(10) NOT NULL,
  `tanggal` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `buku_tamu`
--

INSERT INTO `buku_tamu` (`nama`, `nim`, `program_studi`, `keperluan`, `tanggal`) VALUES
('Susianto', 202201089, 'Teknik Mul', 'Meminjam', '02/08/2023 11:55:27'),
('Ajianto', 202203071, 'Komputeris', 'Membaca', '02/08/2023 11:55:27'),
('susi susanti', 20220302, 'Teknik Mul', 'Membaca', '02/08/2023 11:57:52');

-- --------------------------------------------------------

--
-- Struktur dari tabel `denda`
--

CREATE TABLE `denda` (
  `lama_waktu` varchar(10) NOT NULL,
  `nominal` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `denda`
--

INSERT INTO `denda` (`lama_waktu`, `nominal`) VALUES
('1 hari', '2000');

-- --------------------------------------------------------

--
-- Struktur dari tabel `detail_peminjaman`
--

CREATE TABLE `detail_peminjaman` (
  `id_pinjam` varchar(20) NOT NULL,
  `kode_buku` varchar(20) NOT NULL,
  `jumlah` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `detail_peminjaman`
--

INSERT INTO `detail_peminjaman` (`id_pinjam`, `kode_buku`, `jumlah`) VALUES
('PJM101', '978-979-128-303-8', 1),
('PJM102', '978-979-128-303-8', 1),
('PJM103', '978-979-128-303-8', 1),
('PJM104', '978-979-128-303-8', 2),
('PJM105', '978-979-128-303-8', 1),
('PJM105', '979-896-678-3', 1),
('PJM106', '979-290-349-2', 1),
('PJM107', '979-290-349-2', 1),
('PJM108', '979-290-349-2', 1),
('PJM109', '979-290-349-2', 1),
('PJM110', '978-979-290-742-1', 1),
('PJM111', '979-896-678-3', 1),
('PJM112', '979-896-678-3', 1),
('PJM113', '978-979-107-853-5', 1),
('PJM114', '978-979-107-853-5', 1),
('PJM115', '978-979-107-870-2', 1),
('PJM115', '978-602-752-391-3', 1),
('PJM116', '978-979-295-094-6', 1),
('PJM117', '978-979-107-870-2', 1),
('PJM118', '978-979-107-853-5', 1),
('PJM119', '978-979-107-853-5', 1),
('PJM119', '978-979-295-094-6', 1),
('PJM120', '978-979-107-853-5', 1);

-- --------------------------------------------------------

--
-- Struktur dari tabel `detail_pengembalian`
--

CREATE TABLE `detail_pengembalian` (
  `id_pinjam` varchar(20) NOT NULL,
  `id_kembali` varchar(100) NOT NULL,
  `kode_buku` varchar(20) NOT NULL,
  `judul_buku` varchar(100) NOT NULL,
  `jumlah` int(20) NOT NULL,
  `tgl_pinjam` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `detail_pengembalian`
--

INSERT INTO `detail_pengembalian` (`id_pinjam`, `id_kembali`, `kode_buku`, `judul_buku`, `jumlah`, `tgl_pinjam`) VALUES
('PJM102', 'KMB101', '978-979-128-303-8', 'Makna Budaya Dalam Komunikasi Antar Budaya', 1, '22/07/2023 20:37:47'),
('PJM103', 'KMB102', '978-979-128-303-8', 'Makna Budaya Dalam Komunikasi Antar Budaya', 1, '22/07/2023 20:37:47'),
('PJM104', 'KMB103', '978-979-128-303-8', 'Makna Budaya Dalam Komunikasi Antar Budaya', 2, '22/07/2023 20:37:47'),
('PJM107', 'KMB104', '979-290-349-2', 'Kumpulan Undang undang Sistem peradilan Pidana', 1, '22/07/2023 20:37:47'),
('PJM109', 'KMB105', '979-290-349-2', 'Kumpulan Undang undang Sistem peradilan Pidana', 1, '22/07/2023 20:37:47'),
('PJM108', 'KMB106', '979-290-349-2', 'Kumpulan Undang undang Sistem peradilan Pidana', 1, '22/07/2023 20:37:47'),
('PJM106', 'KMB107', '979-290-349-2', 'Kumpulan Undang undang Sistem peradilan Pidana', 1, '22/07/2023 20:37:47'),
('PJM110', 'KMB108', '978-979-290-742-1', 'Metode Riset Bisnis Edisi II', 1, '22/07/2023 20:37:47'),
('PJM111', 'KMB109', '979-896-678-3', 'Hantu Digoel; Politik Pengamanan Politik Zaman Kol', 1, '22/07/2023 20:37:47'),
('PJM112', 'KMB110', '979-896-678-3', 'Hantu Digoel; Politik Pengamanan Politik Zaman Kol', 1, '22/07/2023 20:37:47'),
('PJM105', 'KMB111', '979-896-678-3', 'Hantu Digoel; Politik Pengamanan Politik Zaman Kol', 1, '22/07/2023 20:37:47'),
('PJM105', 'KMB111', '978-979-128-303-8', 'Makna Budaya Dalam Komunikasi Antar Budaya', 1, '22/07/2023 20:37:47'),
('PJM113', 'KMB112', '978-979-107-853-5', 'Aplikasi Program Akutansi dengan Visual FoxPro 9.0', 1, '28/07/2023'),
('PJM114', 'KMB113', '978-979-107-853-5', 'Aplikasi Program Akutansi dengan Visual FoxPro 9.0', 1, '25/07/2023'),
('PJM115', 'KMB114', '978-979-107-870-2', 'Tuntunan Praktis : Pengembangan Aplikasi Sistem In', 1, '26/07/2023'),
('PJM115', 'KMB114', '978-602-752-391-3', 'Membuat Aplikasi Sistem Aplikasi Menggunakan VB.NE', 1, '26/07/2023'),
('PJM116', 'KMB115', '978-979-295-094-6', 'Panduan Aplikasi dan Solusi: Pemodelan Obyek Denga', 1, '27/07/2023'),
('PJM117', 'KMB116', '978-979-107-870-2', 'Tuntunan Praktis : Pengembangan Aplikasi Sistem In', 1, '26/07/2023'),
('PJM120', 'KMB117', '978-979-107-853-5', 'Aplikasi Program Akutansi dengan Visual FoxPro 9.0', 1, '28/07/2023');

-- --------------------------------------------------------

--
-- Struktur dari tabel `header_peminjaman`
--

CREATE TABLE `header_peminjaman` (
  `id_pinjaman` varchar(20) NOT NULL,
  `id_petugas` varchar(20) NOT NULL,
  `id_anggota` varchar(20) NOT NULL,
  `tgl_pinjam` varchar(20) NOT NULL,
  `status` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `header_peminjaman`
--

INSERT INTO `header_peminjaman` (`id_pinjaman`, `id_petugas`, `id_anggota`, `tgl_pinjam`, `status`) VALUES
('PJM101', '1', '202201051', '22/07/2023 20:37:47', 'kembali'),
('PJM102', '1', '202201062', '22/07/2023 20:37:47', 'kembali'),
('PJM103', '1', '202001043', '22/07/2023 20:37:47', 'kembali'),
('PJM104', '1', '202001043', '22/07/2023 20:37:47', 'kembali'),
('PJM105', '1', '202201051', '22/07/2023 20:37:47', 'kembali'),
('PJM106', '1', '202201051', '22/07/2023 20:37:47', 'kembali'),
('PJM107', '1', '202201062', '22/07/2023 20:37:47', 'kembali'),
('PJM108', '1', '202201062', '22/07/2023 20:37:47', 'kembali'),
('PJM109', '1', '202201062', '22/07/2023 20:37:47', 'kembali'),
('PJM110', '1', '202001043', '22/07/2023 20:37:47', 'kembali'),
('PJM111', '1', '202201062', '22/07/2023 20:37:47', 'kembali'),
('PJM112', '1', '202201051', '22/07/2023 20:37:47', 'kembali'),
('PJM113', '1', '202201051', '28/07/2023', 'kembali'),
('PJM114', '1', '202201051', '25/07/2023', 'kembali'),
('PJM115', '1', '202201062', '26/07/2023', 'kembali'),
('PJM116', '1', '202001043', '27/07/2023', 'kembali'),
('PJM117', '1', '202201051', '26/07/2023', 'kembali'),
('PJM118', '1', '202201062', '27/07/2023', 'DIPINJAM'),
('PJM119', '1', '202201053', '27/07/2023', 'DIPINJAM'),
('PJM120', '1', '202001043', '28/07/2023', 'kembali');

-- --------------------------------------------------------

--
-- Struktur dari tabel `header_pengembalian`
--

CREATE TABLE `header_pengembalian` (
  `id_pengembalian` varchar(11) NOT NULL,
  `tanggal_pengembalian` varchar(20) NOT NULL,
  `id_petugas` varchar(11) NOT NULL,
  `id_anggota` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data untuk tabel `header_pengembalian`
--

INSERT INTO `header_pengembalian` (`id_pengembalian`, `tanggal_pengembalian`, `id_petugas`, `id_anggota`) VALUES
('KMB101', '29 July 2023', '1', '202201062'),
('KMB102', '31 July 2023', '1', '202001043'),
('KMB103', '22 July 2023', '1', '202001043'),
('KMB104', '22 July 2023', '1', '202201062'),
('KMB105', '22 July 2023', '1', '202201062'),
('KMB106', '22 July 2023', '1', '202201062'),
('KMB107', '22 July 2023', '1', '202201051'),
('KMB108', '28 July 2023', '1', '202001043'),
('KMB109', '22 July 2023', '1', '202201062'),
('KMB110', '22 July 2023', '1', '202201051'),
('KMB111', '02 August 2023', '1', '202201051'),
('KMB112', '05 August 2023', '', '202201051'),
('KMB113', '03 August 2023', '1', '202201051'),
('KMB114', '02 August 2023', '1', '202201062'),
('KMB115', '02 August 2023', '1', '202001043'),
('KMB116', '03 August 2023', '1', '202201051'),
('KMB117', '02 August 2023', '', '202001043');

-- --------------------------------------------------------

--
-- Struktur dari tabel `petugas`
--

CREATE TABLE `petugas` (
  `id_petugas` int(11) NOT NULL,
  `nama_petugas` varchar(50) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `no_telp_petugas` char(13) NOT NULL,
  `alamat_petugas` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data untuk tabel `petugas`
--

INSERT INTO `petugas` (`id_petugas`, `nama_petugas`, `username`, `password`, `no_telp_petugas`, `alamat_petugas`) VALUES
(1, 'Abdul Ghan', 'abdul', '12345', '0856742122', 'jl.sukamulyo no.33 banyuwangi jawatimur');

-- --------------------------------------------------------

--
-- Struktur dari tabel `program_studi`
--

CREATE TABLE `program_studi` (
  `id_prodi` varchar(11) NOT NULL,
  `nama_prodi` varchar(100) NOT NULL,
  `akreditas` varchar(10) NOT NULL,
  `tanggal_berdiri` varchar(100) NOT NULL,
  `noskpendirian` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `program_studi`
--

INSERT INTO `program_studi` (`id_prodi`, `nama_prodi`, `akreditas`, `tanggal_berdiri`, `noskpendirian`) VALUES
('01', 'Sistem Informasi', 'B', '2008-12-31', '4734/D/T/2008'),
('02', 'Komputerisasi Akuntansi', 'B', '2011-08-22', '8447/D/T/K-VI/2011'),
('03', 'Teknik Informatika', 'C', '2015-09-15', '13/KPT/I/2015'),
('04', 'Teknik Multimedia dan Jaringan', 'C', '18/12/2015', ' 129/KPT/I/2015');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `anggota`
--
ALTER TABLE `anggota`
  ADD PRIMARY KEY (`nim`);

--
-- Indeks untuk tabel `buku`
--
ALTER TABLE `buku`
  ADD PRIMARY KEY (`id_buku`),
  ADD UNIQUE KEY `kode_buku` (`kode_buku`);

--
-- Indeks untuk tabel `header_peminjaman`
--
ALTER TABLE `header_peminjaman`
  ADD PRIMARY KEY (`id_pinjaman`);

--
-- Indeks untuk tabel `header_pengembalian`
--
ALTER TABLE `header_pengembalian`
  ADD PRIMARY KEY (`id_pengembalian`),
  ADD KEY `id_petugas` (`id_anggota`),
  ADD KEY `id_buku` (`id_petugas`);

--
-- Indeks untuk tabel `petugas`
--
ALTER TABLE `petugas`
  ADD PRIMARY KEY (`id_petugas`);

--
-- Indeks untuk tabel `program_studi`
--
ALTER TABLE `program_studi`
  ADD PRIMARY KEY (`id_prodi`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `buku`
--
ALTER TABLE `buku`
  MODIFY `id_buku` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=99;

--
-- AUTO_INCREMENT untuk tabel `petugas`
--
ALTER TABLE `petugas`
  MODIFY `id_petugas` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
