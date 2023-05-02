using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StockApp.Models;
using EmbeddedBlazorContent;
using System.Net.Http;
using Microsoft.AspNetCore.Components.Authorization;


namespace StockApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration{get;}
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
        }
    }
}