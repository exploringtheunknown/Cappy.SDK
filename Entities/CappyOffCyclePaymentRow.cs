using Newtonsoft.Json;

namespace Cappy.SDK.Entities;

public class CappyOffCyclePaymentRow : CappyBase
{
    [JsonProperty("employeePayrollFileIdentifier", NullValueHandling = NullValueHandling.Ignore)]
    public string EmployeePayrollFileIdentifier { get; set; }

    [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
    public string Text { get; set; }

    [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
    public int Amount { get; set; }

    [JsonProperty("bankAccountNumber", NullValueHandling = NullValueHandling.Ignore)]
    public string BankAccountNumber { get; set; }
}