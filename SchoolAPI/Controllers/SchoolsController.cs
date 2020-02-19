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
    public class SchoolsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var school = new[]{
            new {
                Name = "CFJL",
                Level = "High School",
                Location = "Horizontina"

            },
            new {
                Name = "FAHOR",
                Level = "University",
                Location = "Horizontina"

            },
            new {
                Name = "SETREM",
                Level = "University",
                Location = "Tres de Maio"

            },
            new {
                Name = "UFRGS",
                Level = "University",
                Location = "Porto Alegre"

            }
            };
                            

            return Ok(school);
        }
    }
}
