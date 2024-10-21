using BlogSite.Models.Dtos.Posts.Requests;
using BlogSite.Service.Abstratcts;
using BlogSite.Service.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogSite.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController(IUserService _userService) : ControllerBase
{
    [HttpGet("getallUser")]
    public IActionResult GetAll()
    {
        var result = _userService.GetAll();
        return Ok(result);
    }

    [HttpPost("addUser")]
    public IActionResult Add([FromBody] CreateUserRequest dto)
    {
        var result = _userService.Add(dto);
        return Ok(result);
    }

    [HttpGet("getUserbyid/{id}")]
    public IActionResult GetById([FromRoute] long id)
    {
        var result = _userService.GetById(id);
        return Ok(result);
    }

    [HttpDelete("deleteUser")]
    public IActionResult Delete([FromQuery] long id)
    {
        var result = _userService.Remove(id);
        return Ok(result);
    }

    [HttpPut("updateUser")]
    public IActionResult Update([FromBody] UpdateUserRequest dto)
    {
        var result = _userService.Update(dto);
        return Ok(result);
    }
}
