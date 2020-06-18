using System;
using System.Collections.Generic;
using TugasOOP.Anak;
using TugasOOP.Induk;

namespace TugasOOP
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //deklarasi objek
            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.Nik = "19.11.2711";
            karyawanTetap.Nama = "Mohamad";
            karyawanTetap.GajiBulanan = 10000000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.Nik = "50.60.7171";
            karyawanHarian.Nama = "Bagus";
            karyawanHarian.JumlahJamKerja = 8;
            karyawanHarian.UpahPerJam = 150000;

            Sales sales = new Sales();
            sales.Nik = "50.60.30";
            sales.Nama = "Rizky";
            sales.JumlahPenjualan = 100;
            sales.Komisi = 2000;
            

            //object class collection
            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);
            

            //loop
            int nomor = 1;
            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine(" {0}.NIK: {1}\nNama: {2} \nGaji: {3:N0}\n",
                    nomor, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                nomor++;
            }
            

           

        }
    }
}