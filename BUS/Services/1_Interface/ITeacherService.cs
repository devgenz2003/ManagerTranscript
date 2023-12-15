using BUS.Viewmodel.Teacher;
namespace BUS.Services._1_Interface
{
    public interface ITeacherService
    {
        public Task<List<TeacherVM>> GetAllAsync();
        public Task<TeacherVM> GetByIDAsync(string Code);
        public Task<bool> CreateAsync(TeacherCreateVM request);
        public Task<bool> UpdateAsync(string Code, TeacherUpdateVM request);
        public Task<bool> RemoveAsync(string Code);
    }
}
