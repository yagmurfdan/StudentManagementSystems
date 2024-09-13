using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    public class StudentManager
    {
        public StudentManager() { }


        public void Add(Student student)
        {
            // db ye yazılabilir
            if (student.isim.Length >= 2 && student.soyisim.Length >= 2)
            {
                if (student.bilinenDiller.Length >= 1)
                {
                    if (student.yas < 35 && student.yas > 18)
                    {
                        if (student.no != null && student.no.StartsWith("+905"))
                        {
                            if (student.semt != null)
                            {
                                Console.WriteLine("Student eklendi : " + student.isim);
                            }
                            else
                            {
                                Console.WriteLine("Semt boş olamaz");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Numara hatalı");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Yas yeterli Değil");
                    }
                }
                else
                {
                    Console.WriteLine("Programlama dilleri bilgi sayısı 1 den küçük");
                }
            }
            else
            {
                Console.WriteLine("Student ismi veya soyismi karakter sayısı eksik");
            }
        }


        public void Update(Student student, string yeniisim, string yenisoyisim)
        {
            // db ye yazılabilir
            if (yeniisim.Length >= 2 && yenisoyisim.Length >= 2)
            {
                if (student.bilinenDiller.Length >= 1)
                {
                    if (student.yas < 35 && student.yas > 18)
                    {
                        Console.WriteLine("Student eklendi : " + student.isim);
                    }
                    else
                    {
                        Console.WriteLine("Yas yeterli Değil");
                    }
                }
                else
                {
                    Console.WriteLine("Programlama dilleri bilgi sayısı 1 den küçük");
                }
            }
            else
            {
                Console.WriteLine("Student ismi veya soyismi karakter sayısı eksik");
            }
        }


        public void Delete(Student student)
        {
            // db ye yazılabilir
            Console.WriteLine("Student silindi: " + student.isim);
        }
    }
}