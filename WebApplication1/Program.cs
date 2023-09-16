using GameStore.WebUi.Controllers;
using GameStoreDomain.Abstract;
using GameStoreDomain.Entities;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IGameRepository, GameController>();
builder.Services.AddControllersWithViews();
//builder.Services.AddHttpContextAccessor();
//builder.Services.AddHttpContextAccessor();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//builder.Services.AddScoped<IGameRepository,GameController>();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

//app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Game}/{action=List}/{id?}");

app.Run();
