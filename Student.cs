using System;
using System.Collections.Generic;
using System.Text;

namespace myproject
{
    class Student
    {
        public String name;
        public double grade;

        public Student() { }
        public Student(String name, double grade) {
            this.name = name;
            this.grade = grade;
            
        }

        public void print() {
            Console.WriteLine("student name is {0}" + " and student grade is {1}", name,grade);
            if (grade>60) {
                Console.WriteLine("student has passed");
            }
            else
            {
                Console.WriteLine("student has Failed ");
            }
        }
            
    }
}
