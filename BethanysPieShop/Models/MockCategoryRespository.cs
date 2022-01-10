using System.Collections.Generic;

namespace BethanysPieShop.Models
{
    public class MockCategoryRespository : ICategoryRerspository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Fruit Pies", Description="All-Fruit pies"},
                new Category{CategoryId=2, CategoryName="Cheese Cakes", Description="Cheesy all the way"},
                new Category{CategoryId=3, CategoryName="Seasonal Pies", Description="Get in the mood for a season pie"}
            };
    }
}
