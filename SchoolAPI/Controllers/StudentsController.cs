using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SchoolAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var students = new[]{
            new {
                Name = "John Mike",
                Grade = 9.0,
                School = "CFJL"

            },
            new {
                Name = "Mark Phillips",
                Grade = 6.0,
                School = "CFJL"

            },
            new {
                Name = "David Steven",
                Grade = 8.0,
                School = "SETREM"

            },
            new {
                Name = "Peter Pan",
                Grade = 8.5,
                School = "FAHOR"

            }
            };
                            

            return Ok(students);
        }
    }
}
