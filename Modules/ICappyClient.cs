using Cappy.SDK.Entities;

namespace Cappy.SDK.Modules;

public interface ICappyClient
{
    Task<T> GetSingleAsync<T>(string path) where T : CappyBase;
    
    Task<List<T>> GetListAsync<T>(string path) where T : CappyBase;
    
    Task PostAsync<T>(string path, T data) where T : CappyBase;
    Task PostAsync(string path);
    Task PostRangeAsync<T>(string path, List<T> model) where T : CappyBase;
    
    Task<T> PatchAsync<T>(string path, T data) where T : CappyBase;
    Task PatchRangeAsync<T>(string path, List<T> models);
    Task DeleteAsync(string path);
}