using Microsoft.EntityFrameworkCore;

namespace MacroTracker.Models
{
    public class Food
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int UnitId { get; set; } //foreign key
        public required Unit Unit { get; set; } //navigation property
        [Precision(10, 2)]
        public required Decimal Calories { get; set; }
        [Precision(10, 2)]
        public required Decimal Fat { get; set; }
        [Precision(10, 2)]
        public required Decimal Protein { get; set; }
        [Precision(10, 2)]
        public required Decimal Carbohydrates { get; set; }
    }
}
