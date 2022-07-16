using Jobguy.Application.Contracts;
using Microsoft.EntityFrameworkCore;
using OverReacted.Application.Dtos.Api;
using OverReacted.Application.Dtos.Article;
using OverReacted.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverReacted.Application.Services.Implements
{
    public class ArticleService : IArticleService
    {
        private readonly IRepository<Article> repository;

        public ArticleService(IRepository<Article> repository)
        {
            this.repository = repository;
        }

        public async Task<Article> CreatePost(CreateNewPostDto post,Guid UserId,CancellationToken cancellationToken)
        {
            var newPost = new Article
            {
                Body = post.Body,
                CreatedOnUTC = DateTime.UtcNow,
                EstimationReadTime = post.EstimationReadTime,
                ShortDescription = post.ShortDescription,
                Title = post.Title,
                UserId = UserId,
            };
            await repository.AddAsync(newPost,cancellationToken);
            return newPost;
        }

        public async Task<List<GetAllPostDto>> GetAllBlogPost(CancellationToken cancellationToken)
        {
            return await repository.TableNoTracking
                .Include(n => n.Author)
                .Select(n => new GetAllPostDto()
                {
                    EstimationReadTime = n.EstimationReadTime,
                    ShortDescription = n.ShortDescription,
                    Title = n.Title,
                    Author = n.Author.Email,
                    Id = n.Id,  
                }).ToListAsync(cancellationToken);
        }

        public async Task<GetAllPostDto?> GetPost(Guid PostId)
        {
            return await repository
                .TableNoTracking
                .Include(n => n.Author)
                .Select(n => new GetAllPostDto
                {
                    EstimationReadTime = n.EstimationReadTime,
                    ShortDescription = n.ShortDescription,
                    Title = n.Title,
                    Author = n.Author.Email,
                    Body = n.Body,
                    Id = n.Id,
                })
            .SingleOrDefaultAsync(n => n.Id == PostId);
        }

        public async Task<bool> RemovePost(Guid PostId, CancellationToken cancellationToken)
        {
            var PostInfo = await repository.GetByIdAsync(cancellationToken, PostId);
            if (PostInfo == null)
                return false;
            await repository.DeleteAsync(PostInfo, cancellationToken);
            return true;
        }

        public async Task<bool> UpdatePost(Guid PostId, CreateNewPostDto post, CancellationToken cancellationToken)
        {
            var postInfo = await repository.GetByIdAsync(cancellationToken, PostId);
            if (postInfo == null)
                return false;
            postInfo.ShortDescription = post.ShortDescription;
            postInfo.Title = post.Title;
            postInfo.UpdatedOnUTC= DateTime.UtcNow;
            postInfo.Body=post.Body;

            await repository.UpdateAsync(postInfo, cancellationToken);
            return true;
        }
    }
}
