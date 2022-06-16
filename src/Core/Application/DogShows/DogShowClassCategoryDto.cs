

namespace FSH.WebApi.Application.DogShows;

public class DogShowClassCategoryDto : IDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<DogDto>? Dogs { get; set; }
}