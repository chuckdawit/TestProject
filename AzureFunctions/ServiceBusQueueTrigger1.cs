using System;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Azure.Functions
{
    public static class ServiceBusQueueTrigger1
    {
        [Function("ServiceBusQueueTrigger1")]
        public static void Run([ServiceBusTrigger("myqueue", Connection = "yogabandySB_SERVICEBUS")] string myQueueItem, FunctionContext context)
        {
            var logger = context.GetLogger("ServiceBusQueueTrigger1");
            logger.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
        }
    }
}
