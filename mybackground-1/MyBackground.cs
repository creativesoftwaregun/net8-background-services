
using System.Diagnostics;

namespace razor_1
{
  public class MyBackground : BackgroundService
  {
    protected async override Task ExecuteAsync(CancellationToken stoppingToken)
    {
      while(!stoppingToken.IsCancellationRequested) {
        Debug.WriteLine("====MyBackground===ExecuteAsync");
        await Task.Delay(1000);
      }
    }
  }
}
