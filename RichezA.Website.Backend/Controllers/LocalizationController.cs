// <copyright file="LocalizationController.cs" company="RichezA">
// Copyright (c) RichezA. All rights reserved.
// </copyright>

namespace RichezA.Website.Backend.Controllers;

using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RichezA.Website.Backend.Models;

/// <summary>
/// Contains the methods used to manage localizations.
/// </summary>
public class LocalizationController : BaseBackendController
{
    /// <summary>
    /// Gets the available languages.
    /// </summary>
    /// <returns>The available languages.</returns>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Language>>> GetLanguages()
    {
        // TODO: Call database.
        var data = await new HttpClient().GetAsync("https://datahub.io/core/language-codes/r/language-codes.json");

        if (!data.IsSuccessStatusCode)
        {
            return this.BadRequest();
        }

        var values = JsonConvert.DeserializeObject<List<LanguageRequest>>(await data.Content.ReadAsStringAsync());

        if (values is null || !values.Any())
        {
            return this.BadRequest();
        }

        return this.Ok(values.Select((value, index) => new Language(index, value.Alpha2, value.English)));
    }
}