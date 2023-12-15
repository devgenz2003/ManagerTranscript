using BUS.Viewmodel.ClassTC;

namespace BUS.Services._1_Interface
{
    public interface IClassTCService
    {
        public Task<List<ClassTCVM>> GetAllAsync();
        public Task<ClassTCVM> GetByIDAsync(string Code);
        public Task<bool> CreateAsync(ClassTCCreateVM request);
        public Task<bool> UpdateAsync(string Code, ClassTCUpdateVM request);
        public Task<bool> RemoveAsync(string Code);
        public Task<int> GetNumberOfCreditClassesBySemesterCodeAsync(string semesterCode);
    }
}
