using RepositoryExample.Business.Services;
using RepositoryExample.Data.Repositories;
using RepositoryExample.Data.Repositories.IRepositories;
using RepositoryExample.Data.UnitOfWork;

var builder = WebApplication.CreateBuilder(args);

// Register Unit of Work
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();













// Register Services
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<CategoryService>();


// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
