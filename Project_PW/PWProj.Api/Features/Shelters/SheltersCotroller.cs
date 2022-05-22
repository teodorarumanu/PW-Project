using PWProj.Api.Features.Shelters.AddShelter;
using PWProj.Api.Features.Shelters.DeleteShelter;
using PWProj.Api.Features.Shelters.ViewAllShelters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace PWProj.Api.Features.Shelters
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class SheltersCotroller : ControllerBase
    {
        private readonly IAddShelterCommandHandler addShelterCommandHandler;
        private readonly IViewAllSheltersQueryHandler viewAllSheltersQueryHandler;
        private readonly IDeleteShelterHandler deleteShelterHandler;

        public SheltersCotroller(
            IAddShelterCommandHandler addShelterCommandHandler,
            IViewAllSheltersQueryHandler viewAllSheltersQueryHandler,
            IDeleteShelterHandler deleteShelterHandler)
        {
            this.addShelterCommandHandler = addShelterCommandHandler;
            this.viewAllSheltersQueryHandler = viewAllSheltersQueryHandler;
            this.deleteShelterHandler = deleteShelterHandler;
        }

        [HttpPost("addShelter")]
        [Authorize(Policy = "AdminAccess")]
        public async Task<IActionResult> AddShelterAsync([FromBody] AddShelterCommand command, CancellationToken cancellationToken)
        {
            await addShelterCommandHandler.HandleAsync(command, cancellationToken);

            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpGet("viewAllShelters")]
        [Authorize]
        public async Task<ActionResult<IEnumerable<ShelterDto>>> ViewAllSheltersAsync(CancellationToken cancellationToken)
        {
            var shelters = await viewAllSheltersQueryHandler.HandleAsync(cancellationToken);

            return Ok(shelters);
        }


        [HttpDelete("deleteShelter/{id}")]
        [Authorize("AdminAccess")]
        public async Task<IActionResult> DeleteShelterAsync([FromRoute] int id, CancellationToken cancellationToken)
        {
            await deleteShelterHandler.HandleAsync(id, cancellationToken);

            return NoContent();
        }
    }
}
