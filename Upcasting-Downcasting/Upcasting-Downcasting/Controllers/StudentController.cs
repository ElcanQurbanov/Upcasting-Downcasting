using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting_Downcasting.Controllers
{
    public class StudentController
    {
        private readonly IStudentService _service;

        public StudentController()
        {
            _service = new StudentService();
        }

        public void GetStudentCountByFiltered()
        {
            Console.WriteLine(_service.GetStudentCountByFiltered());
        }

        public void GetStudentAverageAge()
        {
            Console.WriteLine(_service.GetStudentsAverageAge());
        }

        public void GetStudentsEmail()
        {
            Console.WriteLine(_service.GetStudentsEmail());
        }

        public void GetStudentsAddress()
        {
            Console.WriteLine(_service.GetStudentsAddress());
        }

        //public void GetStudentsNames()
        //{
        //    Console.WriteLine(_service.GetStudentsNames());
        //}

        public void GetStudentByNamesFiltered()
        {
            Console.WriteLine(_service.GetStudentsByNamesFiltered());
        }
    }
}
