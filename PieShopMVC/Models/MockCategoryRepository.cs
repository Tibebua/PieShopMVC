using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShopMVC.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Fruit pies", Description="all fruit pies"},
                new Category{CategoryId=2, CategoryName="Cheese Cakes", Description="all Cheese Cakes"},
                new Category{CategoryId=3, CategoryName="Seasonal Pies", Description="all Seasonal Pies"}
            };
    }
}
