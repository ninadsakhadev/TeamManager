using TeamManager.DAL.Common;
using TeamManager.DAL.Maps;
using TeamManager.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamManager.DAL.Migrations;

namespace TeamManager.DAL
{
    public class TeamManagerContext : DataContext

    {
        static TeamManagerContext()
        {
            Database.SetInitializer<TeamManagerContext>(new MigrateDatabaseToLatestVersion<TeamManagerContext,Configuration>());
        }
        public TeamManagerContext()
            : base("TeamManagerContext")
        {
        }    
        //public DbSet<CustomList> Lists { get; set; }
        //public DbSet<Link> Links { get; set; }
        //public DbSet<Tag> Tags { get; set; }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Certification> Certifications { get; set; }
        public DbSet<Leave> Leaves { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new CustomListMap());
            //modelBuilder.Configurations.Add(new LinkMap());
            //modelBuilder.Configurations.Add(new TagMap());

            modelBuilder.Configurations.Add(new TeamMap());
            modelBuilder.Configurations.Add(new MemberMap());
            modelBuilder.Configurations.Add(new SkillMap());
            modelBuilder.Configurations.Add(new CertificationMap());
            modelBuilder.Configurations.Add(new Leavemap());
        }

        
    }
}
