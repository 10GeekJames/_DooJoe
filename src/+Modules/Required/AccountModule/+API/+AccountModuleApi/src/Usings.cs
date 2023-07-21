global using Ardalis.ListStartupServices;

global using Autofac;
global using Autofac.Extensions.DependencyInjection;

global using AutoMapper;

global using MediatR;

global using Microsoft.AspNetCore.Authorization;
global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.Mvc;

global using Microsoft.EntityFrameworkCore;
global using Microsoft.IdentityModel.Tokens;
global using Microsoft.OpenApi.Models;

global using Newtonsoft.Json;

global using System;
global using System.Diagnostics;
global using System.Reflection;
global using System.Security.Claims;

global using DooJoe.KernelShared;
global using DooJoe.KernelShared.Configuration;
global using DooJoe.KernelShared.Enums;
global using DooJoe.KernelShared.Interfaces;
global using DooJoe.KernelShared.SharedValueObjects;

global using AccountModuleCore;
global using AccountModuleCore.Entities;

global using AccountModuleInfrastructure;
global using AccountModuleInfrastructure.CommandQuery;
global using AccountModuleInfrastructure.Data;

global using AccountModuleApplication;

global using AccountModuleApplication.Automaps;

global using AccountModuleApplication.Shared.Requests;
global using AccountModuleApplication.Shared.ViewModels;

global using AccountModuleApi.Interfaces;