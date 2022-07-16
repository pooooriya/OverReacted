using OverReacted.Application.Dtos.Api;
using OverReacted.Application.Dtos.Article;
using OverReacted.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverReacted.Application.Services
{
    public interface IArticleService
    {
        Task<List<GetAllPostDto>> GetAllBlogPost(CancellationToken cancellationToken);
        Task<GetAllPostDto?> GetPost(Guid PostId);
        Task<Article> CreatePost(CreateNewPostDto post, Guid UserId, CancellationToken cancellationToken);
        Task<bool> RemovePost(Guid PostId, CancellationToken cancellationToken);
        Task<bool> UpdatePost(Guid PostId, CreateNewPostDto post, CancellationToken cancellationToken);
    }
}
