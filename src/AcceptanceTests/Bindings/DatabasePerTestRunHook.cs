using SFA.DAS.Funding.PaymentsV2Adapter.TestHelpers;

namespace SFA.DAS.Funding.PaymentsV2Adapter.AcceptanceTests.Bindings
{
    [Binding]
    public static class DatabasePerTestRunHook
    {
        [BeforeTestRun(Order = 1)]
        public static void RefreshDatabaseModel()
        {
            SqlDatabaseModel.Update();
        }
    }
}
