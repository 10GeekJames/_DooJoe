
global using HealthChecks.UI.Client;

global using Microsoft.AspNetCore.Builder;
global using Microsoft.AspNetCore.Diagnostics.HealthChecks;
global using Microsoft.AspNetCore.Hosting;
global using Microsoft.AspNetCore.Http;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Hosting;

global using System;
global using System.Threading.Tasks;

global using Skoruba.Duende.IdentityServer.Shared.Configuration.Helpers;

global using DooJoe.Identity.Admin.EntityFramework.Shared.DbContexts;
global using DooJoe.Identity.Admin.EntityFramework.Shared.Entities.Identity;

global using DooJoe.Identity.STS.Identity.Configuration;
global using DooJoe.Identity.STS.Identity.Configuration.Constants;
global using DooJoe.Identity.STS.Identity.Configuration.Interfaces;
global using DooJoe.Identity.STS.Identity.Helpers;

global using Duende.IdentityServer.Validation;
global using Duende.IdentityServer.Services;