-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 07, 2021 at 05:25 PM
-- Server version: 10.4.14-MariaDB
-- PHP Version: 7.4.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_pbos`
--
CREATE DATABASE IF NOT EXISTS `db_pbos` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `db_pbos`;

-- --------------------------------------------------------

--
-- Table structure for table `ms_customer`
--

CREATE TABLE `ms_customer` (
  `nik` varchar(6) NOT NULL,
  `nama` varchar(25) NOT NULL,
  `alamat` varchar(50) NOT NULL,
  `jenis_kelamin` varchar(12) NOT NULL,
  `telepon` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `ms_golongan`
--

CREATE TABLE `ms_golongan` (
  `id_golongan` varchar(6) NOT NULL,
  `nama_golongan` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `ms_jenis_pengeluaran`
--

CREATE TABLE `ms_jenis_pengeluaran` (
  `id_jenis_pengeluaran` varchar(6) NOT NULL,
  `jenis_pengeluaran` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `ms_kartu`
--

CREATE TABLE `ms_kartu` (
  `id_kartu` varchar(6) NOT NULL,
  `nama_kartu` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `ms_nota`
--

CREATE TABLE `ms_nota` (
  `id_nota` varchar(6) NOT NULL,
  `header_1` varchar(25) NOT NULL,
  `header_2` varchar(20) NOT NULL,
  `header_3` varchar(20) NOT NULL,
  `footer_1` varchar(25) NOT NULL,
  `footer_2` varchar(25) NOT NULL,
  `footer_3` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `ms_produk`
--

CREATE TABLE `ms_produk` (
  `id_produk` varchar(6) NOT NULL,
  `barcode` varchar(50) NOT NULL,
  `nama_produk` varchar(50) NOT NULL,
  `nama_pendek` varchar(17) NOT NULL,
  `aktif` varchar(1) NOT NULL,
  `id_supplier` varchar(6) NOT NULL,
  `id_golongan` varchar(6) NOT NULL,
  `lokasi` varchar(25) NOT NULL,
  `harga_beli` int(12) NOT NULL,
  `harga_jual` int(12) NOT NULL,
  `stok` int(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `ms_promo`
--

CREATE TABLE `ms_promo` (
  `id_promo` varchar(6) NOT NULL,
  `nama_promo` varchar(25) NOT NULL,
  `id_produk` varchar(6) NOT NULL,
  `tgl_awal` date NOT NULL,
  `tgl_akhir` date NOT NULL,
  `status` varchar(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `ms_supplier`
--

CREATE TABLE `ms_supplier` (
  `id_supplier` varchar(6) NOT NULL,
  `nama_supplier` varchar(25) NOT NULL,
  `alamat` varchar(50) NOT NULL,
  `telepon` varchar(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `ms_toko`
--

CREATE TABLE `ms_toko` (
  `id_toko` varchar(4) NOT NULL,
  `nama_toko` varchar(25) NOT NULL,
  `alamat` varchar(50) NOT NULL,
  `kota` varchar(25) NOT NULL,
  `tgl_buka` date NOT NULL,
  `telepon` varchar(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tx_pembayaran_pembelian_produk`
--

CREATE TABLE `tx_pembayaran_pembelian_produk` (
  `nota` int(12) NOT NULL,
  `id_toko` varchar(4) NOT NULL,
  `tanggal` date NOT NULL,
  `id_supplier` varchar(6) NOT NULL,
  `nota_beli` int(11) NOT NULL,
  `rupiah_bayar` int(12) NOT NULL,
  `keterangan` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tx_pembelian_produk`
--

CREATE TABLE `tx_pembelian_produk` (
  `nota` int(12) NOT NULL,
  `id_toko` varchar(4) NOT NULL,
  `tanggal` date NOT NULL,
  `jatuh_tempo` date NOT NULL,
  `status` varchar(5) NOT NULL,
  `id_supplier` varchar(6) NOT NULL,
  `id_produk` varchar(6) NOT NULL,
  `nama_produk` varchar(50) NOT NULL,
  `qty` int(12) NOT NULL,
  `harga` int(12) NOT NULL,
  `total_harga` int(12) NOT NULL,
  `keterangan` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tx_pengeluaran_biaya`
--

CREATE TABLE `tx_pengeluaran_biaya` (
  `nota` int(11) NOT NULL,
  `id_toko` varchar(4) NOT NULL,
  `tanggal` date NOT NULL,
  `jenis_pengeluaran` varchar(50) NOT NULL,
  `qty` int(12) NOT NULL,
  `harga` int(12) NOT NULL,
  `total_harga` int(12) NOT NULL,
  `keterangan` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tx_penyesuaian_stok`
--

CREATE TABLE `tx_penyesuaian_stok` (
  `id_toko` varchar(4) NOT NULL,
  `id_produk` varchar(6) NOT NULL,
  `barcode` varchar(50) NOT NULL,
  `nama_produk` varchar(50) NOT NULL,
  `tgl` date NOT NULL,
  `qty` int(12) NOT NULL,
  `alasan` varchar(25) NOT NULL,
  `keterangan` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tx_retur_pembelian`
--

CREATE TABLE `tx_retur_pembelian` (
  `nota` int(11) NOT NULL,
  `id_toko` varchar(4) NOT NULL,
  `tanggal` date NOT NULL,
  `id_supplier` varchar(6) NOT NULL,
  `nota_beli` int(11) NOT NULL,
  `id_produk` varchar(6) NOT NULL,
  `nama_produk` varchar(50) NOT NULL,
  `qty` int(12) NOT NULL,
  `harga` int(12) NOT NULL,
  `total_harga` int(12) NOT NULL,
  `keterangan` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `ms_customer`
--
ALTER TABLE `ms_customer`
  ADD PRIMARY KEY (`nik`);

--
-- Indexes for table `ms_jenis_pengeluaran`
--
ALTER TABLE `ms_jenis_pengeluaran`
  ADD PRIMARY KEY (`id_jenis_pengeluaran`);

--
-- Indexes for table `ms_kartu`
--
ALTER TABLE `ms_kartu`
  ADD PRIMARY KEY (`id_kartu`);

--
-- Indexes for table `ms_nota`
--
ALTER TABLE `ms_nota`
  ADD PRIMARY KEY (`id_nota`);

--
-- Indexes for table `ms_produk`
--
ALTER TABLE `ms_produk`
  ADD PRIMARY KEY (`id_produk`);

--
-- Indexes for table `ms_promo`
--
ALTER TABLE `ms_promo`
  ADD PRIMARY KEY (`id_promo`);

--
-- Indexes for table `ms_supplier`
--
ALTER TABLE `ms_supplier`
  ADD PRIMARY KEY (`id_supplier`);

--
-- Indexes for table `tx_pembayaran_pembelian_produk`
--
ALTER TABLE `tx_pembayaran_pembelian_produk`
  ADD PRIMARY KEY (`nota`,`id_toko`,`tanggal`,`nota_beli`) USING BTREE;

--
-- Indexes for table `tx_pembelian_produk`
--
ALTER TABLE `tx_pembelian_produk`
  ADD PRIMARY KEY (`nota`,`tanggal`,`id_produk`,`id_toko`) USING BTREE;

--
-- Indexes for table `tx_pengeluaran_biaya`
--
ALTER TABLE `tx_pengeluaran_biaya`
  ADD PRIMARY KEY (`nota`,`id_toko`,`tanggal`,`jenis_pengeluaran`) USING BTREE;

--
-- Indexes for table `tx_penyesuaian_stok`
--
ALTER TABLE `tx_penyesuaian_stok`
  ADD PRIMARY KEY (`id_produk`,`tgl`,`id_toko`) USING BTREE;

--
-- Indexes for table `tx_retur_pembelian`
--
ALTER TABLE `tx_retur_pembelian`
  ADD PRIMARY KEY (`nota`,`tanggal`,`id_produk`,`id_toko`) USING BTREE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
