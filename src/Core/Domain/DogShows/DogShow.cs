namespace FSH.WebApi.Domain.DogShows;
public class DogShow : AuditableEntity, IAggregateRoot
{
    public string? Name { get; set; } = string.Empty;
    public DateTime StartDate { get; set; } = DateTime.UtcNow;
    public DateTime? EndDate { get; set; }
    public Guid? AddressId { get; set; }
    public CivicAddress? Address { get; set; }
    public double? EntryFee { get; set; }
    public double? Distance { get; set; }
    public List<DogShowClass>? Classes { get; set; }

    public DogShow()
    {

    }

    public DogShow(string? name, DateTime startDate, DateTime? endDate, Guid? addressId, double? entryFee, double? distance)
    {
        Name = name;
        StartDate = startDate;
        EndDate = endDate;
        AddressId = addressId;
        EntryFee = entryFee;
        Distance = distance;
    }

    public DogShow Update(
    string? name,
    DateTime startdate,
    DateTime? enddate,
    Guid? addressid,
    double? entryfee,
    double? distance,
    List<DogShowClass>? classes)
    {
        if (name is not null && Name?.Equals(name) is not true) Name = name;
        if (!StartDate.Equals(startdate)) StartDate = startdate;
        if (enddate is not null && EndDate?.Equals(enddate) is not true) EndDate = enddate;
        if (addressid is not null && addressid?.Equals(addressid) is not true) AddressId = addressid;
        if (entryfee is not null && EntryFee?.Equals(entryfee) is not true) EntryFee = entryfee;
        if (distance is not null && Distance?.Equals(distance) is not true) Distance = distance;
        if (classes?.Count > 0)
        {
            if (Classes == null)
            {
                Classes = new List<DogShowClass>();
                Classes.AddRange(classes);
            }
            else
            {
                Classes.Clear();
                Classes.AddRange(classes);
            }
        }

        return this;
    }
}
