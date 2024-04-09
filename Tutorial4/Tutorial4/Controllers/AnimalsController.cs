﻿using Microsoft.AspNetCore.Mvc;
using Tutorial4.Database;

namespace Tutorial4.Controllers;

[ApiController]
[Route("/animals-controller")]
public class AnimalsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAnimals()
    {
        var animals = new MockDb().Animals;
        return Ok(animals);
    }
    
    [HttpGet("{id}")]
    public IActionResult GetAnimalById(int id)
    {
        return Ok(id);
    }
    
    [HttpPost]
    public IActionResult AddAnimals()
    {
        return Created();
    }
}