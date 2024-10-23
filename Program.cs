using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using InventoryBeginners.Data;
using InventoryBeginners.Interfaces;
using InventoryBeginners.Repositories;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Thêm dịch vụ vào container
builder.Services.AddControllersWithViews();

// Đăng ký các repository
builder.Services.AddScoped<IUnit, UnitRepository>();
builder.Services.AddScoped<IProduct, ProductRepo>();
builder.Services.AddScoped<ISupplier, SupplierRepo>();
builder.Services.AddScoped<ICategory, CategoryRepo>();
builder.Services.AddScoped<IBrand, BrandRepo>();
builder.Services.AddScoped<IProductProfile, ProductProfileRepo>();
builder.Services.AddScoped<IProductGroup, ProductGroupRepo>();

// Thiết lập DbContext
builder.Services.AddDbContext<InventoryContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("dbconn")));

// Cấu hình Identity
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<InventoryContext>();

var app = builder.Build();

// Cấu hình middleware
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

// Định tuyến
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();

//Hello, tôi đang test việc sửa đổi project để đồng bộ lên github, hi vọng sẽ thành công