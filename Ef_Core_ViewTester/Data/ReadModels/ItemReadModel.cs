namespace Ef_Core_ViewTester.Data.ReadModels
{
    public class ItemReadModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;
    }
}
