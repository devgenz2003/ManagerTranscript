using BUS.Services._1_Interface;
using BUS.Viewmodel.ClassTC;
using BUS.Viewmodel.Student;
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
    public class ClassTCService : IClassTCService
    {
        private readonly ManagerStudent_DBContext _dbcontext;
        public ClassTCService()
        {
            _dbcontext = new ManagerStudent_DBContext();
        }
        public async Task<bool> CreateAsync(ClassTCCreateVM request)
        {
            var datasearch_teacher = await _dbcontext.Teacher.FirstOrDefaultAsync(c => c.TeacherCode == request.TeacherCode);
            var datasearch_subject = await _dbcontext.Subject.FirstOrDefaultAsync(c => c.SubjectCode == request.CodeSubject);
            var datasearch_semester = await _dbcontext.Semester.FirstOrDefaultAsync(c => c.SemesterCode == request.SemesterCode);
            if (datasearch_teacher == null || datasearch_subject == null || datasearch_semester == null)
            {
                return false;
            }
            var obj = new ClassTC
            {
                ClassName = request.ClassName,
                ClassCode = request.ClassCode,
                CodeSubject = datasearch_subject.SubjectCode,
                TeacherCode = datasearch_teacher.TeacherCode,
                SemesterCode = datasearch_semester.SemesterCode,
                QuantityStudent = request.QuantityStudent,
                Status = request.Status,
            };

            await _dbcontext.ClassTC.AddAsync(obj);
            await _dbcontext.SaveChangesAsync();
            return true;
        }

        public async Task<List<ClassTCVM>> GetAllAsync()
        {
            var obj = await _dbcontext.ClassTC.ToListAsync();

            var objvms = obj.Select(s => new ClassTCVM
            {
                ClassName = s.ClassName,
                ClassCode = s.ClassCode,
                CodeSubject = s.CodeSubject,
                TeacherCode = s.TeacherCode,
                QuantityStudent = s.QuantityStudent,
                Status = s.Status
            }).ToList();

            return objvms;
        }

        public async Task<ClassTCVM> GetByIDAsync(string Code)
        {
            var obj = await _dbcontext.ClassTC
                           .FirstOrDefaultAsync(s => s.ClassCode == Code); 
            if (obj == null)
            {
                return null;
            }

            return new ClassTCVM
            {
                ClassName = obj.ClassName,
                ClassCode = obj.ClassCode,
                CodeSubject = obj.CodeSubject,
                TeacherCode = obj.TeacherCode,
                QuantityStudent = obj.QuantityStudent,
                Status = obj.Status
            };
        }

        public async Task<bool> RemoveAsync(string Code)
        {
            var obj = await _dbcontext.ClassTC
                            .FirstOrDefaultAsync(s => s.ClassCode == Code);

            if (obj == null)
            {
                return false;
            }

            _dbcontext.ClassTC.Remove(obj);
            await _dbcontext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateAsync(string Code, ClassTCUpdateVM request)
        {
            var obj = await _dbcontext.ClassTC
                                      .FirstOrDefaultAsync(s => s.ClassCode == Code);

            if (obj == null)
            {
                return false;
            }

            obj.ClassName = request.ClassName;
            obj.ClassCode = request.ClassCode;
            obj.SemesterCode = request.SemesterCode;
            obj.CodeSubject = request.CodeSubject;
            obj.TeacherCode = request.TeacherCode;
            obj.QuantityStudent = request.QuantityStudent;
            obj.Status = obj.Status;
            obj.ModifieDate = DateTime.UtcNow;
            _dbcontext.ClassTC.Update(obj);
            await _dbcontext.SaveChangesAsync();
            return true;
        }
    }
}
