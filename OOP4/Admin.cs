using System;
using System.Collections.Generic;
using System.Threading;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace OOP4
{
    class Admin : Abstract
    {
        public override void Daftarnasabah(List<string> daftarbuku, List<int> tahun, List<string> penulis)
        {
            Console.Clear();
            Console.WriteLine("Daftar Buku");
            Console.WriteLine("");
            int b = daftarbuku.Count;
            for (int a = 0; a < b; a++)
            {
                Console.WriteLine("ID [" + (a + 1) + "]");
                Console.WriteLine("Title :" + daftarbuku[a]);
                Console.WriteLine("Publication Year : " + tahun[a]);
                Console.WriteLine("Author: " + penulis[a]);
                
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("");
            }
            Console.ReadKey();
        }

        public void Hapusnasabah(List<string> daftarbuku, List<int> tahun, List<string> penulis)
        {
            Console.Clear();
            Console.WriteLine("Hapus Data Buku");
            Console.WriteLine("");
            int b = daftarbuku.Count;
            for (int a = 0; a < b; a++)
            {
                Console.WriteLine("ID [" + (a + 1) + "]" + daftarbuku[a]);
            }
            Console.Write("No. ID Buku : ");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input <= daftarbuku.Count && daftarbuku.Count != 0)
            {
                Console.WriteLine("Apakah Yakin Ingin Menghapus ID [" + input + "] : ");
                Daftarnasabah(daftarbuku, tahun, penulis, input - 1);
                Console.WriteLine("Y/N : ");
                string konfirmasi = Console.ReadLine();
                if (konfirmasi == "Y" || konfirmasi == "y")
                {
                    daftarbuku.RemoveAt(input - 1);
                    tahun.RemoveAt(input - 1);
                    penulis.RemoveAt(input - 1);
                    
                    Console.WriteLine("Data Buku Berhasil Dihapus");
                    Thread.Sleep(1000);
                }
            }

            else
            {
                Console.WriteLine("Data Buku Tidak Ditemukan");
                Thread.Sleep(1000);
            }

        }

        public void Tambahnasabah(List<string> daftarbuku, List<int> tahun, List<string> penulis)
        {
            Console.Clear();
            Console.WriteLine("Tambah Buku");
            Console.WriteLine("");
            Console.WriteLine("Title: ");
            string inputbuku = Console.ReadLine();
            daftarbuku.Add(inputbuku);
            Console.Write("Publication Year: ");
            int inputtahun = Convert.ToInt32(Console.ReadLine());
            tahun.Add(inputtahun);
            Console.Write("Author: ");
            string inputpenulis = Console.ReadLine();
            penulis.Add(inputpenulis);
            
            Console.Clear();
            Console.WriteLine("Data Berhasil Ditambah");
            Thread.Sleep(1000);
        }

        public void Editnasabah(List<string> daftarbuku, List<int> tahun, List<string> penulis)
        {
            Console.Clear();
            int b = daftarbuku.Count();
            for (int a = 0; a < b; a++)
            {
                Console.WriteLine("ID [ " + (a + 1) + "]" + daftarbuku[a]);
            }
            Console.WriteLine("No ID Buku : ");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input <= b && input != 0)
            {
                Console.Write("Title : ");
                string inputbuku = Console.ReadLine();
                daftarbuku[input - 1] = inputbuku;
                Console.Write("Publication Year : ");
                int inputtahun = Convert.ToInt32(Console.ReadLine());
                tahun[input - 1] = inputtahun;
                Console.Write("Author : ");
                string inputpenulis = Console.ReadLine();
                penulis[input - 1] = inputpenulis;
                
                Console.WriteLine(" ");
                Console.WriteLine("Data Telah Diupdate");
            }

            else
            {
                Console.WriteLine("ID Tidak Ada");
                Thread.Sleep(1000);
            }
        }

    }
}
