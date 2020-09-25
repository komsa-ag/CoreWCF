using System.Security.Cryptography.X509Certificates;
using CoreWCF;
using CoreWCF.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace NetCoreServer
{
  public class Startup
  {
    public void ConfigureServices(IServiceCollection services) => services.AddServiceModelServices();

    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      app.UseServiceModel(builder =>
      {
        builder
            .AddService<EchoService>()
            .AddServiceEndpoint<EchoService, Contract.IEchoService>(new BasicHttpBinding(), "/basichttp")
            .AddServiceEndpoint<EchoService, Contract.IEchoService>(CreateBinding(), "/nettcp")
            .ConfigureServiceHostBase<EchoService>(serviceHost =>
              serviceHost.Credentials.ServiceCertificate.SetCertificate(StoreLocation.LocalMachine,
                StoreName.My, X509FindType.FindByIssuerName, "KOMSA ISSUING CA"));
      });

      static NetTcpBinding CreateBinding()
      {
        NetTcpBinding result = new NetTcpBinding();
        result.Security.Mode = SecurityMode.Transport;
        result.Security.Transport.ClientCredentialType = TcpClientCredentialType.None;
        return result;
      }
    }
  }
}