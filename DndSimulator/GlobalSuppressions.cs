// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Parameter 'req' is necessary to Azure Function", Scope = "member", Target = "~M:DndSimulator.Api.Functions.HelloWorldFunction.HelloWorld(Microsoft.AspNetCore.Http.HttpRequest,Microsoft.Extensions.Logging.ILogger)~Microsoft.AspNetCore.Mvc.IActionResult")]
