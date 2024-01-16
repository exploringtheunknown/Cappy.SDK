using System.Text;
using Cappy.SDK.Entities;
using Microsoft.Net.Http.Headers;
using Newtonsoft.Json;

namespace Cappy.SDK.Modules;

public class CappyClient : ICappyClient
{
    private readonly HttpClient _httpClient;
    private readonly string _applicationJson = "application/json";

    public CappyClient(string serverUrl, string apiKey)
    {
        try
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(serverUrl);
            _httpClient.DefaultRequestHeaders.Add(HeaderNames.UserAgent, "Cappy SDK");
            _httpClient.DefaultRequestHeaders.Add(HeaderNames.Authorization, $"ApiKey {apiKey}");
        }
        catch (Exception e)
        {   
            throw new CappySdkException(e);
        }
    }

    public async Task<T> GetSingleAsync<T>(string path) where T : CappyBase
    {
        var response = await _httpClient.GetAsync(path);
        
        if (!response.IsSuccessStatusCode)
            throw new CappySdkException(response.ReasonPhrase ?? $"{response.StatusCode}");
        
        var singleObject = JsonConvert.DeserializeObject<T>(response.Content.ReadAsStringAsync().Result);
        return singleObject;
    }

    public async Task<List<T>> GetListAsync<T>(string path) where T : CappyBase
    {
        var response = await _httpClient.GetAsync(path);
        
        if (!response.IsSuccessStatusCode)
            throw new CappySdkException(response.ReasonPhrase ?? $"{response.StatusCode}");
        
        var objects = JsonConvert.DeserializeObject<List<T>>(response.Content.ReadAsStringAsync().Result);
        return objects;
    }
    
    public async Task PostAsync(string path)
    {
        var response = await _httpClient.PostAsync(path, new StringContent(string.Empty) );
        
        if (!response.IsSuccessStatusCode)
            throw new CappySdkException(response.ReasonPhrase);
    }
    
    public async Task PostAsync<T>(string path, T model) where T : CappyBase
    {
        var json = JsonConvert.SerializeObject(model);
        var httpContent = new StringContent(json, Encoding.UTF8, _applicationJson);
        var response = await _httpClient.PostAsync(path, httpContent);
        
        if (!response.IsSuccessStatusCode)
            throw new CappySdkException(response.ReasonPhrase ?? $"{response.StatusCode}");
    }
    
    public async Task PostRangeAsync<T>(string path, List<T> model) where T : CappyBase
    {
        var json = JsonConvert.SerializeObject(model);
        var httpContent = new StringContent(json, Encoding.UTF8, _applicationJson);
        var response = await _httpClient.PostAsync(path, httpContent);
        
        if (!response.IsSuccessStatusCode)
            throw new CappySdkException(response.ReasonPhrase ?? $"{response.StatusCode}");
    }
    
    public async Task<T> PatchAsync<T>(string path, T model) where T : CappyBase
    {
        var json = JsonConvert.SerializeObject(model);
        var httpContent = new StringContent(json, Encoding.UTF8, _applicationJson);
        var response = await _httpClient.PatchAsync(path, httpContent);
        
        if (!response.IsSuccessStatusCode)
            throw new CappySdkException(response.ReasonPhrase ?? $"{response.StatusCode}");

        return model;
    }
    
    public async Task PatchRangeAsync<T>(string path, List<T> models)
    {
        var json = JsonConvert.SerializeObject(models);
        var httpContent = new StringContent(json, Encoding.UTF8, _applicationJson);
        var response = await _httpClient.PatchAsync(path, httpContent);
        
        if (!response.IsSuccessStatusCode)
            throw new CappySdkException(response.ReasonPhrase ?? $"{response.StatusCode}");
    }
    
    public async Task DeleteAsync(string path)
    {
        var response = await _httpClient.DeleteAsync(path);
        if (!response.IsSuccessStatusCode) 
            throw new CappySdkException(response.ReasonPhrase ?? $"{response.StatusCode}");
    }

    public async Task PostRawAsync(string path, string fileContent)
    {
        var httpContent = new StringContent(fileContent, Encoding.UTF8, _applicationJson);
        var response = await _httpClient.PostAsync(path, httpContent);
        
        if (!response.IsSuccessStatusCode)
            throw new CappySdkException(response.ReasonPhrase ?? $"{response.StatusCode}");
    }
}