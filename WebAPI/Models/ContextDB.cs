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
        #region dbo
        public DbSet<Users> Users { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }
        public DbSet<SchoolboyUsers> SchoolboyUsers { get; set; }
        public DbSet<CloseTest> CloseTest { get; set; }
        public DbSet<CloseTestAnswer> CloseTestAnswer { get; set; }
        public DbSet<SortTest> SortTest { get; set; }
        public DbSet<SortTestAnswer> SortTestAnswer { get; set; }
        public DbSet<InfoMaterialAdd> InfoMaterialAdd { get; set; }
        public DbSet<InterdisciplinaryRelationship> InterdisciplinaryRelationship { get; set; }
        public DbSet<BaseTheme> BaseTheme { get; set; }
        public DbSet<MaterialData> MaterialData { get; set; }
        public DbSet<MaterialDataGlossary> MaterialDataGlossary { get; set; }
        public DbSet<MaterialDataVideo> MaterialDataVideo { get; set; }
        public DbSet<MaterialDataImage> MaterialDataImage { get; set; }
        public DbSet<MaterialDigEduResources> MaterialDigEduResources { get; set; }
        public DbSet<MaterialInteractive> MaterialInteractive { get; set; }
        public DbSet<MaterialAdditionalInformation> MaterialAdditionalInformation { get; set; }
        public DbSet<MaterialAddInfoVideo> MaterialAddInfoVideo { get; set; }
        public DbSet<MaterialAddInfoImage> MaterialAddInfoImage { get; set; }
        #endregion

        #region nsi
        public DbSet<NSITestTypes> NSITestTypes { get; set; }
        public DbSet<NSIUsersTypes> NSIUsersTypes { get; set; }
        public DbSet<NSIRoles> NSIRoles { get; set; }
        public DbSet<RoleRights> RoleRights { get; set; }
        public DbSet<NSIRights> NSIRights { get; set; }
        public DbSet<NSILanguageLearning> NSILanguageLearning { get; set; }
        public DbSet<NSIClassName> NSIClassName { get; set; }
        public DbSet<NSISchool> NSISchool { get; set; }
        public DbSet<NSISkillsName> NSISkillsName { get; set; }
        public DbSet<NSISortTypes> NSISortTypes { get; set; }
        public DbSet<NSIThemeName> NSIThemeName { get; set; }
        public DbSet<NSISubjectName> NSISubjectName { get; set; }
        public DbSet<NSISectionName> NSISectionName { get; set; }
        #endregion

        public ContextDB(DbContextOptions<ContextDB> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}

