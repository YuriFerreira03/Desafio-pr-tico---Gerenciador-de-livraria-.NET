﻿using Microsoft.AspNetCore.Mvc;
using MyFirstApi.Models;

namespace MyFirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserControllerlivro : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(Livro), StatusCodes.Status201Created)]
        public IActionResult Create([FromBody] Livro request)
        {
            return Created(); 
        }

        [HttpGet]
        [ProducesResponseType(typeof(Livro), StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpPut]
        [ProducesResponseType(typeof(Livro), StatusCodes.Status204NoContent)]
        public IActionResult Put([FromBody] Livro request)
        {
            return NoContent();
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Delete()
        {
            return NoContent();
        }
    }
}
