using BUS.Services._1_Interface;
using BUS.Viewmodel.Subject;
using BUS.Viewmodel.Teacher;
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
    public class SubjectService : ISubjectService
    {
        private readonly ManagerStudent_DBContext _dbcontext;
        public SubjectService()
        {
            _dbcontext = new ManagerStudent_DBContext();
        }
        public async Task<bool> CreateAsync(SubjectCreateVM request)
        {
            if (request != null)
            {
                var obj = new Subject
                {
                    SubjectCode = request.SubjectCode,
                    NameSubject = request.NameSubject,
                    NumberofCredits = request.NumberofCredits,
                    Status = request.Status
                };
                await _dbcontext.Subject.AddAsync(obj);
                await _dbcontext.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<List<SubjectVM>> GetAllAsync()
        {
            var obj = await _dbcontext.Subject.ToListAsync();

            var objVMs = obj.Select(s => new SubjectVM
            {
                SubjectCode = s.SubjectCode,
                NameSubject = s.NameSubject,
                NumberofCredits = s.NumberofCredits,
                CreateDate = s.CreateDate,
                Status = s.Status
            }).ToList();

            return objVMs;
        }
        public async Task<SubjectVM> GetByIDAsync(string Code)
        {
            var obj = await _dbcontext.Subject.FirstOrDefaultAsync(s => s.SubjectCode == Code);
            if (obj == null)
            {
                return null;
            }

            return new SubjectVM
            {
                SubjectCode = obj.SubjectCode,
                NameSubject = obj.NameSubject,
                NumberofCredits = obj.NumberofCredits,
                CreateDate = obj.CreateDate,
                Status = obj.Status
            };
        }
        public async Task<bool> RemoveAsync(string Code)
        {
            var obj = await _dbcontext.Subject.FirstOrDefaultAsync(s => s.SubjectCode == Code);

            if (obj == null)
            {
                return false;
            }

            _dbcontext.Subject.Remove(obj);
            await _dbcontext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> UpdateAsync(string Code, SubjectUpdateVM request)
        {
            var obj = await _dbcontext.Subject.FirstOrDefaultAsync(s => s.SubjectCode == Code);

            if (obj == null)
            {
                return false;
            }

            obj.SubjectCode = request.SubjectCode;
            obj.NameSubject = request.NameSubject;
            obj.NumberofCredits = request.NumberofCredits;
            obj.Status = request.Status;
            obj.ModifieDate = DateTime.UtcNow;
            _dbcontext.Subject.Update(obj);
            await _dbcontext.SaveChangesAsync();
            return true;
        }
    }
}
