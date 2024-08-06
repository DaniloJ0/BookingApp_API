﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class testController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello World");
        }   
    }
}
