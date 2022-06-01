namespace FSH.WebApi.Domain.DogShow;

public class DogShowClass : AuditableEntity, IAggregateRoot
{
    public List<DogShowClassCategory>? Categories { get; set; }
    public string? Gender { get; set; } = string.Empty;
    public Guid? BreedId { get; set; }
    public DogBreed? Breed { get; set; }
    public int? RingNumber { get; set; }
    public DateTime? StartTime { get; set; }
    public Guid? JudgeId { get; set; }
    public Person? Judge { get; set; }

    public DogShowClass Update(
        List<DogShowClassCategory>? categories,
        string? gender,
        Guid? breedid,
        int? ringnumber,
        DateTime? starttime,
        Guid? judgeid)
    {
        if (categories?.Count > 0)
        {
            if (Categories == null)
            {
                Categories = new List<DogShowClassCategory>();
                Categories.AddRange(categories);
            }
            else
            {
                Categories.Clear();
                Categories.AddRange(categories);
            }
        }
        if (gender is not null && Gender?.Equals(gender) is not true) Gender = gender;
        if (breedid is not null && BreedId?.Equals(breedid) is not true) BreedId = breedid;
        if (ringnumber is not null && RingNumber?.Equals(ringnumber) is not true) RingNumber = ringnumber;
        if (starttime is not null && StartTime?.Equals(starttime) is not true) StartTime = starttime;
        if (judgeid is not null && JudgeId?.Equals(judgeid) is not true) JudgeId = judgeid;

        return this;
    }
}