using BUS.Viewmodel.ClassTC;
using BUS.Viewmodel.ExamSchedule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services._1_Interface
{
    public interface IExamScheduleService
    {
        public Task<List<ExamScheduleVM>> GetAllAsync();
        public Task<ExamScheduleVM> GetByIDAsync(string Code);
        public Task<bool> CreateAsync(ExamScheduleCreateVM request);
        public Task<bool> UpdateAsync(string Code, ExamScheduleUpdateVM request);
        public Task<bool> RemoveAsync(string Code);
    }
}
