using BUS.Services._1_Interface;
using BUS.Viewmodel.Student;
using BUS.Viewmodel.Transcript;
using DAL.ApplicationDBContext;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services._2_Implement
{
    public partial class StudentService : IStudentService
    {
        private readonly ManagerStudent_DBContext _dbcontext;
        public StudentService()
        {
            _dbcontext = new ManagerStudent_DBContext();
        }
        public async Task<bool> CreateAsync(StudentCreateVM request)
        {
            var student = new Student
            {
                StudentCode = request.StudentCode,
                Class = request.Class,
                Gender = request.Gender,
                BirthDay = request.BirthDay,
                HomeTown = request.HomeTown,
                FullName = request.FullName,
                Status = request.Status,
            };

            await _dbcontext.Student.AddAsync(student);
            await _dbcontext.SaveChangesAsync();
            return true;
        }
        public async Task<List<StudentVM>> GetAllAsync()
        {
            var students = await _dbcontext.Student.ToListAsync();

            var studentVMs = students.Select(s => new StudentVM
            {
                StudentCode = s.StudentCode,
                Class = s.Class,
                Gender = s.Gender,
                BirthDay = s.BirthDay,
                HomeTown = s.HomeTown,
                FullName = s.FullName,
                Status = s.Status,
                CreateDate = s.CreateDate
            }).ToList();

            return studentVMs;
        }
        public async Task<StudentVM> GetByIDAsync(string Code)
        {
            var student = await _dbcontext.Student
                           .FirstOrDefaultAsync(s => s.StudentCode == Code); // Assuming there is a Code property

            if (student == null)
            {
                return null;
            }

            return new StudentVM
            {
                StudentCode = student.StudentCode,
                Class = student.Class,
                Gender = student.Gender,
                BirthDay = student.BirthDay,
                HomeTown = student.HomeTown,
                FullName = student.FullName,
                Status = student.Status,
                CreateDate = student.CreateDate
            };
        }
        public float CalculateAverageScore(Transcript trs)
        {
            float attendanceWeight = 0.1f; 
            float conditionPointWeight = 0.3f; 
            float testScoreWeight = 0.6f; 

            float averageScore = (trs.Attendance * attendanceWeight) +
                                 (trs.ConditionPoint * conditionPointWeight) +
                                 (trs.TestScore * testScoreWeight);

            return averageScore;
        }
        public async Task<List<StudentVM>> GetStudentsRetakingSubject(string subjectCode)
        {
            var transcripts = await _dbcontext.Transcript
                .Where(t => t.SubjectCode == subjectCode)
                .ToListAsync();

            var studentsRetaking = transcripts
                .Select(t => new { Transcript = t, AverageScore = CalculateAverageScore(t) })
                .Where(t => t.AverageScore < 5.0)
                .Select(t => new StudentVM
                {
                    StudentCode = t.Transcript.StudentCode,
                })
                .ToList();

            return studentsRetaking;
        }
        public async Task<bool> RemoveAsync(string Code)
        {
            var student = await _dbcontext.Student
                            .FirstOrDefaultAsync(s => s.StudentCode == Code);

            if (student == null)
            {
                return false;
            }

            _dbcontext.Student.Remove(student);
            await _dbcontext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> UpdateAsync(string Code, StudentUpdateVM request)
        {
            var student = await _dbcontext.Student
                           .FirstOrDefaultAsync(s => s.StudentCode == Code);

            if (student == null)
            {
                return false;
            }

            student.StudentCode = request.StudentCode;
            student.Class = request.Class;
            student.Gender = request.Gender;
            student.BirthDay = request.BirthDay;
            student.HomeTown = request.HomeTown;
            student.FullName = request.FullName;
            student.Status = request.Status;
            student.ModifieDate = DateTime.UtcNow;

            _dbcontext.Student.Update(student);
            await _dbcontext.SaveChangesAsync();
            return true;
        }
        public async Task<List<TranscriptVM>> GetTranscriptsByStudentCode(string Code)
        {
            return await _dbcontext.Transcript
                .Where(t => t.StudentCode == Code)
                .Select(t => new TranscriptVM
                {
                    TranscriptCode = t.TranscriptCode,
                    StudentCode = t.StudentCode,
                    ExamCode = t.ExamCode,
                    ClassCode = t.ClassCode,
                    SubjectCode = t.SubjectCode,
                    NumberCredits = t.NumberCredits,
                    Attendance = t.Attendance,
                    ConditionPoint = t.ConditionPoint,
                    Status = t.Status,
                    TestScore = t.TestScore,
                })
                .ToListAsync();
        }
    }
}
