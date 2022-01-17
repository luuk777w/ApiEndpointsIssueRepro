using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EndpointTest
{
    public class Endpoint : EndpointBaseAsync
                                        .WithRequest<EndpointRequest>
                                        .WithActionResult<EndpointRequest>
    {
        public Endpoint()
        {
        }

        [HttpPost("api/test/{projectId}")]
        public override async Task<ActionResult<EndpointRequest>> HandleAsync([FromRoute] EndpointRequest request, CancellationToken cancellationToken = default)
        {
            return Ok(request);
        }
    }
}