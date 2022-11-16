namespace Ef_Core_ViewTester.Data.Models
{
    public class Item
    {
        public int Id { get; set; }

        public string Name { get; set; } = default!;

        public string AlternateName { get; set; } = default!;
    }
}
