using CoreMVCDemo.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddXmlSerializerFormatters();

builder.Services.AddDbContextPool<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("EmployeeDBConnection")));

builder.Services.AddScoped<IEmployeeRepository, SQLEmployeeRepository>();

builder.Services.AddAuthentication();
builder.Services.AddIdentity<IdentityUser, IdentityRole>(option =>
   {
       //Setting Password complexity, length and other options on register screen
       option.Password.RequiredLength = 10;
       option.Password.RequiredUniqueChars = 3;
   }).AddEntityFrameworkStores<AppDbContext>();

//Another way to configure password options
//builder.Services.Configure<IdentityOptions>(options =>
//{
//    options.Password.RequiredLength = 10;
//    options.Password.RequiredUniqueChars = 3;
//});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else if(app.Environment.IsDevelopment())
{
    //for non success code redirect to below url
    app.UseStatusCodePagesWithReExecute("/Error/{0}");
}

app.UseHttpsRedirection();
app.UseStaticFiles();


app.UseRouting();

app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
