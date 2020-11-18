using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    class Program
    {
           
        static void Main(string[] args)
        {
            Console.WriteLine("````````````````````````````````````````");
            Console.WriteLine("````````````````*****```````````````````");
            Console.WriteLine("Welcome to University Management System");
            Console.WriteLine("Created By Dilruba khanam jesey");
            Console.WriteLine("Developer At Kuratoli Software Solutions");
            Console.WriteLine("````````````````*****```````````````````");
            Console.WriteLine("````````````````````````````````````````");
            Course c = new Course("C#",101,3,5.0);
            Course c1 = new Course("C++", 102, 3, 5.0, 1);
            Section s1 = new Section("A","C#", 103,3, 5.0);
            Section s2 = new Section("B", "C#", 104, 3, 3.0);
            Section s3 = new Section("C", "C#", 105, 3, 3.0);
            Section s4 = new Section("D", "C#", 106, 3, 3.0);
            Section s5 = new Section("E", "C++", 107, 3, 3.0);
            Section s6= new Section("F", "Java", 108, 3, 3.0);
            Section s7 = new Section("G", "OOP1", 109, 3, 3.0);
            Section s8 = new Section("H", "Compiler", 110, 3, 3.0);
            Section s9 = new Section("I", "Grapics design", 111, 3, 3.0);
            Section s10 = new Section("J", "OOP1", 112, 3, 3.0);
            s1.SearchSection(103);
            Console.WriteLine("``````````Seacrhing For Section`````````");
            c.SearchSection(101);
            Console.WriteLine("````````````````````````````````````````");
            c.ShowInfo();
            Console.WriteLine("````````````````````````````````````````");
            s1.ShowInfo();
            Console.WriteLine("````````````````````````````````````````");
            Department d = new Department("FST");
            Department d1 = new Department("Accounting");
            Department d2 = new Department("FBA");
            Department d3 = new Department("Mechanical");
            d.AddCourse(c,c1);
            d.ShowAllCourses();
            Console.WriteLine("````````````````````````````````````````");
            Console.WriteLine("``````Adding Courses In Department``````");
            d.AddCourse(s1, s2, s3, s4,s5,s6,s7,s8,s9,s10);
            d.ShowAllCourses();
            Console.WriteLine("````````````````````````````````````````");
            Console.WriteLine("`````````Faculty Taking Courses`````````");
            Faculty f1 = new Faculty("Jennita jahangir", "20-001");
            Faculty f2 = new Faculty("Anisul karim", "11-002");
            Faculty f3= new Faculty("Masud parvez", "18-003");
            Faculty f4 = new Faculty("Shusmita ckakraborty", "18-004");
            Faculty f5 = new Faculty("Dr.kamal", "20-005");
            Teaching_Hour t = new Teaching_Hour("C", 3,d);
            Teaching_Hour t1 = new Teaching_Hour("C++ ", 3, d);
            Teaching_Hour t2 = new Teaching_Hour("Java ", 3, d);
            Teaching_Hour t3 = new Teaching_Hour("Python", 3, d);
            Teaching_Hour t4 = new Teaching_Hour("Accounting", 3, d);
            Teaching_Hour t5 = new Teaching_Hour("OOAD", 3, d);
            Teaching_Hour t6 = new Teaching_Hour("Physics", 3, d2);
            Teaching_Hour t7 = new Teaching_Hour("COA", 3, d);
            Teaching_Hour t8 = new Teaching_Hour("DC", 3, d1);
            Teaching_Hour t9 = new Teaching_Hour("DLD", 3, d1);
            Teaching_Hour t10 = new Teaching_Hour("Math", 3, d1);
            Teaching_Hour t11 = new Teaching_Hour("DEC", 3, d1);
            Teaching_Hour t12 = new Teaching_Hour("ECO", 3, d2);
           
            Console.WriteLine("``````````Faculty Information```````````");
            f1.ShowInfo();
            f1.AddCredit(t, t1, t2, t3, t4, t5,t8);
            f1.ShowAllCredits();
            Console.WriteLine("``````````Faculty Information```````````");
            f3.ShowInfo();
            f3.AddCredit(t, t1, t2, t3, t4, t5, t8,t12);
            f3.ShowAllCredits();


        
        }
    }
}
