namespace PWProj.Api.Features.NewsPosts.DeleteNewsPost
{
    public interface IDeleteNewsPostHandler
    {
        public Task HandleAsync(int id, CancellationToken cancellation);
    }
}
