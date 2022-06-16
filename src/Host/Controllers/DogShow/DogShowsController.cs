using FSH.WebApi.Application.DogShows;

namespace FSH.WebApi.Host.Controllers.Dog;

public class DogShowsController : VersionedApiController
{    
    //[HttpGet("{id:guid}")]
    //[MustHavePermission(FSHAction.View, FSHResource.DogShows)]
    //[OpenApiOperation("Get dog show by Id.", "")]
    //public Task<DogShowDto> GetAsync(Guid id)
    //{
    //    //return Mediator.Send(new GetDogShowRequest(id));
    //}

    [HttpPost]
    [MustHavePermission(FSHAction.Create, FSHResource.DogShows)]
    [OpenApiOperation("Create a new Dog Show.", "")]
    public Task<Guid> CreateAsync(CreateDogShowRequest request)
    {
        return Mediator.Send(request);
    }

    //[HttpPut("{id:guid}")]
    //[MustHavePermission(FSHAction.Update, FSHResource.Dogs)]
    //[OpenApiOperation("Update a Dog.", "")]
    //public async Task<ActionResult<Guid>> UpdateAsync(UpdateDogRequest request, Guid id)
    //{
    //    return id != request.Id
    //        ? BadRequest()
    //        : Ok(await Mediator.Send(request));
    //}

    //[HttpDelete("{id:guid}")]
    //[MustHavePermission(FSHAction.Delete, FSHResource.Dogs)]
    //[OpenApiOperation("Delete a dog.", "")]
    //public Task<Guid> DeleteAsync(Guid id)
    //{
    //    return Mediator.Send(new DeleteDogRequest(id));
    //}
}
