using SFA.DAS.Funding.PaymentsV2Adapter.TestHelpers;

namespace SFA.DAS.Funding.PaymentsV2Adapter.AcceptanceTests
{
    public class TestContext : IDisposable
    {
        public TestFunction? TestFunction { get; set; }
        public SqlDatabase? SqlDatabase { get; set; }

        public void Dispose()
        {
            TestFunction?.Dispose();
            SqlDatabase?.Dispose();
        }
    }
}
