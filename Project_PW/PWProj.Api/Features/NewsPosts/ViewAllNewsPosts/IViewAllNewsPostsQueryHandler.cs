namespace PWProj.Api.Features.NewsPosts.ViewAllNewsPosts
{
    public interface IViewAllNewsPostsQueryHandler
    {
        public Task<IEnumerable<NewsPostDto>> HandleAsync(CancellationToken cancellationToken);
    }
}
