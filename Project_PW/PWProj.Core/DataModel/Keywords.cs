namespace PWProj.Core.DataModel
{
    public record Keywords
    {
        public Keywords(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; init; }
        public string Description { get; init; }
    }
}