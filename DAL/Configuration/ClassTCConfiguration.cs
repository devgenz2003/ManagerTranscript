using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configuration
{
    public partial class ClassTCConfiguration : IEntityTypeConfiguration<ClassTC>
    {
        public void Configure(EntityTypeBuilder<ClassTC> builder)
        {
            builder.HasKey(c => c.CodeSubject);
            builder.Property(c => c.CreateDate).IsRequired();
            builder.Property(c => c.CreateBy).IsRequired();
            builder.Property(c => c.ModifieBy).IsRequired(false);
            builder.Property(c => c.ModifieDate).IsRequired(false);
            builder.Property(c => c.DeleteBy).IsRequired(false);
            builder.Property(c => c.DeleteDate).IsRequired(false);
            builder.Property(c => c.Status).IsRequired();

            builder.HasOne<Teacher>(c => c.Teacher)
                .WithMany(c => c.ClassTC)
                .HasForeignKey(c => c.TeacherCode)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<Subject>(c => c.Subject)
                .WithMany(c => c.ClassTC)
                .HasForeignKey(c => c.CodeSubject)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<Semester>(c => c.Semester)
              .WithMany(c => c.ClassTC)
              .HasForeignKey(c => c.SemesterCode)
              .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
