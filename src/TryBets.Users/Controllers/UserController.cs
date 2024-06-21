using System;
using Microsoft.AspNetCore.Mvc;
using TryBets.Users.Repository;
using TryBets.Users.Services;
using TryBets.Users.Models;
using TryBets.Users.DTO;

namespace TryBets.Users.Controllers;

[Route("[controller]")]
public class UserController : Controller
{
    private readonly IUserRepository _repository;
    public UserController(IUserRepository repository)
    {
        _repository = repository;
    }

    [HttpPost("signup")]
    public IActionResult Post([FromBody] User user)
    {
        try
        {
            var newUser = _repository.Post(user);
            var tokenManager = new TokenManager();
            var token = tokenManager.Generate(newUser);
            var authResponse = new AuthDTOResponse { Token = token };
            return Created("", authResponse);
        }
        catch (Exception ex)
        {
            var errorResponse = new { message = ex.Message };
            return BadRequest(errorResponse);
        }
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] AuthDTORequest login)
    {
        try
        {
            var userFound = _repository.Login(login);
            var tokenManager = new TokenManager();
            var token = tokenManager.Generate(userFound);
            var authResponse = new AuthDTOResponse { Token = token };
            return Ok(authResponse);
        }
        catch (Exception ex)
        {
            var errorResponse = new { message = ex.Message };
            return BadRequest(errorResponse);
        }
    }
}