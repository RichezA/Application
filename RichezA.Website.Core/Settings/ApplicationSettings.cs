// <copyright file="ApplicationSettings.cs" company="RichezA">
// Copyright (c) RichezA. All rights reserved.
// </copyright>

namespace RichezA.Website.Core.Settings;

/// <summary>
/// Contains the settings for the whole application.
/// </summary>
public record ApplicationSettings
{
    /// <summary>
    /// Gets the connection string.
    /// </summary>
    public string ConnectionString { get; init; }
}