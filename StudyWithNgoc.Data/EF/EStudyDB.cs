using Microsoft.EntityFrameworkCore;
using StudyWithNgoc.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyWithNgoc.Data.EF
{
    public class EStudyDB : DbContext
    {
        protected EStudyDB(DbContextOptions options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=blogging.db");
        }

        public DbSet<tblClass> tblClasses { get; set; }
        public DbSet<tblCourse> tblCourses { get; set; }
    }
}
