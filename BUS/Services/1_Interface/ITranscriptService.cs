using BUS.Viewmodel.Transcript;

namespace BUS.Services._1_Interface
{
    public interface ITranscriptService
    {
        public Task<List<TranscriptVM>> GetAllAsync();
        public Task<TranscriptVM> GetByIDAsync(string Code);
        public Task<bool> CreateAsync(TranscriptCreateVM request);
        public Task<bool> UpdateAsync(string Code, TranscriptUpdateVM request);
        public Task<bool> RemoveAsync(string Code);
    }
}
