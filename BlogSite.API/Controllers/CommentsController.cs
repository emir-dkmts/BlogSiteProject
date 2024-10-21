﻿using BlogSite.Models.Dtos.Posts.Requests;
using BlogSite.Service.Abstratcts;
using BlogSite.Service.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogSite.API.Controllers;
[Route("api/[controller]")]
[ApiController]

public class CommentsController(ICommentService _commentService) : ControllerBase
{

    [HttpGet("getallComments")]
    public IActionResult GetAll()
    {
        var result = _commentService.GetAll();
        return Ok(result);
    }

    [HttpPost("addComment")]
    public IActionResult Add([FromBody] CreateCommentRequest dto)
    {
        var result = _commentService.Add(dto);
        return Ok(result);
    }

    [HttpGet("getCommentbyid/{id}")]
    public IActionResult GetById([FromRoute] Guid id)
    {
        var result = _commentService.GetById(id);
        return Ok(result);
    }

    [HttpDelete("deleteComment")]
    public IActionResult Delete([FromQuery] Guid id)
    {
        var result = _commentService.Remove(id);
        return Ok(result);
    }

    [HttpPut("updateComment")]
    public IActionResult Update([FromBody] UpdateCommentRequest dto)
    {
        var result = _commentService.Update(dto);
        return Ok(result);
    }

}