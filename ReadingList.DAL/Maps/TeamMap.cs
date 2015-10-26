using TeamManager.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace TeamManager.DAL.Maps
{
    public class TeamMap : EntityTypeConfiguration<Team>
    {
        public TeamMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);
            this.Property(t => t.Name).IsRequired().HasMaxLength(256);
            this.HasMany(t => t.Members)
                .WithMany(m => m.Teams)
                .Map(m =>
                {
                    m.ToTable("TeamMembers");
                    m.MapLeftKey("TeamId");
                    m.MapRightKey("MemberId");
                });
            //// Properties
            //this.Property(t => t.CategoryName)
            //    .IsRequired()
            //    .HasMaxLength(15);

            //// Table & Column Mappings
            //this.ToTable("Categories");
            //this.Property(t => t.CategoryID).HasColumnName("CategoryID");
            //this.Property(t => t.CategoryName).HasColumnName("CategoryName");
            //this.Property(t => t.Description).HasColumnName("Description");
            //this.Property(t => t.Picture).HasColumnName("Picture");
        }
    }
}
