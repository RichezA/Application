// <copyright file="Language.cs" company="RichezA">
// Copyright (c) RichezA. All rights reserved.
// </copyright>

namespace RichezA.Website.Backend.Models;

using System.ComponentModel.DataAnnotations;

/// <summary>
/// Gets the language viewmodel.
/// </summary>
/// <param name="Id">The identifier.</param>
/// <param name="IsoCode">The iso code.</param>
/// <param name="Name">The name.</param>
public record Language(
    [property: Required]int Id,
    [property: Required]string IsoCode,
    [property: Required]string Name);