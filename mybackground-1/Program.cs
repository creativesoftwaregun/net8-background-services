using razor_1;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<HostOptions>(x =>
{
  x.BackgroundServiceExceptionBehavior = BackgroundServiceExceptionBehavior.Ignore;
  //x.BackgroundServiceExceptionBehavior = BackgroundServiceExceptionBehavior.StopHost;

  x.ServicesStartConcurrently = true;
  x.ServicesStopConcurrently = false;
});

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddHostedService<MyBackground>();
builder.Services.AddHostedService<MyBackground2>();
builder.Services.AddHostedService<MyBackground3>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
  app.UseExceptionHandler("/Error");
  // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
  app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
