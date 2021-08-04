using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentInfo.Context;
using StudentInfo.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentInfo.Controllers
{
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        readonly StudentContext StudentDetails;
        public StudentController(StudentContext studentContext)
        {
            StudentDetails = studentContext;
        }
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            var data = StudentDetails.Student.ToList();
            return data;
        }



        // POST api/<controller>
        [HttpPost]
        public IActionResult Post([FromBody] Student obj)
        {
            var data = StudentDetails.Student.Add(obj);
            StudentDetails.SaveChanges();
            return Ok();
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Student obj)
        {
            var data = StudentDetails.Student.Update(obj);
            StudentDetails.SaveChanges();
            return Ok();
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var data = StudentDetails.Student.Where(a => a.StudentID == id).FirstOrDefault();
            StudentDetails.Student.Remove(data);
            StudentDetails.SaveChanges();
            return Ok();

        }
    }
}
