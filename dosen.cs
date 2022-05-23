using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dosen
{
    class dosen
    {
        private int id { get; set; }
        private string name { get; set; }
        private int nik { get; set; }
        private string gender { get; set; }
        private string course { get; set; }

        public dosen(int id, string name, int nik, string gender, string course)
        {
            this.id = id;
            this.gender = gender;
            this.name = name;
            this.nik = nik;
            this.course = course;
        }

        public void hasil()
        {
            Console.WriteLine("Data Dosen");
            Console.WriteLine();
            Console.WriteLine($"ID      : {this.id}");
            Console.WriteLine($"Name    : {this.name}");
            Console.WriteLine($"NIK     : {this.nik}");
            Console.WriteLine($"Gender  : {this.gender}");
            Console.WriteLine($"Course  : {this.course}");
        }

        public void attDosen()
        {
            Console.Write("Masukkan Nama Dosen      : ");
            this.name = Console.ReadLine();
            Console.Write("Masukkan NIK Dosen       : ");
            this.nik = Convert.ToInt32(Console.ReadLine());
        }


        public string addcourse()
        {
            Console.Write($"Masukkan Course {this.name} : ");
            this.course = Console.ReadLine();

            return this.name;
        }


        public void akhir()
        {
            Console.WriteLine("New Data Dosen ");
            Console.WriteLine();
            Console.WriteLine($"Name      :{this.name}");
            Console.WriteLine($"NIK       :{this.nik}");
            Console.WriteLine($"Course    :{this.course}");

        }

    }
}
