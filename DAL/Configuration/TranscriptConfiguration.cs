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
    public partial class TranscriptConfiguration : IEntityTypeConfiguration<Transcript>
    {
        public void Configure(EntityTypeBuilder<Transcript> builder)
        {
            builder.HasKey(c => c.TranscriptCode);
            builder.Property(c => c.CreateDate).IsRequired();
            builder.Property(c => c.CreateBy).IsRequired();
            builder.Property(c => c.ModifieBy).IsRequired(false);
            builder.Property(c => c.ModifieDate).IsRequired(false);
            builder.Property(c => c.DeleteBy).IsRequired(false);
            builder.Property(c => c.DeleteDate).IsRequired(false);
            builder.Property(c => c.Status).IsRequired();

            builder.HasOne<Student>(c => c.Student)
                .WithMany(c => c.Transcript)
                .HasForeignKey(c => c.StudentCode)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<ExamSchedule>(c => c.ExamSchedule)
              .WithMany(c => c.Transcript)
              .HasForeignKey(c => c.ExamCode)
              .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<ClassTC>(c => c.ClassTC)
              .WithMany(c => c.Transcript)
              .HasForeignKey(c => c.ClassCode)
              .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<Subject>(c => c.Subject)
              .WithMany(c => c.Transcript)
              .HasForeignKey(c => c.SubjectCode)
              .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
