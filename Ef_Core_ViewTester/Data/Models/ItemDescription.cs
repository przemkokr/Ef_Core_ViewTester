namespace Ef_Core_ViewTester.Data.Models
{
    public class ItemDescription
    {
        public int Id { get; set; }

        public int ItemId { get; set; }

        public string Description { get; set; } = default!;
    }
}
