using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    public class Student
    {
        public string isim;
        public string soyisim;
        public int yas;
        public string alan;
        public string takim;
        public string[] bilinenDiller;
        public string no;
        public bool yabancıdil;
        public string semt;

        public Student() { }

        public Student(string isim, string soyisim, int yas, string alan, string takim, string[] bilinenDiller, string no, bool yabancıdil, string semt)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            this.yas = yas;
            this.alan = alan;
            this.takim = takim;
            this.bilinenDiller = bilinenDiller;
            this.no = no;
            this.yabancıdil = yabancıdil;
            this.semt = semt;
        }


        public string ToString()
        {
            return $"isim : {isim}, Soyisim: {soyisim}, yas: {yas}," +
            $"Alan : {alan}, Takım: {takim}," +
            $"semt: {semt}";
        }

    }
}