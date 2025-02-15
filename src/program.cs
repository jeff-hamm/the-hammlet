using System.Reflection;
using Destructurama;
using Hammlet.NetDaemon.Models;
using Microsoft.Extensions.Hosting;
using NetDaemon.Extensions.Logging;
using NetDaemon.Extensions.Scheduler;
using NetDaemon.Extensions.Tts;
using NetDaemon.HassModel.Entities;
using NetDaemon.Runtime;
using Serilog;
using Serilog.Events;
using Serilog.FluentDestructuring;

#pragma warning disable CA1812

try
{
    await Host.CreateDefaultBuilder(args)
        .UseNetDaemonAppSettings()
        .UseSerilog(((c, sp, cfg) =>
        {
            cfg.ReadFrom.Configuration(c.Configuration)
                .MinimumLevel.Override("Microsoft", LogEventLevel.Warning).MinimumLevel.Override("System.Net.Http.HttpClient", LogEventLevel.Warning).Enrich.FromLogContext()
                .Destructure.ByIgnoringPropertiesOfTypeAssignableTo<IHaContext>()
                .Destructure.ByIgnoring<EntityState>(o => o.Ignore(s => s.AttributesJson).Ignore(s => s.Context));
        }))
        .UseNetDaemonDefaultLogging()
        .UseNetDaemonRuntime()
        .UseNetDaemonTextToSpeech()
        .ConfigureServices((_, services) =>
            services
                .AddAppsFromAssembly(Assembly.GetExecutingAssembly())
                .AddNetDaemonStateManager()
                .AddNetDaemonScheduler()
                .AddHomeAssistantGenerated()
        )
        .Build()
        .RunAsync()
        .ConfigureAwait(false);
}
catch (Exception e)
{
    Console.WriteLine($"Failed to start host... {e}");
    throw;
}