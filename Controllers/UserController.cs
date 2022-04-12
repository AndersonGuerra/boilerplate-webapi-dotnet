using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Interfaces;
using WebAPI.Models;

namespace WebAPI.Controllers;
[ApiController]
[Route("user")]
public class UserController : ControllerBase
{
    private readonly IUserRepository _userRepository;
    private readonly string defaultRoute = "user";
    public UserController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    [HttpGet]
    [Route("{id}")]
    public ActionResult GetUser(int id)
    {
        User? user = _userRepository.GetUser(id);
        if (user is not null) return Ok(user);
        return NotFound(new { message = "Usuário não encontrado" });
    }
    [HttpGet]
    [Route("")]
    public ActionResult GetUsers()
    {
        List<User> users = _userRepository.GetUsers();
        return Ok(users);
    }
    [HttpPost]
    [Route("")]
    public ActionResult CreateUser(User user)
    {
        _userRepository.CreateUser(user);
        return Ok(user);
    }
    [HttpPatch]
    public ActionResult UpdateUser(User user)
    {
        return Ok();
    }
}

