using Lab2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class UsalController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var doctorHospital = new DoctorHospital()
            {
                Hospital = new Hospital()
                {
                    Name = "My hospital",
                    Address = "LLLlll"
                },
                Doctor = GetDoctorList()
            };
            return View(doctorHospital);
        }

        [HttpGet("/Usal/DocInfo/{Name}")]
        public IActionResult ViewDoctorDetailsByName(string Name)
        {
            Doctor doctor = GetDoctorList().Find(x => x.Name == Name) ?? new Doctor();
            return View(doctor);
        }


        private List<Doctor> GetDoctorList()
        {
            return new List<Doctor>
            {
                new Doctor() { Name = "ali", Phone="123"},
                new Doctor() { Name = "jad", Phone="456"},
                new Doctor() { Name = "noor", Phone="789"}
            };
        }

      
    }
}
