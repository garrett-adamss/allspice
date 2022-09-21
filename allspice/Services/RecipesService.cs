using System;
using System.Collections.Generic;
using allspice.Models;
using allspice.Repositories;

namespace allspice.Services
{
    public class RecipesService
    {
        private readonly RecipesRepository _recipeRepo;

        public RecipesService(RecipesRepository recipesRepo)
        {
            _recipeRepo = recipesRepo;
        }

        internal List<Recipe> GetAll()
        {
            return _recipeRepo.GetAll();
        }
    }
}