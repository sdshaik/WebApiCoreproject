using WebApiCoreproject.Extensions;
using Microsoft.AspNetCore.HttpOverrides;
using WebApiCoreproject.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using WebApiCoreproject.Models.Repository;
using WebApiCoreproject.Models.DataManager;

var builder = WebApplication.CreateBuilder(args);
builder.Services.ConfigureCors();
builder.Services.ConfigureIISIntegration();
builder.Services.AddDbContext<EmpContext>(opts => opts.UseSqlServer(builder.Configuration["ConnectionStrings:EmployeeDB"]));
builder.Services.AddScoped<IDataRepository<Employee>, EmpManager>();
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
    app.UseDeveloperExceptionPage();
else
    app.UseHsts();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.All
});
app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();