
using BUS.Viewmodel.Semester;

namespace BUS.Services._1_Interface
{
    public interface ISemesterService
    {
        public Task<List<SemesterVM>> GetAllAsync();
        public Task<SemesterVM> GetByIDAsync(string Code);
        public Task<bool> CreateAsync(SemesterCreateVM request);
        public Task<bool> UpdateAsync(string Code, SemesterUpdateVM request);
        public Task<bool> RemoveAsync(string Code);
    }
}
