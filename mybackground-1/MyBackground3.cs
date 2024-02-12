using System.Diagnostics;

namespace razor_1
{
  public class MyBackground3 : IHostedLifecycleService
  {
    private readonly ILogger<MyBackground3> logger;

    public MyBackground3(ILogger<MyBackground3> logger)
    {
      this.logger = logger; 
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
      logger.LogInformation("====MyBackground3===StartAsync===");
    }

    public async Task StartedAsync(CancellationToken cancellationToken)
    {
      logger.LogInformation("====MyBackground3===StartedAsync===");
    }

    public async Task StartingAsync(CancellationToken cancellationToken)
    {
      logger.LogInformation("====MyBackground3===StartingAsync===");
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
      logger.LogInformation("====MyBackground3===StopAsync===");
    }

    public async Task StoppedAsync(CancellationToken cancellationToken)
    {
      logger.LogInformation("====MyBackground3===StoppedAsync===");
    }

    public async Task StoppingAsync(CancellationToken cancellationToken)
    {
      logger.LogInformation("====MyBackground3===StoppingAsync===");
    }
  }
}
