﻿using Caregiver.Dtos;
using Caregiver.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Caregiver.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthController : ControllerBase
	{
		private IUserService _userService;
		public AuthController(IUserService userService)
		{
			_userService = userService;
		}

		[HttpPost("login")]
		public async Task<IActionResult> Login([FromBody] LoginReqDTO model)
		{
			var LoginRes = await _userService.Login(model);
			if (LoginRes.User == null || string.IsNullOrEmpty(LoginRes.Token))
			{

				return BadRequest(new { message = "Username or Password are Incorrect" });

			}


			return Ok(LoginRes);
		}

		[HttpPost("CustomerRegister")]
		public async Task<IActionResult> RegisterAsync([FromBody] RegisterCustomerDTO model)
		{

			if (ModelState.IsValid)
			{
				var result = await _userService.RegisterUserAsync(model);
				if (result.IsSuccess)
					return Ok(result); // Status Code: 200
				return BadRequest(result);
			}
			return BadRequest("Some properties are not valid"); // Status code: 400
		}

        [HttpPost("CaregiverRegister")]

        public async Task<IActionResult> RegisterAsync([FromForm] RegisterCaregiverDTO model)
        {
           

            if (ModelState.IsValid)
            {
                var result = await _userService.RegisterCaregiverAsync(model);
                if (result.IsSuccess)
                    return Ok(result); // Status Code: 200
                return BadRequest(result);
            }
            return BadRequest("Some properties are not valid"); // Status code: 400
        }

    }
}
