using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Onion.Domain.Entities;
using Onion.Domain.Services;

namespace Onion.UI.WebApi.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentsService _dbService;
        public StudentsController(IStudentsService service)
        {
            _dbService = service;
        }

        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(_dbService.GetStudents());
        }

        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            if (_dbService.AddStudent(student)) return Ok();

            return BadRequest();
        }
    }
}