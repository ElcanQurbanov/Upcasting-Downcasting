using DomainLayer.Models;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class StudentService : IStudentService
    {
        public int GetStudentCountByFiltered()
        {
            var student = GetAll();

            int count = 0;

            foreach (var item in student)
            {
                count++;
            }

            return count;
        }


        public double GetStudentsAverageAge()
        {
            var student = GetAll();

            double sum = 0;

            double result = 0;

            foreach (var item in student)
            {
                sum+= item.Age;
                
            }

            return sum /= student.Length;
        }


        public Student[] GetStudentsEmail()
        {
            var students = GetAll();
            var result = new Student[students.Length];

            int count = 0;
            bool check = false;
            foreach (var item in students) 
            {
                if (item.Email.StartsWith("c"))
                {
                    result[count] = item;
                    count++;
                    check = true;
                }
            }
            return result;
         
        }


        public Student[] GetStudentsAddress()
        {
            Student[] students = GetAll();
            Student[] result = new Student[students.Length];

            int count = 0;
            bool check = false;
            foreach (var item in students)
            {
                if (item.Address.Contains("Ehmedli"))
                {
                    result[count] = item;
                    count++;
                    check = true;
                }
            }
            return result;
            
        }


        public Student[] GetStudentsNames(string studentName)
        {
            Student[] students = GetAll();
            Student[] result = new Student[students.Length];

            int count = 0;
            bool contains = false;

            foreach (var item in students)
            {
                if (item.Name.ToLower() == studentName.ToLower() || item.Surname.ToLower() == studentName.ToLower())
                {
                    result[count] = item;
                    count++;
                    contains = true;
                }
            }
            return result;
        }


        public int GetStudentsByNamesFiltered()
        {
            var students = GetAll();
            int count = 0;

            foreach (var item in students)
            {
                if (item.Name == "Shaiq")
                {
                    count++;
                }
            }
            return count;
        }




        private Student[] GetAll()
        {

            Student s1 = new Student
            {
                Id = 1,
                Name = "Shaiq",
                Surname = "Kazimov",
                Email = "shaiq@code.edu.az",
                Age = 25,
                Education = "Code Academy",
                Address = "Sedmoy"
            };

            Student s2 = new Student
            {
                Id = 2,
                Name = "Pervin",
                Surname = "Rehimli",
                Email = "pervin@code.edu.az",
                Age = 25,
                Education = "Code Academy",
                Address = "baki"
            };

            Student s3 = new Student
            {
                Id = 3,
                Name = "Aqshin",
                Surname = "Hummetov",
                Email = "aqshin@code.edu.az",
                Age = 27,
                Education = "Code Academy",
                Address = "Sumqayit"
            };

            Student s4 = new Student
            {
                Id = 4,
                Name = "Cavid",
                Surname = "Ismayilzade",
                Email = "cavid@code.edu.az",
                Age = 22,
                Education = "Code Academy",
                Address = "Ehmedli"


            };

            Student[] student = { s1, s2, s3, s4 };

            return student;
        }


       

        
    }
}


  
       
        
