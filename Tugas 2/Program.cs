using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_2
{
    /// <summary>
    /// Aplikasi ini untuk mengitung luas persegi panjang
    /// </summary>
    class PersegiPanjang
    {
        //Deklarasi variabel panjang, lebar dan luas
        private double p, l, luas;

        //method untuk memasukkan nilai panjang, lebar dan luas
        public void InputData()
        {
            //Menampilkan 'Masukkan panjangnya'
            Console.Write("Masukkan Panjangnya = ");

            //Menambahkan panjang
            p = Convert.ToDouble(Console.ReadLine());

            //Menampilkan 'Masukkan lebarnya: '
            Console.Write("Masukkan Lebarnya: ");

            //Menambahkan lebar
            l = Convert.ToDouble(Console.ReadLine());
        }

        //method yang menghitung nilai luas
        public void ProsesData()
        {
            //menghitung luas = panjang * lebar
            luas = p * l;
        }

        //method yang mengitung nilai luas
        public double ProsesData1()
        {
            luas = p * l;
            return luas;
        }

        //method yang mengembalikan nilai yang memiliki parameter panjang dan lebar
        public double ProsesData2(double panjang, double lebar)
        {
            return panjang * lebar;
        }

        //method yang menampilkan nilai luas yang sudah di hitung
        public void OutputData()
        {
            //Menampilkan 'Luasnya' 
            Console.WriteLine("Panjang = {0} Lebar = {1} Luasnya {2}", p, l, luas);
        }

        //method yang menampilkan nilai luas yang sudah dihitung
        public void OutputData1()
        {
            //Menampilkan 'Luasnya'
            Console.WriteLine("Panjang = {0} Lebar = {1} Luasnya {2}", p, l, ProsesData1());
        }

        //method dengan menampilkan nilai luas yang sudah di hitung 
        public void OutputData2(double luas)
        {
            //Menampilkan 'Luasnya'
            Console.WriteLine("Panjang = {0} Lebar = {1} Luasnya= {2}", p, l, luas);
        }


        static void Main(string[] args)
        {
            //membuat program untuk memunculkan codingan diatas
            PersegiPanjang pp = new PersegiPanjang();
            coba cb = new coba();

            //memanggil method dari class PersegiPanjang diatas agar bisa di tampilkan
            pp.InputData();
            pp.ProsesData();
            pp.OutputData();
            pp.OutputData1();

            pp.OutputData2(pp.ProsesData2(pp.p, pp.l));

            //memanggil method dari class coba
            pp.OutputData2(cb.ProsesData3(pp.p, pp.l));
            Console.ReadKey();
        }
    }

    //membuat class baru
    class coba
    {
        //method yang mengembalikan nilai yang memiliki parameter panjang dan lebar
        public double ProsesData3(double panjang, double lebar)
        {
            return panjang * lebar;
        }
    }
}