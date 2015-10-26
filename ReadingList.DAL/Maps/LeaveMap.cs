using TeamManager.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace TeamManager.DAL.Maps
{
    public class Leavemap : EntityTypeConfiguration<Leave>
    {
        public Leavemap()
        {
            // Primary Key
            this.HasKey(t => t.Id);
            this.Property(t => t.Reason).IsRequired().HasMaxLength(1024);
            this.Property(t => t.StartDate).IsRequired();
            this.Property(t => t.EndDate).IsRequired();
            this.HasRequired(t => t.Member).
                WithMany(m => m.Leaves).
                HasForeignKey(k => k.MemberId);

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
