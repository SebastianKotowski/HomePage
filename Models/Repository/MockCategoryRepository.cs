using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPage.Models.Repository
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public List<Category> AllCategories =>
            new List<Category>
            {
                new Category { Id = 1, Name = ".NET", Description = "feature fron .Net"},
                new Category { Id = 2, Name = "C#", Description = "feature fron C#"},
                new Category { Id = 3, Name = "ASP.NET", Description = "feature fron ASP.NET"}
            };
    }
}
