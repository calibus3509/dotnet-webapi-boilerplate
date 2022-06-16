namespace FSH.WebApi.Domain.DogShows;

public class DogShowClassCategory : AuditableEntity, IAggregateRoot
{
    public string Name { get; set; } = string.Empty;
    public List<Dog>? Dogs { get; set; }

    public DogShowClassCategory Update(
        string name)
    {
        if (name is not null && Name?.Equals(name) is not true) Name = name;

        return this;
    }
}