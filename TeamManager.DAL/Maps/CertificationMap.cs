using TeamManager.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace TeamManager.DAL.Maps
{
    public class CertificationMap : EntityTypeConfiguration<Certification>
    {
        public CertificationMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);
            this.Property(t => t.Name).IsRequired().HasMaxLength(256);
            this.Property(t => t.IssuedBy).IsOptional().HasMaxLength(256);

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
