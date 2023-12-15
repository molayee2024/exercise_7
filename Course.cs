using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_7
{
    public class Course
    {
        public string Name { get; set; }        
        public int Unit { get; set; }
        public double Grade { get; set; }
        public double Avg { get; set; }
        
        public Course(string name, int unit) 
        {
            this.Name = name;            
            this.Unit = unit;
        }

        public Course(string name, int unit, double grade) 
        {
            this.Name = name;
            this.Grade = grade;
            this.Unit = unit;
        }
    }
}