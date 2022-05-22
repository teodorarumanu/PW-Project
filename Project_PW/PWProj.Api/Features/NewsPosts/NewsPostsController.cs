using PWProj.Api.Features.NewsPosts.AddNewsPost;
using PWProj.Api.Features.NewsPosts.DeleteNewsPost;
using PWProj.Api.Features.NewsPosts.ViewAllNewsPosts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace PWProj.Api.Features.NewsPosts
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class NewsPostsController : ControllerBase
    {
        private readonly IAddNewsPostCommandHandler addNewsPostCommandHandler;
        private readonly IViewAllNewsPostsQueryHandler viewAllNewsPostsQueryHandler;
        private readonly IDeleteNewsPostHandler deleteNewsPostHandler;

        public NewsPostsController(
            IAddNewsPostCommandHandler addNewsPostCommandHandler,
            IViewAllNewsPostsQueryHandler viewAllNewsPostsQueryHandler,
            IDeleteNewsPostHandler deleteNewsPostHandler)
        {
            this.addNewsPostCommandHandler = addNewsPostCommandHandler;
            this.viewAllNewsPostsQueryHandler = viewAllNewsPostsQueryHandler;
            this.deleteNewsPostHandler = deleteNewsPostHandler;
        }

        [HttpPost("addNewsPost")]
        [Authorize(Policy = "AdminAccess")]
        public async Task<IActionResult> AddNewsPostAsync([FromBody] AddNewsPostCommand command, CancellationToken cancellationToken)
        {
            await addNewsPostCommandHandler.HandleAsync(command, cancellationToken);

            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpGet("viewAllNewsPosts")]
        [Authorize]
        public async Task<ActionResult<IEnumerable<NewsPostDto>>> ViewAllNewsPostsAsync(CancellationToken cancellationToken)
        {
            var newsPosts = await viewAllNewsPostsQueryHandler.HandleAsync(cancellationToken);

            return Ok(newsPosts);
        }


        [HttpDelete("deleteNewsPost/{id}")]
        [Authorize("AdminAccess")]
        public async Task<IActionResult> DeleteNewsPostAsync([FromRoute] int id, CancellationToken cancellationToken)
        {
            await deleteNewsPostHandler.HandleAsync(id, cancellationToken);

            return NoContent();
        }
    }
}
