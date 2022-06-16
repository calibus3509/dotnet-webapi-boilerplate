namespace FSH.WebApi.Application.DogShows;
internal class DogShowDto : IDto
{
    public Guid Id { get; set; }
    public string? Name { get; set; } = string.Empty;
    public DateTime StartDate { get; set; } = DateTime.UtcNow;
    public DateTime? EndDate { get; set; }
    public Guid? AddressId { get; set; }
    public CivicAddress? Address { get; set; }
    public double? EntryFee { get; set; }
    public double? Distance { get; set; }
    public List<DogShowClassDto>? Classes { get; set; }
}
