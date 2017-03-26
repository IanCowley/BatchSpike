using System;
using BatchDomain.Commands;
using DeadSimpleES;

namespace BatchDomain
{
    public class BatchBootStrapper
    {
        readonly ICommandBus _commandBus;

        public BatchBootStrapper(ICommandBus commandBus)
        {
            _commandBus = commandBus;
        }

        public void SeedDomain()
        {
            _commandBus.Send("icowleybatch",
                new StartTrackingBatchAccount(
                "icowleybatch", 
                "https://icowleybatch.northeurope.batch.azure.com", 
                "8wtEaN+qAsD6ahlbGQBj/aGxqaXw1lOU4DgTwEB+E13jFfHrNJ4pOZjNvMU6/LVw6JQ9CpdvwyNd/Ii8k1n8MA=="));
        }
    }
}
