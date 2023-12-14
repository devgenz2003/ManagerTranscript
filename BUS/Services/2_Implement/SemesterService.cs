using BUS.Services._1_Interface;
using BUS.Viewmodel.ExamSchedule;
using BUS.Viewmodel.Semester;
using DAL.ApplicationDBContext;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace BUS.Services._2_Implement
{
    public class SemesterService : ISemesterService
    {
        private readonly ManagerStudent_DBContext _dbcontext;
        public SemesterService()
        {
            _dbcontext = new ManagerStudent_DBContext();
        }
        public async Task<bool> CreateAsync(SemesterCreateVM request)
        {
            if (request == null)
            {
                return false;
            }
            else
            {
                var obj = new Semester
                {
                    SemesterCode = request.SemesterCode,
                    SemesterName = request.SemesterName,
                    SchoolYear = request.SchoolYear,
                };
                await _dbcontext.Semester.AddAsync(obj);
                await _dbcontext.SaveChangesAsync();
                return true;
            }
        }
        public async Task<List<SemesterVM>> GetAllAsync()
        {
            try
            {
                using (var dbContext = new ManagerStudent_DBContext())
                {
                    var obj = await dbContext.Semester.ToListAsync();
                    if (obj == null)
                    {
                        return new List<SemesterVM>();
                    }

                    var objvms = obj.Select(c => new SemesterVM
                    {
                        SemesterCode = c.SemesterCode,
                        SemesterName = c.SemesterName,
                        SchoolYear = c.SchoolYear,
                        Status = c.Status,
                        CreateDate = c.CreateDate,
                    }).ToList();
                    return objvms;
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ hoặc ghi log ở đây.
                throw;
            }
        }
        public async Task<SemesterVM> GetByIDAsync(string Code)
        {
            var obj = await _dbcontext.Semester.FirstOrDefaultAsync(c => c.SemesterCode == Code);
            if (obj == null)
            {
                return null;
            }
            return new SemesterVM
            {
                SemesterCode = obj.SemesterCode,
                SemesterName = obj.SemesterName,
                SchoolYear = obj.SchoolYear,
                Status = obj.Status,
                CreateDate = obj.CreateDate,
            };
        }
        public async Task<bool> RemoveAsync(string Code)
        {
            var obj = await _dbcontext.Semester
                                       .FirstOrDefaultAsync(s => s.SemesterCode == Code);

            if (obj == null)
            {
                return false;
            }

            _dbcontext.Semester.Remove(obj);
            await _dbcontext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> UpdateAsync(string Code, SemesterUpdateVM request)
        {
            var obj = await _dbcontext.Semester.FirstOrDefaultAsync(s => s.SemesterCode == Code);

            if (obj == null)
            {
                return false;
            }

            obj.SemesterCode = request.SemesterCode;
            obj.SemesterName = request.SemesterName;
            obj.SchoolYear = request.SchoolYear;
            obj.Status = request.Status;
            obj.ModifieDate = DateTime.UtcNow;
            _dbcontext.Semester.Update(obj);
            await _dbcontext.SaveChangesAsync();
            return true;
        }
    }
}
