﻿using System;
using System.Threading.Tasks;
using BlogCore.Blog.Infrastructure;

namespace BlogCore.Blog.Migrator
{
    public static class BlogContextSeeder
    {
        public static async Task Seed(BlogDbContext dbContext)
        {
            for (var i = 1; i <= 1; i++)
                await dbContext.Set<Domain.Blog>().AddAsync(new Domain.Blog
                {
                    Id = new Guid("5b1fa7c2-f814-47f2-a2f3-03866f978c49"),
                    Title = $"Blog {i} - Root",
                    Description = $"Blog {i}'s description",
                    Image = null,
                    Theme = "default",
                    PostsPerPage = 10,
                    ModerateComments = true,
                    DaysToComment = 10,
                    OwnerEmail = "root@blogcore.com"
                });

            await dbContext.Set<Domain.Blog>().AddAsync(new Domain.Blog
            {
                Id = new Guid("34c96712-2cdf-4e79-9e2f-768cb68dd552"),
                Title = "Blog for user1 - Normal User",
                Description = "Blog for user1's description",
                Image = null,
                Theme = "default",
                PostsPerPage = 10,
                ModerateComments = true,
                DaysToComment = 10,
                OwnerEmail = "user1@blogcore.com"
            });

            await dbContext.SaveChangesAsync();
        }
    }
}