using nq_blazor_test.Presentation.Data;
using nq_blazor_test.Infrastructure;
using nq_blazor_test.Application;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplication()
                .AddInfrastructureServices();
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
