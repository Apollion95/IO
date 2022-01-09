﻿using Infrastructure.Repository;
using Ksiegarnia.Dtos;
using Ksiegarnia.Helpers;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections;
using System.Collections.Generic;



namespace Ksiegarnia.Controllers
{
    [Route("home")]
    [ApiController]
    public class HomeController : Controller
    {
        private readonly IUserRepository _repository;
        private readonly JwtService _jwtService;

        public HomeController(IUserRepository repository, JwtService jwtService)
        {
            _repository = repository;
            _jwtService = jwtService;
        }
        [HttpPost("login")]
        public IActionResult Login(LoginDto dto)
        {
            var user = _repository.GetUserByEmail(dto.Email);

            if (user == null) return BadRequest(new { message = "Nie poprawne dane" });

            if (!BCrypt.Net.BCrypt.Verify(dto.Password, user.Password))
            {
                return BadRequest(new { message = "Nie poprawne dane" });
            }

            var jwt = _jwtService.Generate(user.Id);

            Response.Cookies.Append("jwt", jwt, new CookieOptions { HttpOnly = true });

            return Ok(new { message = "succes" });
        }
        [HttpGet("user")]
        public IActionResult GetUser()
        {
            try
            {
                var jwt = Request.Cookies["jwt"];
                var token = _jwtService.Verify(jwt);
                int userId = int.Parse(token.Issuer);
                var user = _repository.GetUserById(userId);

                return Ok(user);
            }
            catch (Exception)
            {
                return Unauthorized();
            }
        }
        [HttpPost("logout")]
        public IActionResult Logout()
        {
            Response.Cookies.Delete("jwt");

            return Ok(new { message = "succes" });
        }
    }
}

    }
}



