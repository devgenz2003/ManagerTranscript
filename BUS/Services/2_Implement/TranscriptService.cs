
using BUS.Services._1_Interface;
using BUS.Viewmodel.Semester;
using BUS.Viewmodel.Transcript;
using DAL.ApplicationDBContext;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace BUS.Services._2_Implement
{
    public class TranscriptService : ITranscriptService
    {
        private readonly ManagerStudent_DBContext _dbcontext;
        public TranscriptService()
        {
            _dbcontext = new ManagerStudent_DBContext();
        }
        public async Task<bool> CreateAsync(TranscriptCreateVM request)
        {
            if (request != null)
            {
                var datasearch_exam = await _dbcontext.ExamSchedule.FirstOrDefaultAsync(c => c.ExamScheduleCode == request.ExamCode);
                var datasearch_student = await _dbcontext.Student.FirstOrDefaultAsync(c => c.StudentCode == request.StudentCode);
                var datasearch_class = await _dbcontext.ClassTC.FirstOrDefaultAsync(c => c.ClassCode == request.ClassCode);
                var datasearch_subject = await _dbcontext.Subject.FirstOrDefaultAsync(c => c.SubjectCode == request.SubjectCode);
                if (datasearch_class != null || datasearch_exam != null || datasearch_subject != null || datasearch_student != null)
                {
                    var obj = new Transcript
                    {
                        ClassCode = datasearch_class.CodeSubject,
                        SubjectCode = datasearch_subject.SubjectCode,
                        ExamCode = datasearch_exam.ExamScheduleCode,
                        StudentCode = datasearch_student.StudentCode,
                        //
                        TranscriptCode = request.TranscriptCode,
                        NumberCredits = request.NumberCredits,
                        Attendance = request.Attendance,
                        ConditionPoint = request.ConditionPoint,
                        TestScore = request.TestScore,
                        Status = request.Status
                    };
                    await _dbcontext.Transcript.AddAsync(obj);
                    await _dbcontext.SaveChangesAsync();
                    return true;
                }
            }
            return false;
        }
        public async Task<List<TranscriptVM>> GetAllAsync()
        {
            try
            {
                using (var dbContext = new ManagerStudent_DBContext())
                {
                    var obj = await dbContext.Transcript.ToListAsync();
                    if (obj == null)
                    {
                        return new List<TranscriptVM>();
                    }

                    var objvms = obj.Select(c => new TranscriptVM
                    {
                        TranscriptCode = c.TranscriptCode,
                        ClassCode = c.ClassCode,
                        SubjectCode = c.SubjectCode,
                        ExamCode = c.ExamCode,
                        StudentCode = c.StudentCode,
                        //
                        NumberCredits = c.NumberCredits,
                        Attendance = c.Attendance,
                        ConditionPoint = c.ConditionPoint,
                        TestScore = c.TestScore,
                        Status = c.Status,
                    }).ToList();
                    return objvms;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task<TranscriptVM> GetByIDAsync(string Code)
        {
            var obj = await _dbcontext.Transcript.FirstOrDefaultAsync(c => c.TranscriptCode == Code);
            if (obj == null)
            {
                return null;
            }
            return new TranscriptVM
            {
                TranscriptCode = obj.TranscriptCode,
                ClassCode = obj.ClassCode,
                SubjectCode = obj.SubjectCode,
                ExamCode = obj.ExamCode,
                StudentCode = obj.StudentCode,
                NumberCredits = obj.NumberCredits,
                Attendance = obj.Attendance,
                ConditionPoint = obj.ConditionPoint,
                TestScore = obj.TestScore,
                Status = obj.Status,
            };
        }
        public async Task<bool> RemoveAsync(string Code)
        {
            var obj = await _dbcontext.Transcript.FirstOrDefaultAsync(s => s.TranscriptCode == Code);

            if (obj == null)
            {
                return false;
            }

            _dbcontext.Transcript.Remove(obj);
            await _dbcontext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> UpdateAsync(string Code, TranscriptUpdateVM request)
        {
            var obj = await _dbcontext.Transcript.FirstOrDefaultAsync(s => s.TranscriptCode == Code);

            if (obj == null)
            {
                return false;
            }

            obj.ClassCode = request.ClassCode;
            obj.SubjectCode = request.SubjectCode;
            obj.ExamCode = request.ExamCode;
            obj.StudentCode = request.StudentCode;
            obj.TranscriptCode = request.TranscriptCode;
            obj.NumberCredits = request.NumberCredits;
            obj.Attendance = request.Attendance;
            obj.ConditionPoint = request.ConditionPoint;
            obj.TestScore = request.TestScore;
            obj.Status = request.Status;
            obj.ModifieDate = DateTime.UtcNow;
            _dbcontext.Transcript.Update(obj);
            await _dbcontext.SaveChangesAsync();
            return true;
        }
    }
}
