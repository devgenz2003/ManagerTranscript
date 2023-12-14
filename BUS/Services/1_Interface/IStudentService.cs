using BUS.Viewmodel.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services._1_Interface
{
    public interface IStudentService
    {
        public Task<List<StudentVM>> GetAllAsync();
        public Task<StudentVM> GetByIDAsync(string Code);
        public Task<bool> CreateAsync(StudentCreateVM request);
        public Task<bool> UpdateAsync(string Code, StudentUpdateVM request);
        public Task<bool> RemoveAsync(string Code);
    }
}
