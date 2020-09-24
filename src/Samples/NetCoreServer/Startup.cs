using System;
using CoreWCF;
using CoreWCF.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace NetCoreServer
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddServiceModelServices();
        }
        
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseServiceModel(builder =>
            {
<<<<<<< HEAD
/*
                builder.AddService<EchoService>();
                builder.AddServiceEndpoint<EchoService, Contract.IEchoService>(new BasicHttpBinding(), "/basichttp");
                builder.AddServiceEndpoint<EchoService, Contract.IEchoService>(new NetTcpBinding(), "/nettcp");
*/
                builder.AddService(typeof(EchoService));
                builder.AddServiceEndpoint(typeof(EchoService), typeof(Contract.IEchoService), new NetTcpBinding(), new Uri("/nettcp", UriKind.Relative), null);
=======
                builder
                    .AddService<EchoService>()
                    .AddServiceEndpoint<EchoService, Contract.IEchoService>(new BasicHttpBinding(), "/basichttp")
                    .AddServiceEndpoint<EchoService, Contract.IEchoService>(new NetTcpBinding(), "/nettcp");
>>>>>>> master
            });
        }
    }
}
