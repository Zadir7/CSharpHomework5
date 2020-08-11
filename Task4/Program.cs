using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            GetWorstStudents("Grades.txt");
            Console.ReadKey();
        }

        public static void GetWorstStudents(string path)
        {
            int worstStudents = 2;
            StreamReader sr = new StreamReader(path);
            int studentCount = Convert.ToInt32(sr.ReadLine());
            Student[] students = new Student[studentCount];
            double[] rates = new double[studentCount];
            for (int i = 0; i < studentCount; i++)
            {
                string[] studInfo = sr.ReadLine().Split(' ');
                string studName = $"{studInfo[0]} {studInfo[1]}";
                double avG = (Convert.ToDouble(studInfo[2]) + Convert.ToDouble(studInfo[3]) + Convert.ToDouble(studInfo[4])) / 3.0;
                rates[i] = avG;
                students[i] = new Student(i, studName, avG);
            }
            Array.Sort(rates);
            for (int i = 0; i < studentCount; i++)
            {
                for (int j = 0; j < studentCount; j++)
                {
                    if (rates[i] == students[j].averageGrade && students[j].rating == 0)
                    {
                        if (i == worstStudents && rates[i + 1] == students[j].averageGrade) { worstStudents++; }
                        students[j].rating = i + 1;
                        break;
                    }
                }
            }
            Console.WriteLine("Выводим список худших студентов:");
            for (int i = 0; i <= worstStudents; i++)
            {
                for (int j = 0; j < studentCount; j++)
                {
                    if (students[j].rating == i+1)
                    {
                        Console.WriteLine($"{students[j].name}, средний балл {students[j].averageGrade:f1}");
                    }
                }
            }
        }
        
    }
    class Student
    {
        int id;
        public string name;
        public double averageGrade;
        public int rating = 0;

        public Student(int id, string name, double averageGrade)
        {
            this.id = id;
            this.name = name;
            this.averageGrade = averageGrade;
        }
    }
}
