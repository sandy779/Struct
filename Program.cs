using System;

namespace Struct
{
    public struct Student
    {
        public int StudentId;
        public int RgistrationId;
        public string Studname;
        public string course;

    }
    
   
    class Program
    {
        
        static void Main(string[] args)
        {
            Student s1;
            Console.WriteLine("Enter StudentId:");
            s1.StudentId =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter Registrationid:");
            s1.RgistrationId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Name:");
            s1.Studname = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Course in which you want to Enroll:");
            s1.course = Convert.ToString(Console.ReadLine());

            Console.WriteLine("==========================================================");
            Console.WriteLine(s1.StudentId);
            Console.WriteLine(s1.RgistrationId);
            Console.WriteLine(s1.Studname);
            Console.WriteLine(s1.course);


        }
    }
}
