﻿using ContosoCrafts.Website.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllers(); // Add a controller Service for the API
builder.Services.AddTransient<IJsonFileProductService, JsonFileProductService>();

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
app.MapControllers(); //Map the Controller endpoints

//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapGet("/products",(context) =>
//    {
//        var products = app.ApplicationServices.GetServices<JsonFileProductService>
//    });
//});


app.Run();

