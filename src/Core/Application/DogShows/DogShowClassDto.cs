namespace FSH.WebApi.Application.DogShows;

public class DogShowClassDto : IDto
{
    public Guid Id { get; set; }
    public List<DogShowClassCategoryDto>? Categories { get; set; }
    public string? Gender { get; set; } = string.Empty;
    public Guid? BreedId { get; set; }
    public DogBreed? Breed { get; set; }
    public int? RingNumber { get; set; }
    public DateTime? StartTime { get; set; }
    public Guid? JudgeId { get; set; }
    public Person? Judge { get; set; }
}