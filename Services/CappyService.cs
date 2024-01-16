using Cappy.SDK.Entities;
using Cappy.SDK.Interfaces;
using Cappy.SDK.Modules;

namespace Cappy.SDK.Services;

public class CappyService : ICappyService
{
    private readonly string _v1Deviations = "v1/deviations";
    private readonly string _v1Employees = "v1/employees";
    private readonly string _v1Employer = "v1/employer";
    private readonly string _v1OffCyclePayment = "v1/offcyclepayrollfiles";
    private readonly string _v1PayRollFile = "v1/payrollfiles";
    private readonly string _v1Shift = "v1/shifts";
    private CappyClient Client { get; set; }
    
    public CappyService(string serverUrl, string apiKey)
    {
        Client = new CappyClient(serverUrl, apiKey);
    }

    public async Task SynchronizeDeviationAsync(CappyDeviationSynchronization synchronization)
    {
        await Client.PostAsync($"{_v1Deviations}/synchronize", synchronization);
    }

    public async Task CreateDeviationsAsync(List<CappyDeviation> deviations)
    {
        await Client.PostRangeAsync(_v1Deviations, deviations);
    }
    
    public async Task UpdateDeviations(List<CappyDeviation> deviations)
    {
        await Client.PatchRangeAsync(_v1Deviations, deviations);
    }
    
    public async Task DeleteDeviationAsync(string id)
    {
        await Client.DeleteAsync($"{_v1Deviations}/{id}");
    }
    
    public async Task CreateEmployeeAsync(CappyDetailedEmployee employee)
    {
        await Client.PostRangeAsync(_v1Employees, new List<CappyDetailedEmployee>{employee});
    }
    
    public async Task CreateEmployeesAsync(List<CappyDetailedEmployee> employees)
    {
        await Client.PostRangeAsync(_v1Employees, employees);
    }
    
    public async Task UpdateEmployeeAsync(CappyDetailedEmployee employee)
    {
        var list = new List<CappyDetailedEmployee> {employee};
        await Client.PatchRangeAsync($"{_v1Employees}", list);
    }
    
    public async Task UpdateEmployeesAsync(List<CappyDetailedEmployee> employees)
    {
        await Client.PatchRangeAsync($"{_v1Employees}", employees);
    }

    public async Task<List<CappyEmployee>> GetAllEmployeesAsync()
    {
        var employees = await Client.GetListAsync<CappyEmployee>(_v1Employees);
        return employees;
    }

    public async Task<CappyDetailedEmployee> GetEmployeeAsync(string id)
    {
        var employee = await Client.GetSingleAsync<CappyDetailedEmployee>($"{_v1Employees}/{id}");
        return employee;
    }
    
    public async Task<List<CappyEmployee>> GetEmployeesWithConsentAsync()
    {
        var employee = await Client.GetListAsync<CappyEmployee>($"{_v1Employees}/withconsent");
        return employee;
    }
    
    public async Task<List<CappyEmployee>> GetActiveEmployeesAsync()
    {
        var employee = await Client.GetListAsync<CappyEmployee>($"{_v1Employees}/active");
        return employee;
    }
    
    public async Task<List<CappyEmployee>> GetEmployeesAwaitingActivationAsync()
    {
        var employee = await Client.GetListAsync<CappyEmployee>($"{_v1Employees}/awaitingactivation");
        return employee;
    }

    public async Task ActivateEmployeeAsync(string id)
    {
        await Client.PostAsync($"{_v1Employees}/activate/{id}");
    }
    
    public async Task<List<CappyEmployer>> GetEmployersAsync()
    {
        var employers = await Client.GetListAsync<CappyEmployer>($"{_v1Employer}");
        return employers;
    }
    
    public async Task CreateOffCyclePaymentAsync(DateTime paymentDate, string id, CappyOffCyclePayment offCyclePayment)
    {
        await Client.PostAsync($"{_v1OffCyclePayment}/{paymentDate:yyyy-MM-dd}/{id}", offCyclePayment);
    }
    
    public async Task DeleteOffCyclePaymentAsync(DateTime paymentDate, string id)
    {
        await Client.DeleteAsync($"{_v1OffCyclePayment}/{paymentDate:yyyy-MM-dd}/{id}");
    }
    
    public async Task CreateOffCyclePaymentFileAsync(string id, string fileContent)
    {
        await Client.PostRawAsync($"{_v1OffCyclePayment}/raw/{id}", fileContent);
    }
    
    public async Task CreatePayrollFileAsync(CappyPayRollFile payRollFile)
    {
        await Client.PostAsync($"{_v1PayRollFile}", payRollFile);
    }    
    
    public async Task DeletePayrollFileAsync(DateTime payDay, string fileId)
    {
        await Client.DeleteAsync($"{_v1PayRollFile}/raw?payday={payDay:yyyy-MM-dd}&fileId={fileId}");
    }
    
    public async Task CreateRawPayrollFileAsync(DateTime payDay, string fileId, string fileContent)
    {
        await Client.PostRawAsync($"{_v1PayRollFile}/raw?payday={payDay:yyyy-MM-dd}&fileId={fileId}", fileContent);
    }    

    public async Task SynchronizeShifts(CappyShiftSynchronization synchronization)
    {
        await Client.PostAsync($"{_v1Shift}/synchronize", synchronization);
    }
    
    public async Task CreateShiftsAsync(List<CappyShift> shifts)
    {
        await Client.PostRangeAsync($"{_v1Shift}", shifts);
    }
    
    public async Task UpdateShiftsAsync(List<CappyShift> shifts)
    {
        await Client.PatchRangeAsync($"{_v1Shift}", shifts);
    }
    
    public async Task DeleteShiftsAsync(string id)
    {
        await Client.DeleteAsync($"{_v1Shift}/{id}");
    }
}