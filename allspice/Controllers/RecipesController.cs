using System;
using System.Collections.Generic;
using allspice.Models;
using allspice.Services;
using Microsoft.AspNetCore.Mvc;

namespace allspice.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecipesController : ControllerBase
    {
        private readonly RecipesService _recipesService;

        public RecipesController(RecipesService recipesService)
        {
            _recipesService = recipesService;
        }

        [HttpGet]
        public ActionResult<List<Recipe>> GetAll()
        {
            try
            {
                List<Recipe> recipe = _recipesService.GetAll();
                return Ok(recipe);
            } 
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        private ActionResult<List<Recipe>> BadRequest(string message)
        {
            throw new NotImplementedException();
        }
    }
}