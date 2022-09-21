using System.Collections.Generic;
using System.Data;
using allspice.Models;
using Dapper;

namespace allspice.Repositories
{
    public class RecipesRepository : IRepo<Recipe, int>
    {
        private readonly IDbConnection _db;
        public RecipesRepository(IDbConnection db)
        {
            _db = db;
        }

        public Recipe Create(Recipe body)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Recipe GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Recipe Update(Recipe update)
        {
            throw new System.NotImplementedException();
        }

        internal List<Recipe> GetAll()
        {
            string sql = @"
            SELECT
            r.*,
            a.*
            FROM recipes r
            JOIN accounts a ON a.id = r.creatorId;
            ";

            List<Recipe> recipes = _db.Query<Recipe, Profile, Recipe>(sql, (recipe, profile) =>
            {
                recipe.Creator = profile;
                return recipe;
            }).ToList();
            return recipes;
        }

        List<Recipe> IRepo<Recipe, int>.GetAll()
        {
            throw new System.NotImplementedException();
        }

        // internal RecipeRepository GetById(int id)
        // {
        //     string sql = @"
        //     SELECT * FROM recipe
        //     WHERE id=@id
        //     ";
        // }
    }
}