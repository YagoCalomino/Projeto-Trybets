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
            User createdUser = _repository.Post(user);
            string generatedToken = new TokenManager().Generate(createdUser);
            AuthDTOResponse authResponse = new AuthDTOResponse { Token = generatedToken };
            return Created(string.Empty, authResponse);
        }
        catch (Exception e)
        {
            return BadRequest(new { error = e.Message });
        }
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] AuthDTORequest login)
    {
        try
        {
            User authenticatedUser = _repository.Login(login);
            string userToken = new TokenManager().Generate(authenticatedUser);
            AuthDTOResponse loginResponse = new AuthDTOResponse { Token = userToken };
            return Ok(loginResponse);
        }
        catch (Exception e)
        {
            return BadRequest(new { error = e.Message });
        }
    }
}