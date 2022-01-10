using System.Collections.Generic;

namespace BethanysPieShop.Models
{
    public interface ICategoryRerspository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
