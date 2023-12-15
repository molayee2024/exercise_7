using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_7
{
    public class Student
    {
        public string Name { get; set; }        
        public List<Course> Courses { get; set; }    
        public double Avg { get; set; }
        public Student(string name) 
        {
            Name = name;
            Courses = new List<Course>();
            Courses.Add(new Course("۱ پیشرفته",3));
            Courses.Add(new Course("تفسیر",1));
            Courses.Add(new Course("ریاضی",2));
            Courses.Add(new Course("کارگاه",1));
            Courses.Add(new Course("زبان خارجه",2));
            Courses.Add(new Course("پیشرفته ۲",3));
            Courses.Add(new Course("شی گرایی",3));
            Courses.Add(new Course("تربیت بدنی",1));
            Courses.Add(new Course("سیستم عامل",3));
            Courses.Add(new Course("الگوریتم",3));
        }        
    }
}