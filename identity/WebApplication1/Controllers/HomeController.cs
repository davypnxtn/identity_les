using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.interfaces;
using Microsoft.AspNetCore.Mvc;
using Model;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentService service;

        public HomeController(IStudentService _service)
        {
            service = _service;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Student> students = service.GetStudents();
            return View(students);
        }
    }
}
