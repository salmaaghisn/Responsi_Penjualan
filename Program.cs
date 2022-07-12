using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        TampilPenjualan();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilih Menu Aplikasi!\n");
            Console.WriteLine("1. Tambah Penjualan");
            Console.WriteLine("2. Tampilkan Penjualan");
            Console.WriteLine("3. Keluar");
            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahPenjualan()
        {
            Console.Clear();
            Console.WriteLine("Tambah Data Penjualan\n");
            Console.Write("Nota: ");
            string nota = Console.ReadLine();
            Console.Write("Tanggal: ");
            string tanggal = Console.ReadLine();
            Console.Write("Customer: ");
            string nama = Console.ReadLine();
            Console.Write("Jenis (T/K):");
            string jenis = Console.ReadLine();
            if (jenis == "t" || jenis == "T")
            {
                jenis = "Tunai";
            }
            else if (jenis == "K" || jenis == "k")
            {
                jenis = "Kredit";
            }
            Console.Write("Total Nota: ");
            int total = Convert.ToInt32(Console.ReadLine());
            daftarPenjualan.Add (new Penjualan (nota, tanggal, nama, jenis, total));

            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();
            int counter = 1;
            Console.WriteLine("Data Penjualan !\n");
            foreach (Penjualan penjualan in daftarPenjualan)
            {

                Console.WriteLine(counter + ". " + penjualan.nota + ", " + penjualan.tanggal + ", " + penjualan.nama + ", " + penjualan.jenis + ", " + penjualan.total);
                counter++;
            }
            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
