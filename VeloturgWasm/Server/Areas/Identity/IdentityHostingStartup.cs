using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VeloturgWasm.Server.Data;
using VeloturgWasm.Server.Models;

[assembly: HostingStartup(typeof(VeloturgWasm.Server.Areas.Identity.IdentityHostingStartup))]
namespace VeloturgWasm.Server.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}