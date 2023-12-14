using DAL.Configuration;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ApplicationDBContext
{
    public partial class ManagerStudent_DBContext : DbContext
    {
        public ManagerStudent_DBContext()
        {
            
        }

        public ManagerStudent_DBContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(
                        "Data Source=.;Initial Catalog=v2023;Integrated Security=True"
                        );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClassTCConfiguration());
            modelBuilder.ApplyConfiguration(new ExamScheduleConfiguration());
            modelBuilder.ApplyConfiguration(new SemesterConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new StudentSubjectConfiguration());
            modelBuilder.ApplyConfiguration(new SubjectConfiguration());
            modelBuilder.ApplyConfiguration(new TeacherConfiguration());
            modelBuilder.ApplyConfiguration(new TranscriptConfiguration());

            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<ClassTC> ClassTC { get; set; } = null!;
        public virtual DbSet<ExamSchedule> ExamSchedule { get; set; } = null!;
        public virtual DbSet<Semester> Semester { get; set; } = null!;
        public virtual DbSet<Student> Student { get; set; } = null!;
        public virtual DbSet<StudentSubject> StudentSubject { get; set; } = null!;
        public virtual DbSet<Subject> Subject { get; set; } = null!;
        public virtual DbSet<Teacher> Teacher { get; set; } = null!;
        public virtual DbSet<Transcript> Transcript { get; set; } = null!;
    }
}
