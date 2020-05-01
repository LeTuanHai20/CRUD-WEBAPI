using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIdemo.Models;
using WebAPIdemo.Data;

namespace WebAPIdemo.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public IRepositoryStudents RepositoryStudents { get; }

        public StudentController(IRepositoryStudents repositoryStudents)
        {
            RepositoryStudents = repositoryStudents;
        }
        [HttpGet]
        public IActionResult Gets()
        {
            return Ok(RepositoryStudents.GetStudents());
        }
        [HttpGet]
        [Route("Getstudent")]
        public async Task<IActionResult> GET(int id)
        {
            var student = await RepositoryStudents.GetStudent(id);
            if(student == null)
            {
                return NotFound("no student found.");
            }
            return Ok(student);
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Student student)
        {
            if(student == null)
            {
                return NotFound("not found student need to post to sever.");
            }
            await RepositoryStudents.CreateStudent(student);

            return Ok(RepositoryStudents.GetStudents());
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
           
           await RepositoryStudents.RemoveStudent(id);

            return Ok(RepositoryStudents.GetStudents());

        }
    }
}