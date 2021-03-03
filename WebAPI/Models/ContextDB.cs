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
        public DbSet<Users> Users { get; set; }
        //public DbSet<NSITestTypes> NSITestTypes { get; set; }
        //public DbSet<NSIStudySubjectName> NSIStudySubjectName { get; set; }
        //public DbSet<QuestionTest> QuestionTest { get; set; }
        //public DbSet<AnswerTest> AnswerTest { get; set; }
        //public DbSet<QuestionInputTest> QuestionInputTest { get; set; }
        public DbSet<NSIUsersTypes> NSIUsersTypes { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }
        public DbSet<NSIRoles> NSIRoles { get; set; }
        public DbSet<RoleRights> RoleRights { get; set; }
        public DbSet<NSIRights> NSIRights { get; set; }
        public DbSet<SchoolboyUsers> SchoolboyUsers { get; set; }
        public DbSet<NSILanguageLearning> NSILanguageLearning { get; set; }
        public DbSet<NSIClassName> NSIClassName { get; set; }


        public ContextDB(DbContextOptions<ContextDB> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}

