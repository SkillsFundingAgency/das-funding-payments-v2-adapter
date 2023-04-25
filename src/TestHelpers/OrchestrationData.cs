using Microsoft.Azure.WebJobs.Extensions.DurableTask;

namespace SFA.DAS.Funding.PaymentsV2Adapter.TestHelpers;

public class OrchestrationData : IOrchestrationData
{
    public DurableOrchestrationStatus Status { get; set; }
    public object Entity { get; set; }
}