using BUS.Viewmodel.Subject;
using BUS.Viewmodel.Teacher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services._1_Interface
{
    public interface ISubjectService
    {
        public Task<List<SubjectVM>> GetAllAsync();
        public Task<SubjectVM> GetByIDAsync(string Code);
        public Task<bool> CreateAsync(SubjectCreateVM request);
        public Task<bool> UpdateAsync(string Code, SubjectUpdateVM request);
        public Task<bool> RemoveAsync(string Code);
    }
}
