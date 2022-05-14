// <copyright file="BaseBackendController.cs" company="RichezA">
// Copyright (c) RichezA. All rights reserved.
// </copyright>

namespace RichezA.Website.Backend.Controllers;

using Microsoft.AspNetCore.Mvc;

[Route("/api/[controller]/[action]")]
[ApiExplorerSettings(GroupName = "Backend")]
public abstract class BaseBackendController : ControllerBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BaseBackendController"/> class.
    /// </summary>
    public BaseBackendController()
    {
    }
}