using FSH.WebApi.Domain.DogShows;

namespace FSH.WebApi.Application.DogShows;
public class CreateDogShowRequest : IRequest<Guid>
{
    public string? Name { get; set; } = string.Empty;
    public DateTime StartDate { get; set; } = DateTime.UtcNow;
    public DateTime? EndDate { get; set; }
    public Guid? AddressId { get; set; }
    public CivicAddress? Address { get; set; }
    public double? EntryFee { get; set; }
    public double? Distance { get; set; }

}

public class CreateDogShowRequestHandler : IRequestHandler<CreateDogShowRequest, Guid>
{
    // Add domain Events automatically by using IRepositoryWithEvents
    private readonly IRepositoryWithEvents<DogShow> _repository;

    public CreateDogShowRequestHandler(IRepositoryWithEvents<DogShow> repository) => _repository = repository;

    public async Task<Guid> Handle(CreateDogShowRequest request, CancellationToken cancellationToken)
    {
        var dogshow = new DogShow(
            request.Name,
            request.StartDate,
            request.EndDate,
            request.AddressId,
            request.EntryFee,
            request.Distance);

        await _repository.AddAsync(dogshow, cancellationToken);

        return dogshow.Id;
    }
}
