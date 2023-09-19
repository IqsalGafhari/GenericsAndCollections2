using OOP4;
using System;
using System.Threading;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace OOP4
{
    //inheritence
    public class Fitur : Abstract
    {
        public void utama()
        {
        awal:
            //pembuatan object
            
            Admin admin = new Admin();
            Console.Clear();
            Console.WriteLine("Selamat Datang di Perpustakaan");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Selamat Datang");
            Console.WriteLine("Login ke Sistem");
            Console.WriteLine("----------------------------------");
            Console.Write("Username: ");
            string inputID = Console.ReadLine();
            Console.Write("Password: ");
            string inputPW = Console.ReadLine();

            if (inputID == user[0] && inputPW == password[0])
            {
                bool kondisi = true;
                while (kondisi == true)
                {
                    Console.Clear();
                    menuadmin();
                    Console.Write("Pilihan Fitur : ");
                    Program ketik = new Program();
                    int input = ketik.getpilihan();
                    switch (input)
                    {
                        case 1:
                            admin.Daftarnasabah(namabuku, tahun, penulis);
                            break;
                        case 2:
                            admin.Hapusnasabah(namabuku, tahun, penulis);
                            break;
                        case 3:
                            admin.Tambahnasabah(namabuku, tahun, penulis);
                            break;
                        case 4:
                            admin.Editnasabah(namabuku, tahun, penulis);
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine("Akun Telah Log Out, Aplikasi Ditutup Terimakasih");
                            Thread.Sleep(1000);
                            goto awal;

                        default:
                            Console.WriteLine("Pilihan Tidak Ada");
                            Thread.Sleep(1000);
                            break;
                    }

                }
            }
            else
            {
                Console.WriteLine("Password Salah");
                Thread.Sleep(2000);
                goto awal;
            }
        }

        public void menuadmin()
        {
            Console.WriteLine("");
            Console.WriteLine("Selamat Datang di Perpustakaan");
            Console.WriteLine("-------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Halo Admin!");
            Console.WriteLine("");
            Console.WriteLine("Pilihan Fitur");
            Console.WriteLine("");
            Console.WriteLine("1. Menampilkan Data Daftar Buku");
            Console.WriteLine("2. Menghapus Data Buku");
            Console.WriteLine("3. Menambahakan Data Buku");
            Console.WriteLine("4. Mengubah Data Buku");
            Console.WriteLine("5. Log Out");
            Console.WriteLine("");
        }
    }
}
