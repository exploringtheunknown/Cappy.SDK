using Cappy.SDK.Entities;

namespace Cappy.SDK.Interfaces;

public interface ICappyService
{
    /// <summary>
    /// The sync window is defined in terms of the date property of the deviations. The provided deviations will be created or updated in Cappy. Any deviation that are present in Cappy in the given sync window but not provided in the request will be deleted. It is therefore important that ALL deviations for the given sync window are provided in the request, and that the sync window is correctly specified, otherwise data loss may occur.
    /// </summary>
    /// <param name="synchronization">A window of synchronization, between syncWindowStart and syncWindowEnd</param>
    Task SynchronizeDeviationAsync(CappyDeviationSynchronization synchronization);
    
    /// <summary>
    /// Create list of deviations
    /// </summary>
    /// <param name="deviations">Deviation with amount</param>
    Task CreateDeviationsAsync(List<CappyDeviation> deviations);
    
    /// <summary>
    /// Update list of deviations
    /// </summary>
    /// <param name="deviations">Deviation with amount</param>
    Task UpdateDeviations(List<CappyDeviation> deviations);
    
    /// <summary>
    /// Deletes a specific deviation
    /// </summary>
    /// <param name="id">Id of deviation</param>
    Task DeleteDeviationAsync(string id);
    
    /// <summary>
    /// Create an employee
    /// </summary>
    Task CreateEmployeeAsync(CappyDetailedEmployee employee);

    /// <summary>
    /// Create a range of employees
    /// </summary>
    Task CreateEmployeesAsync(List<CappyDetailedEmployee> employees);

    /// <summary>
    /// Use this method to update employee
    /// </summary>
    Task UpdateEmployeeAsync(CappyDetailedEmployee employee);

    /// <summary>
    /// Use this method to update a range of employees
    /// </summary>
    Task UpdateEmployeesAsync(List<CappyDetailedEmployee> employees);
    
    /// <summary>
    /// Use this method to get all employees (simplified objects)
    /// </summary>
    Task<List<CappyEmployee>> GetAllEmployeesAsync();
    
    /// <summary>
    /// Use this method to get a specific employee by Id
    /// </summary>
    Task<CappyDetailedEmployee> GetEmployeeAsync(string id);
    
    /// <summary>
    /// Use this method to get only employees with consent
    /// </summary>
    Task<List<CappyEmployee>> GetEmployeesWithConsentAsync();
    
    /// <summary>
    /// Use this method to get only active employees
    /// </summary>
    Task<List<CappyEmployee>> GetActiveEmployeesAsync();
    
    /// <summary>
    /// Use this method to get only employees pending activation
    /// </summary>
    Task<List<CappyEmployee>> GetEmployeesAwaitingActivationAsync();
    
    /// <summary>
    /// Use this method to activate a specific employee
    /// </summary>
    Task ActivateEmployeeAsync(string id);
    
    /// <summary>
    /// Use this method to get all employers
    /// </summary>
    Task<List<CappyEmployer>> GetEmployersAsync();
    
    /// <summary>
    /// Use this method create an OffCyclePayment
    /// </summary>
    Task CreateOffCyclePaymentAsync(DateTime paymentDate, string id, CappyOffCyclePayment offCyclePayment);
    
    /// <summary>
    /// Use this method delete an OffCyclePayment
    /// </summary>
    Task DeleteOffCyclePaymentAsync(DateTime paymentDate, string id);
    
    /// <summary>
    /// Use this method create an OffCyclePayment file
    /// </summary>
    Task CreateOffCyclePaymentFileAsync(string id, string fileContent);
    
    /// <summary>
    /// Use this method create a Payroll file
    /// </summary>
    Task CreatePayrollFileAsync(CappyPayRollFile payRollFile);
    
    /// <summary>
    /// Use this method delete a Payroll file
    /// </summary>
    Task DeletePayrollFileAsync(DateTime payDay, string fileId);
    
    /// <summary>
    /// Use this method create a raw Payroll file
    /// </summary>
    Task CreateRawPayrollFileAsync(DateTime payDay, string fileId, string fileContent);
    
    /// <summary>
    /// Use this method synchronize shifts
    /// </summary>
    Task SynchronizeShifts(CappyShiftSynchronization synchronization);
    
    /// <summary>
    /// Use this method create one or more shifts
    /// </summary>
    Task CreateShiftsAsync(List<CappyShift> shifts);
    
    /// <summary>
    /// Use this method update a range of shifts
    /// </summary>
    Task UpdateShiftsAsync(List<CappyShift> shifts);
    
    /// <summary>
    /// Use this method delete a specific shift
    /// </summary>
    Task DeleteShiftsAsync(string id);
}