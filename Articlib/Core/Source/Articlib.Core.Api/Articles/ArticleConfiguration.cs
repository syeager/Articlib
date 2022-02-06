using Articlib.Core.Api.Users;
using Articlib.Core.Domain.Articles;
using Articlib.Core.Domain.Votes.Services;
using LittleByte.Validation;

namespace Articlib.Core.Api.Articles;

internal static class ArticleConfiguration
{
    public static IServiceCollection AddArticles(this IServiceCollection @this)
    {
        return @this
            .AddTransient<CreateArticleController>()
            .AddTransient<LogInController>()
            .AddTransient<IAddVote, AddVote>()
            .AddTransient<IModelValidator<Article>, ArticleValidator>()
            .AddTransient<IPostArticleService, PostArticleService>();
    }
}
