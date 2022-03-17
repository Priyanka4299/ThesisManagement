using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ThesisManagement.Models;

namespace ThesisManagement.Data
{
    public class ApplicationDbContext : IdentityDbContext<MyIdentityUser, MyIdentityRole, Guid>
    {
        
        
            public DbSet<Faculty> Faculties { get; set; }
            public DbSet<Project> Projects { get; set; }
            public DbSet<Student> Students { get; set; }
            public DbSet<Subject> Subjects { get; set; }
            public DbSet<SubmissionDetail> SubmissionDetails { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { 
        }
    }
}
