namespace Domain.Objects
{
    public class PackingType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Mass { get; set; }
        public bool AvailableToMerge { get; set; }
    }
}
