using BackendProject.Data;
using BackendProject.Services;
using BackendProject.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAutoMapper(typeof(Program));

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSession();
builder.Services.AddDbContext<AppDbContext>(options =>
       options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddScoped<ISliderService, SliderService>();
builder.Services.AddScoped<IAdvertService, AdvertService>();
builder.Services.AddScoped<IReviewService, ReviewService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ISettingService, SettingService>();
builder.Services.AddScoped<ILayoutService, LayoutService>();
builder.Services.AddScoped<IBlogService, BlogService>();
builder.Services.AddScoped<ITagService, TagService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();


app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
