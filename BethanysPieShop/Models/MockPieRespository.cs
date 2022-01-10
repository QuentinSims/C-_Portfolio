using System.Collections.Generic;
using System.Linq;

namespace BethanysPieShop.Models
{
    public class MockPieRespository : IPieRepository
    {
        private readonly ICategoryRerspository categoryRerspository = new MockCategoryRespository();
        public IEnumerable<Pie> AllPies =>
            new List<Pie>
            {
                new Pie {PieId = 1, Name="Strawberry Pie", Price=15.95M, ShortDescription="", LongDescritpion=""},
                new Pie {PieId = 2, Name="Chesse cake", Price=15.95M, ShortDescription="", LongDescritpion=""},
                new Pie {PieId = 3, Name="Rhubarb Pie", Price=15.95M, ShortDescription="", LongDescritpion=""},
                new Pie {PieId = 4, Name="Pumpkin Pie", Price=15.95M, ShortDescription="", LongDescritpion=""}
            };
        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public Pie GetPieById(int pieId)
        {
            return AllPies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}
