using System;
using System.Collections.Generic;
using Tugas_Lab_8.ClassAnak;
using Tugas_Lab_8.ClassInduk;

namespace Tugas_Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8";

            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.Nik = "234-678-345";
            karyawanTetap.Nama = "Lusdiani";
            karyawanTetap.GajiBulanan = 50000000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.Nik = "123-456-786";
            karyawanHarian.Nama = "Kiki Baihaqi";
            karyawanHarian.JumlahJamKerja = 7;
            karyawanHarian.UpahPerJam = 30000;

            Sales sales = new Sales();
            sales.Nik = "765-876-235";
            sales.Nama = "Dika Andika";
            sales.JumlahPenjualan = 30;
            sales.Komisi = 75000;

            List<Karyawan> listKaryawan = new List<Karyawan>();
            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int noUrut = 1;

            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}, Nik: {1}, Nama: {2}, Gaji: {3:n0}", noUrut, karyawan.Nik, karyawan.Nama, karyawan.Gaji());

                noUrut++;
            }

            Console.ReadKey();
        }
    }
}