using System;

namespace ConsoleApp.Intheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Aqil";
            student.SurName = "Abbasov";

            Doctor doctor = new Doctor();
            doctor.Name = "Abbas";
            doctor.SurName = "Huseynli";

            doctor.Salary = 200;

            student.Talk();
            doctor.Talk();
            
        }
    }
}
