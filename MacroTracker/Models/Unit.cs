namespace MacroTracker.Models
{
    public class Unit
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        public ICollection<Food> Foods { get; set; }
    }
}
