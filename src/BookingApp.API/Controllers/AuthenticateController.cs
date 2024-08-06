﻿using BookingApp.Application.Models;
using BookingApp.Domain.Models.Jwt;
using Microsoft.AspNetCore.Mvc;

namespace BookingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {
        private readonly IJwtTokenService _jwtTokenService;
        public AuthenticateController(IJwtTokenService jwtTokenService)
        {
            _jwtTokenService = jwtTokenService;
        }

        [HttpPost]
        public IActionResult GetToken([FromBody] UserRequest user)
        {
            
            if (user.UserName == "user" && user.Password == "123") 
            {
                var token = _jwtTokenService.GenerateToken(user.UserName, "Admin");
                return Ok(new { Token = token });
            }

            return Unauthorized("Invalid credentials");
        }
    }
}