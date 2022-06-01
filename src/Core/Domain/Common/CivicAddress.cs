namespace FSH.WebApi.Domain.Common;
public class CivicAddress : AuditableEntity, IAggregateRoot
{
    public string? AddressLine1 { get; set; } = string.Empty;
    public string? AddressLine2 { get; set; } = string.Empty;
    public string? Building { get; set; } = string.Empty;
    public string? City { get; set; } = string.Empty;
    public string? CountryRegion { get; set; } = string.Empty;
    public string? FloorLevel { get; set; } = string.Empty;
    public string? PostalCode { get; set; } = string.Empty;
    public string? StateProvince { get; set; } = string.Empty;

    public CivicAddress Update(
        string? addressline1,
        string? addressline2,
        string? building,
        string? city,
        string? countryregion,
        string? floorlevel,
        string? postalcode,
        string? stateprovice)
    {
        if (addressline1 is not null && AddressLine1?.Equals(addressline1) is not true) AddressLine1 = addressline1;
        if (addressline2 is not null && AddressLine2?.Equals(addressline2) is not true) AddressLine2 = addressline2;
        if (building is not null && Building?.Equals(building) is not true) Building = building;
        if (city is not null && City?.Equals(city) is not true) City = city;
        if (countryregion is not null && CountryRegion?.Equals(countryregion) is not true) CountryRegion = countryregion;
        if (floorlevel is not null && FloorLevel?.Equals(floorlevel) is not true) FloorLevel = floorlevel;
        if (postalcode is not null && PostalCode?.Equals(postalcode) is not true) PostalCode = postalcode;
        if (stateprovice is not null && StateProvince?.Equals(stateprovice) is not true) StateProvince = stateprovice;

        return this;
    }
}
