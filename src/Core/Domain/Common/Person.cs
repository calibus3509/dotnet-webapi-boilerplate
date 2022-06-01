namespace FSH.WebApi.Domain.Common;
public class Person : AuditableEntity, IAggregateRoot
{
    public string? Title { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string? MiddleName { get; set; } = string.Empty;
    public string? LastName { get; set; } = string.Empty;
    public Guid? AddressId { get; set; }
    public CivicAddress? Address { get; set; }

    public Person Update(
        string? title,
        string? firstname,
        string? middlename,
        string? lastname,
        Guid? addressid)
    {
        if (title is not null && Title?.Equals(title) is not true) Title = title;
        if (firstname is not null && FirstName?.Equals(firstname) is not true) FirstName = firstname;
        if (middlename is not null && MiddleName?.Equals(middlename) is not true) MiddleName = middlename;
        if (lastname is not null && LastName?.Equals(lastname) is not true) LastName = lastname;
        if (addressid is not null && AddressId?.Equals(addressid) is not true) AddressId = addressid;

        return this;
    }
}
