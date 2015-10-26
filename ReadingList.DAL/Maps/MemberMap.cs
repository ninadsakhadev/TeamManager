using TeamManager.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace TeamManager.DAL.Maps
{
    public class MemberMap : EntityTypeConfiguration<Member>
    {
        public MemberMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);
            this.Property(t => t.FirstName).IsRequired().HasMaxLength(256);
            this.Property(t => t.LastName).IsRequired().HasMaxLength(256);
            this.Property(t => t.Bio).IsOptional().HasMaxLength(1024);
            this.Property(t => t.ProfilePicture).IsOptional().HasMaxLength(1024);
            this.HasMany(t => t.Certifications).WithMany(m=>m.Members);
            this.HasMany(t => t.Skills).WithMany(m => m.Members);
            this.HasMany(t => t.Teams);
            this.HasMany(t => t.Leaves);
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
