using BookingTour.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


var services = builder.Services;

services.AddRazorPages();
services.AddDbContext<TourContext>(options =>
{
    string url = builder.Configuration.GetConnectionString("TourContext");
    options.UseSqlServer(url);
});

services.AddRazorPages();

services.AddIdentity<AppUser, IdentityRole>()
      .AddEntityFrameworkStores<TourContext>()
      .AddDefaultTokenProviders();

//Identity/Account/Login
// dang ky indentity , role : vai tro


services.Configure<IdentityOptions>(options => {
    // Thiết lập về Password
    options.Password.RequireDigit = false; // Không bắt phải có số
    options.Password.RequireLowercase = false; // Không bắt phải có chữ thường
    options.Password.RequireNonAlphanumeric = false; // Không bắt ký tự đặc biệt
    options.Password.RequireUppercase = false; // Không bắt buộc chữ in
    options.Password.RequiredLength = 3; // Số ký tự tối thiểu của password
    options.Password.RequiredUniqueChars = 1; // Số ký tự riêng biệt

    // Cấu hình Lockout - khóa user
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5); // Khóa 5 phút
    options.Lockout.MaxFailedAccessAttempts = 5; // Thất bại 5 lầ thì khóa
    options.Lockout.AllowedForNewUsers = true;

    // Cấu hình về User.
    options.User.AllowedUserNameCharacters = // các ký tự đặt tên user
        "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
    options.User.RequireUniqueEmail = true;  // Email là duy nhất

    // Cấu hình đăng nhập.
    options.SignIn.RequireConfirmedEmail = true;            // Cấu hình xác thực địa chỉ email (email phải tồn tại)
    options.SignIn.RequireConfirmedPhoneNumber = false;     // Xác thực số điện thoại

});

<<<<<<< HEAD
=======


services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<TourContext>().AddDefaultTokenProviders();
>>>>>>> 65cc4e11405f530c4abb16acba7d152669480f18

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

<<<<<<< HEAD
app.UseAuthentication(); //xac thuc danh tinh

app.UseAuthorization(); // sau khi xac thuc , thi dc lam gi
=======

app.UseAuthentication();
app.UseAuthorization();
>>>>>>> 65cc4e11405f530c4abb16acba7d152669480f18

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

<<<<<<< HEAD
app.MapRazorPages();
=======

>>>>>>> 65cc4e11405f530c4abb16acba7d152669480f18
app.Run();
