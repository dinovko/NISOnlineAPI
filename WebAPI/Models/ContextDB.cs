using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models.NSIModel;
using WebAPI.Models.TableModel;

namespace WebAPI.Models
{
    public class ContextDB : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<NSITestTypes> NSITestTypes { get; set; }
        public DbSet<NSIStudySubjectName> NSIStudySubjectName { get; set; }
        public DbSet<QuestionTest> QuestionTest { get; set; }
        public DbSet<AnswerTest> AnswerTest { get; set; }
        public DbSet<QuestionInputTest> QuestionInputTest { get; set; }

        public ContextDB(DbContextOptions<ContextDB> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
