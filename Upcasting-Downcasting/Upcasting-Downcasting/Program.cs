

using DomainLayer.Models;
using Upcasting_Downcasting.Controllers;


//CalculateController calculateController = new();
//calculateController.Calculate();





StudentController controller = new();

controller.GetStudentCountByFiltered();




StudentController average = new();

average.GetStudentAverageAge();




StudentController email = new();

email.GetStudentsEmail();




StudentController address = new();

address.GetStudentsAddress();


//StudentController name = new();

//name.GetStudentsNames();



StudentController filtered = new();

filtered.GetStudentCountByFiltered();

