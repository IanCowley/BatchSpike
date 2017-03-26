using DeadSimpleES;

namespace BatchDomain.Commands
{
    public class StartTrackingBatchAccount : ICommand
    {
        public string BatchAccountName { get; }
        public string BatchAccountUrl { get; }
        public string BatchAccountKey { get; }

        public StartTrackingBatchAccount(string batchAccountName, string batchAccountUrl, string batchAccountKey)
        {
            BatchAccountName = batchAccountName;
            BatchAccountUrl = batchAccountUrl;
            BatchAccountKey = batchAccountKey;
        }
    }
}
