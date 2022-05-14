// <copyright file="LanguageRequest.cs" company="RichezA">
// Copyright (c) RichezA. All rights reserved.
// </copyright>

namespace RichezA.Website.Backend.Models;

public record LanguageRequest
{
    /// <summary>
    /// Gets the english property.
    /// </summary>
    public string English { get; init; }

    /// <summary>
    /// Gets the iso code property.
    /// </summary>
    public string Alpha2 { get; init; }
}