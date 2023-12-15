using System;
namespace exercise_7
{
    class Program
    {
        static int N = 5;        
        static double totalAvg = 0;
        static List<Student> students = new List<Student>();
        static List<Course> Courses = new List<Course>();            
        static void Main(string[] args)
        {            
            InitCourses(Courses);
            for (int i = 0; i < N; i++)
            {
                Student s1 = new Student("s"+(i+1));             
                for (int j = 0; j < s1.Courses.Count; j++)
                {                    
                    Random rnd = new Random();
                    double rDouble = rnd.NextDouble() * 20;
                    s1.Courses[j].Grade = Math.Ceiling(rDouble);
                    System.Console.WriteLine(s1.Courses[j].Grade);
                }
                students.Add(s1);
            }
            ComputeAvgOfEachStudent();

            while (true)
            {                                                
                System.Console.WriteLine("Menu");
                System.Console.WriteLine("1- Student Avg");
                System.Console.WriteLine("2- Total class Avg");
                System.Console.WriteLine("3- Course Avg");
                System.Console.WriteLine("4- Show Primes");
                System.Console.WriteLine("5- Grading");
                System.Console.WriteLine("6- Exit");
                System.Console.WriteLine("------------");
                System.Console.WriteLine("Select From Menu");
                string str = System.Console.ReadLine();
                int menu = int.Parse(str);

                switch (menu)
                {
                    case 1:
                        ComputeAvgOfEachStudent();
                        break;
                    case 2:
                        ComputeTotalClassAvg();
                        break;
                    case 3:
                        ComputeCourseAvg();
                        break;
                    case 4:
                        ShowPrimes();
                        break;
                    case 5:
                        Grading();
                        break;
                    case 6:
                        return;                                               
                    default: 
                        return;
                }
            }
        }

        static void Grading(){
            for (int j = 0; j < N; j++)
            {
                double avg = students[j].Avg;
                System.Console.WriteLine(students[j].Name);
                if (avg <= 20 && avg > 17)
                {
                    System.Console.WriteLine("A");
                }
                else if (avg <= 17 && avg > 15)
                {                    
                    System.Console.WriteLine("B");
                }
                else if (avg <= 15 && avg > 13)
                {                    
                    System.Console.WriteLine("C");
                }
                else if (avg <= 13 && avg > 10)
                {                    
                    System.Console.WriteLine("D");
                }
                else if (avg <= 10 && avg > 7)
                {                    
                    System.Console.WriteLine("E");
                }
                else if (avg <= 7 && avg > 3)
                {                    
                    System.Console.WriteLine("F");
                }
                else if (avg <= 3 && avg > 0)
                {                    
                    System.Console.WriteLine("G");
                }
                else
                {                    
                    System.Console.WriteLine("H");
                }
            }                                    
        }

        static void InitCourses(List<Course> courses){
            courses.Add(new Course("۱ پیشرفته" , 3));
            courses.Add(new Course("تفسیر" , 1));
            courses.Add(new Course("ریاضی" , 2));
            courses.Add(new Course("کارگاه" , 1));
            courses.Add(new Course("زبان خارجه" , 2));
            courses.Add(new Course("پیشرفته ۲" , 3));
            courses.Add(new Course("شی گرایی" , 3));
            courses.Add(new Course("تربیت بدنی" , 1));
            courses.Add(new Course("سیستم عامل" , 3));
            courses.Add(new Course("الگوریتم" , 3));
        }

        static void ComputeAvgOfEachStudent() {
            
            for (int j = 0; j < N; j++)
            {
                int sumOfUnits = 0;
                double sum = 0;
                Student s1 = students[j];
                for (int i = 0; i < s1.Courses.Count; i++)
                {
                    sumOfUnits += s1.Courses[j].Unit;
                    sum += (s1.Courses[j].Grade * s1.Courses[j].Unit);                                                                             
                }   
                students[j].Avg = sum / sumOfUnits;
                System.Console.WriteLine(students[j].Avg);
            }                                    

            for (int i = 0; i < N; i++)
            {
                System.Console.Write(students[i].Name + " : " + students[i].Avg);
                System.Console.WriteLine();
            }
        }

        static void ComputeTotalClassAvg() {            
            double sum = 0;
            for (int i = 0; i < students.Count; i++)
            {   
                sum += students[i].Avg;
            }            
            System.Console.WriteLine("Total Avg is : " + sum/N); 
        }

        static void ComputeCourseAvg() {                        
            double sum = 0;
            for (int i = 0; i < students.Count; i++)
            {                
                for (int j = 0; j < students[i].Courses.Count; j++)
                {
                    Courses[j].Avg += (double)students[i].Courses[j].Grade;
                }                
            }            
            for (int i = 0; i < Courses.Count; i++)
            {                
                Courses[i].Avg /= (double)N;
                System.Console.WriteLine(Courses[i].Name + " : " + Courses[i].Avg);
            }
            
        }

        static void ShowPrimes(){
            for (int i = 0; i < students.Count; i++)
            {
                System.Console.WriteLine("student name : " + students[i].Name);
                for (int j = 0; j < students[i].Courses.Count; j++)
                {       
                    if (IsPrime(students[i].Courses[j].Grade))
                    {
                     System.Console.WriteLine(students[i].Courses[j].Name + " : " + students[i].Courses[j].Grade);   
                    }                    
                }
            }
        }

        static bool IsPrime(double number){
            if (number == 0)
            {
                return true;
            }
            if (number == 1)
            {
                return true;
            }
            if (number == 2)
            {
                return true;
            }
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }                
            }

            return true;
        }
    }

}