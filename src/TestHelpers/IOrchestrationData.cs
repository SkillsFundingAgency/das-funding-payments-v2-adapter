using Microsoft.Azure.WebJobs.Extensions.DurableTask;

namespace SFA.DAS.Funding.PaymentsV2Adapter.TestHelpers;

public interface IOrchestrationData
{
    DurableOrchestrationStatus Status { get; set; }
    object Entity { get; set; }
}