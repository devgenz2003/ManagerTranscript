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
    public partial class StudentSubjectConfiguration : IEntityTypeConfiguration<StudentSubject>
    {
        public void Configure(EntityTypeBuilder<StudentSubject> builder)
        {
            builder.HasKey(c => new { c.StudentCode, c.SubjectCode });
            builder.Property(c => c.CreateDate).IsRequired();
            builder.Property(c => c.CreateBy).IsRequired();
            builder.Property(c => c.ModifieBy).IsRequired(false);
            builder.Property(c => c.ModifieDate).IsRequired(false);
            builder.Property(c => c.DeleteBy).IsRequired(false);
            builder.Property(c => c.DeleteDate).IsRequired(false);
            builder.Property(c => c.Status).IsRequired();

            builder.HasOne<Student>(c => c.Student)
                .WithMany(c => c.StudentSubject)
                .HasForeignKey(c => c.StudentCode)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<Subject>(c => c.Subject)
               .WithMany(c => c.StudentSubject)
               .HasForeignKey(c => c.SubjectCode)
               .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
