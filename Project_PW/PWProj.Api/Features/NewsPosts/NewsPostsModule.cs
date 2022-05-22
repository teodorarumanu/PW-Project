using PWProj.Api.Features.NewsPosts.AddNewsPost;
using PWProj.Api.Features.NewsPosts.DeleteNewsPost;
using PWProj.Api.Features.NewsPosts.ViewAllNewsPosts;


namespace PWProj.Api.Features.NewsPosts
{
    internal static class NewsPostsModule
    {
          internal static void AddNewsPostsHandlers(this IServiceCollection services)
          {
            services.AddTransient<IAddNewsPostCommandHandler, AddNewsPostCommandHandler>();
            services.AddTransient<IViewAllNewsPostsQueryHandler, ViewAllNewsPostsQueryHandler>();
            services.AddTransient<IDeleteNewsPostHandler, DeleteNewsPostHandler>();
          }
    }
}
