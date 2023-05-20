﻿using AutoMapper.Features;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RadVolontera.Models.Account;
using RadVolontera.Services.Services;

namespace RadVolontera.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class AccountController : BaseApiController
    {
        private readonly AccountService _accountService;

        public AccountController(AccountService accountService, IServiceProvider provider) : base(provider)
        {
            _accountService = accountService;
        }


        [HttpPost("register")]
        [Consumes("application/json")]
        public async Task<ActionResult<UserResponse>> Register(RegisterRequest request)
        {
            
            var userResponse = await _accountService.Register(new RegisterRequest
            {
                UserName = request.UserName,
                Password = request.Password,
                Email = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Gender = request.Gender,
                PhoneNumber = request.PhoneNumber,
                BirthDate = request.BirthDate,
                UserType = request.UserType,

            });

            return Ok(userResponse);
        }


        [AllowAnonymous]
        [HttpPost("authenticate")]
        [Consumes("application/json")]
        public async Task<ActionResult<AuthenticationResponse>> Authenticate(AuthenticationRequest request)
        {
            return Ok(await _accountService.Authenticate(request.Username, request.Password, string.Empty));
        }
    }
}
