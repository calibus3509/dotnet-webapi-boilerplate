using Finbuckle.MultiTenant;
using FSH.WebApi.Application.Common.Events;
using FSH.WebApi.Application.Common.Interfaces;
using FSH.WebApi.Domain.Catalog;
using FSH.WebApi.Domain.Common;
using FSH.WebApi.Domain.Dogs;
using FSH.WebApi.Domain.DogShow;
using FSH.WebApi.Infrastructure.Persistence.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace FSH.WebApi.Infrastructure.Persistence.Context;

public class ApplicationDbContext : BaseDbContext
{
    public ApplicationDbContext(ITenantInfo currentTenant, DbContextOptions options, ICurrentUser currentUser, ISerializerService serializer, IOptions<DatabaseSettings> dbSettings, IEventPublisher events)
        : base(currentTenant, options, currentUser, serializer, dbSettings, events)
    {
    }

    public DbSet<Product> Products => Set<Product>();
    public DbSet<Brand> Brands => Set<Brand>();
    public DbSet<Dog> Dogs => Set<Dog>();
    public DbSet<DogBreed> DogBreeds => Set<DogBreed>();
    public DbSet<DogColor> DogColors => Set<DogColor>();
    public DbSet<DogGroup> DogGroups => Set<DogGroup>();
    public DbSet<DogTrait> DogTraits => Set<DogTrait>();
    public DbSet<DogShow> DogShows => Set<DogShow>();
    public DbSet<DogShowClass> DogShowClasses => Set<DogShowClass>();
    public DbSet<DogShowClassCategory> DogShowClassCategories => Set<DogShowClassCategory>();
    public DbSet<CivicAddress> Address => Set<CivicAddress>();
    public DbSet<Person> People => Set<Person>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.HasDefaultSchema(SchemaNames.Dsc);

        modelBuilder.Entity<Brand>().ToTable("Brands", schema: SchemaNames.Catalog);
        modelBuilder.Entity<Product>().ToTable("Products", schema: SchemaNames.Catalog);
    }
}