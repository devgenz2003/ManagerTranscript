using BUS.Services._1_Interface;
using BUS.Viewmodel.ExamSchedule;
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
    public class ExamScheduleService : IExamScheduleService
    {
        private readonly ManagerStudent_DBContext _dbcontext;
        public ExamScheduleService()
        {
            _dbcontext = new ManagerStudent_DBContext();
        }
        public async Task<bool> CreateAsync(ExamScheduleCreateVM request)
        {
            if (request == null)
            {
                return false;
            }
            else
            {
                var obj = new ExamSchedule
                {
                    ExamScheduleCode = request.ExamScheduleCode,
                    ExamTime = request.ExamTime,
                    NameSubject = request.NameSubject,
                };
                await _dbcontext.ExamSchedule.AddAsync(obj);
                await _dbcontext.SaveChangesAsync();
                return true;
            }
        }

        public async Task<List<ExamScheduleVM>> GetAllAsync()
        {
            try
            {
                using (var dbContext = new ManagerStudent_DBContext())
                {
                    var obj = await dbContext.ExamSchedule.ToListAsync();
                    if (obj == null)
                    {
                        return new List<ExamScheduleVM>();
                    }

                    var objvms = obj.Select(c => new ExamScheduleVM
                    {
                        ExamScheduleCode = c.ExamScheduleCode,
                        ExamTime = c.ExamTime,
                        NameSubject = c.NameSubject,
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

        public async Task<ExamScheduleVM> GetByIDAsync(string Code)
        {
            var obj = await _dbcontext.ExamSchedule.FirstOrDefaultAsync(c => c.ExamScheduleCode == Code);
            if (obj == null)
            {
                return null;
            }
            return new ExamScheduleVM
            {
                ExamScheduleCode = obj.ExamScheduleCode,
                ExamTime = obj.ExamTime,
                NameSubject = obj.NameSubject,
                Status = obj.Status,
                CreateDate = obj.CreateDate,
            };
        }

        public async Task<bool> RemoveAsync(string Code)
        {
            var obj = await _dbcontext.ExamSchedule
                                       .FirstOrDefaultAsync(s => s.ExamScheduleCode == Code);

            if (obj == null)
            {
                return false;
            }

            _dbcontext.ExamSchedule.Remove(obj);
            await _dbcontext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateAsync(string Code, ExamScheduleUpdateVM request)
        {
            var obj = await _dbcontext.ExamSchedule
                                                 .FirstOrDefaultAsync(s => s.ExamScheduleCode == Code);

            if (obj == null)
            {
                return false;
            }

            obj.ExamScheduleCode = request.ExamScheduleCode;
            obj.ExamTime = request.ExamTime;
            obj.NameSubject = request.NameSubject;
            obj.Status = request.Status;
            obj.ModifieDate = DateTime.UtcNow;
            _dbcontext.ExamSchedule.Update(obj);
            await _dbcontext.SaveChangesAsync();
            return true;
        }
    }
}
