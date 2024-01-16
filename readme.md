# Cappy.SDK

[Cappy](https://cappy.se/) is a service to offer flexible pay to employees. The service gives an ongoing control over time worked and earned salary, as well as the possibility to withdraw part of your earned salary when the employee needs it and between regular paydays. Everything available around the clock, every day of the year, in a user-friendly mobile app.

This SDK helps .NET developers integrate with Cappy by using the underlying Cappy Integration API.

[GitHub repository](https://github.com/exploringtheunknown/Cappy.SDK)

[NuGet package](https://www.nuget.org/packages/Cappy.SDK/)

## Installation

`dotnet add package Cappy.SDK --version 1.0.0`

## Usage

**Add Cappy SDK in Program.cs**

```csharp
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCappySdk("cappy-integration-api-url", "your-cappy-api-key");
```

This will add a scoped DI registration to the current ServiceCollection so that the main service can be injected as such:

```csharp
public class MyController
{
    private readonly ICappyService _cappyService;

    public MyController(ICappyService cappyService)
    {
        //Scoped service
        _cappyService = cappyService;
    }
}
```

### ICappyService Interface Usage

The `ICappyService` interface provides the following methods:

Use this method to synchronize a specific window of deviations. This method takes a `CappyDeviationSynchronization` object as a parameter.

```csharp
Task SynchronizeDeviationAsync(CappyDeviationSynchronization synchronization);
```
This method allows you to create a list of deviations.

```csharp
Task CreateDeviationsAsync(List<CappyDeviation> deviations);
```
This method is for updating a list of deviations.

```csharp
Task UpdateDeviations(List<CappyDeviation> deviations);
```
This method deletes a specific deviation by ID.

```csharp
Task DeleteDeviationAsync(string id);
```
This method is for creating an employee.

```csharp
Task CreateEmployeeAsync(CappyDetailedEmployee employee);
```
This method creates multiple employees.

```csharp
Task CreateEmployeesAsync(List<CappyDetailedEmployee> employees);
```
This method updates the details of a specified employee.

```csharp
Task UpdateEmployeeAsync(CappyDetailedEmployee employee);
```
This method updates multiple employees.

```csharp
Task UpdateEmployeesAsync(List<CappyDetailedEmployee> employees);
```
Retrieve all employees using this method.

```csharp
Task<List<CappyEmployee>> GetAllEmployeesAsync();
```
Retrieve a specific employee using their ID.

```csharp
Task<CappyDetailedEmployee> GetEmployeeAsync(string id);
```
Use this method to retrieve only employees who have given consent.

```csharp
Task<List<CappyEmployee>> GetEmployeesWithConsentAsync();
```
This method retrieves all active employees.

```csharp
Task<List<CappyEmployee>> GetActiveEmployeesAsync();
```
This method fetches employees who are awaiting activation.

```csharp
Task<List<CappyEmployee>> GetEmployeesAwaitingActivationAsync();
```
This method activates a specific employee by their ID.

```csharp
Task ActivateEmployeeAsync(string id);
```

Use this method to retrieve all employers.

```csharp
Task<List<CappyEmployer>> GetEmployersAsync();
```
Use this method to create an OffCyclePayment.

```csharp
Task CreateOffCyclePaymentAsync(DateTime paymentDate, string id, 
CappyOffCyclePayment offCyclePayment);
```
This method is used to create a Payroll file.

```csharp
Task CreatePayrollFileAsync(CappyPayRollFile payRollFile);
```

This method deletes a Payroll file.
```csharp
Task DeletePayrollFileAsync(DateTime payDay, string fileId);
```
Use this method to create a raw Payroll file.

```csharp
Task CreateRawPayrollFileAsync(DateTime payDay, string fileId, string fileContent);
```
Use this method to synchronize shifts.

```csharp
Task SynchronizeShifts(CappyShiftSynchronization synchronization);
```
This method creates one or more shifts.

```csharp
Task CreateShiftsAsync(List<CappyShift> shifts);
```
This method updates a range of shifts.
```csharp
Task UpdateShiftsAsync(List<CappyShift> shifts);
```

This method deletes a specific shift with the provided ID.
```csharp
Task DeleteShiftsAsync(string id);
```
## Dependencies

- .NET 6 (LTS)
- Microsoft.AspNetCore.Http.Abstractions | 2.2.0
- Microsoft.AspNetCore.Mvc.Abstractions | 2.2.0
- Microsoft.Extensions.DependencyInjection | 8.0.0
- Microsoft.Extensions.Primitives | 8.0.0
- Newtonsoft.Json | 13.0.3

## License

The MIT License (MIT)

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.