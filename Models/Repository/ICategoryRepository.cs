using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPage.Models.Repository
{
    public interface ICategoryRepository
    {
        public List<Category> AllCategories { get; }
    }
}
