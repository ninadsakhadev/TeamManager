using TeamManager.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace TeamManager.DAL.Maps
{
    public class SkillMap : EntityTypeConfiguration<Skill>
    {
        public SkillMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);
            this.Property(t => t.Name).IsRequired().HasMaxLength(256);
            this.HasMany(t => t.Members).WithMany(m => m.Skills);
        }
    }
}
