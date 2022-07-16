using Microsoft.EntityFrameworkCore;
using OverReacted.Application.Utilities;
using OverReacted.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverReacted.Infrastructure.Persistance.SeedData
{
    public class OverReactedSeedData
    {
        private readonly ModelBuilder modelBuilder;

        public OverReactedSeedData(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            modelBuilder.Entity<Role>().HasData(
            new Role { Id = 1, Name = "Authenticated", },
            new Role { Id = 2, Name = "Author", },
            new Role { Id = 3, Name = "God", }
             );

            modelBuilder.Entity<User>().HasData(
           new User
           {
               Name = "Dan Abramov",
               Avatar = "https://miro.medium.com/max/3150/1*xxVEfOOAmIKHWOUloRKLhw.jpeg",
               Email = "Dan.Abramov@Facebook.com",
               CreatedOnUTC = DateTime.UtcNow,
               IsEmailActive = true,
               IsActive = true,
               RoleId = 2,
               VerifyCode = Guid.NewGuid().ToString("N"),
               Password = SecurityHelper.GetSha256Hash("12345678"),
               LastVerificationSent = DateTime.UtcNow,
           });

            //       modelBuilder.Entity<Article>().HasData(
            //      new Article
            //      {
            //          Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
            //          Title = "npm audit: Broken by Design",
            //          ShortDescription = "Found 99 vulnerabilities (84 moderately irrelevant, 15 highly irrelevant)",
            //          CreatedOnUTC = DateTime.UtcNow,
            //          EstimationReadTime = 14,
            //      },
            //        new Article
            //        {
            //            Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
            //            Title = "Before You memo()",
            //            ShortDescription = "Rendering optimizations that come naturally.",
            //            CreatedOnUTC = DateTime.UtcNow,
            //            EstimationReadTime = 5,
            //        },
            //             new Article
            //             {
            //                 Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
            //                 Title = "The WET Codebase",
            //                 ShortDescription = "Come waste your time with me.",
            //                 CreatedOnUTC = DateTime.UtcNow,
            //                 EstimationReadTime = 5,
            //             }
            //             ,
            //             new Article
            //             {
            //                 Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
            //                 Title = "Goodbye, Clean Code",
            //                 ShortDescription = "Let clean code guide you. Then let it go.",
            //                 CreatedOnUTC = DateTime.UtcNow,
            //                 EstimationReadTime = 5,
            //             },
            //                   new Article
            //                   {
            //                       Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
            //                       Title = "My Decade in Review",
            //                       ShortDescription = "A personal reflection.",
            //                       CreatedOnUTC = DateTime.UtcNow,
            //                       EstimationReadTime = 26,
            //                   }
            //);
        }
    }
}
