
using System.Diagnostics;

namespace razor_1
{
  public class MyBackground2 : IHostedService
  {
    private readonly ILogger<MyBackground2> logger;

    public MyBackground2(ILogger<MyBackground2> logger)
    {
      this.logger = logger; 
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
      logger.LogInformation("====MyBackground2===StartAsync===");
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
      logger.LogInformation("====MyBackground2===StopAsync===");
    }
  }
}
