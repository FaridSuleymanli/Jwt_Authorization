using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TutTest.DAL
{
    public class TutorialTestContext : IdentityDbContext
    {
        public TutorialTestContext(DbContextOptions<TutorialTestContext> options) : base(options)
        {

        }
    }
}
