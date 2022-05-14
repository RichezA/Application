// <copyright file="AppDbContext.cs" company="RichezA">
// Copyright (c) RichezA. All rights reserved.
// </copyright>

namespace RichezA.Website.Data.Providers.Sql;

using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
}