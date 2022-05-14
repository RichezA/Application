// <copyright file="Program.cs" company="RichezA">
// Copyright (c) RichezA. All rights reserved.
// </copyright>

using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using RichezA.Website.Core.Settings;
using RichezA.Website.Data.Providers.Sql;

var builder = WebApplication.CreateBuilder(args);
var _config = builder.Configuration;

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(_config["App.ConnectionString"]));

builder.Services.AddOptions<ApplicationSettings>().Bind(_config.GetSection("App"));

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    /*c.CustomOperationIds(e => $"{e.ActionDescriptor.RouteValues["controller"]}_{e.ActionDescriptor.RouteValues["action"]}");*/
    c.SwaggerDoc("Backend", new OpenApiInfo { Title = "Backend", Version = "v1" });
});

/*
builder.Services.AddAuthentication(NegotiateDefaults.AuthenticationScheme)
    .AddNegotiate();

builder.Services.AddAuthorization(options =>
{
    // By default, all incoming requests will be authorized according to the default policy.
    options.FallbackPolicy = options.DefaultPolicy;
});
*/

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/Backend/swagger.json", "Backend");
    });
}

app.UseHttpsRedirection();

/*app.UseAuthentication();
app.UseAuthorization();*/

app.MapControllers();

app.Run();