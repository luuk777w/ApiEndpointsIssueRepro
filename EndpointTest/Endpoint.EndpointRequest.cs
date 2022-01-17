
using Microsoft.AspNetCore.Mvc;

namespace EndpointTest
{
    public class EndpointRequest
    {
        [FromRoute(Name = "projectId")] public Guid ProjectId { get; set; } = default!;

        [FromBody] public string Code { get; set; } = default!;

        [FromBody] public string Description { get; set; } = default!;

        [FromBody] public string Number { get; set; } = default!;
    }
}