using dependency.Model;
using dependency.Service;
using Microsoft.AspNetCore.Mvc;

namespace dependency.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var res = _studentService.Get();
            return Ok(res);
        }
        [HttpPost]
        public IActionResult Add(Students Addstudent)
        {
            var res = _studentService.Add(Addstudent);
            return Ok(res);
        }
        [HttpPut]
        public IActionResult Update(Students Newstudent)
        {
            var res = _studentService.Update(Newstudent);
            return Ok(res);
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        { 
            var res = _studentService.Delete(id);  
            return Ok(res);
        }
        [HttpPut ("Login")]
        public IActionResult Login(string name, string password) 
        {
            var res =  _studentService.Login(name, password);
            return Ok(res);
        }
    }
}
