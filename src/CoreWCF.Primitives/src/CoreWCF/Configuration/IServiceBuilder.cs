using CoreWCF.Channels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreWCF.Configuration
{
    public interface IServiceBuilder
    {
        ICollection<Type> Services { get; }
        ICollection<Uri> BaseAddresses { get; }
<<<<<<< HEAD
        void AddService<TService>() where TService : class;
        void AddService(Type service);
        void AddServiceEndpoint<TService, TContract>(Binding binding, string address);
        void AddServiceEndpoint<TService, TContract>(Binding binding, Uri address);
        void AddServiceEndpoint<TService, TContract>(Binding binding, string address, Uri listenUri);
        void AddServiceEndpoint<TService, TContract>(Binding binding, Uri address, Uri listenUri);
        void AddServiceEndpoint<TService>(Type implementedContract, Binding binding, string address);
        void AddServiceEndpoint<TService>(Type implementedContract, Binding binding, Uri address);
        void AddServiceEndpoint<TService>(Type implementedContract, Binding binding, string address, Uri listenUri);
        void AddServiceEndpoint<TService>(Type implementedContract, Binding binding, Uri address, Uri listenUri);
        void AddServiceEndpoint(Type service, Type implementedContract, Binding binding, Uri address, Uri listenUri);
=======

        IServiceBuilder AddService<TService>() where TService : class;
        IServiceBuilder AddService(Type service);
        IServiceBuilder AddServiceEndpoint<TService, TContract>(Binding binding, string address);
        IServiceBuilder AddServiceEndpoint<TService, TContract>(Binding binding, Uri address);
        IServiceBuilder AddServiceEndpoint<TService, TContract>(Binding binding, string address, Uri listenUri);
        IServiceBuilder AddServiceEndpoint<TService, TContract>(Binding binding, Uri address, Uri listenUri);
        IServiceBuilder AddServiceEndpoint<TService>(Type implementedContract, Binding binding, string address);
        IServiceBuilder AddServiceEndpoint<TService>(Type implementedContract, Binding binding, Uri address);
        IServiceBuilder AddServiceEndpoint<TService>(Type implementedContract, Binding binding, string address, Uri listenUri);
        IServiceBuilder AddServiceEndpoint<TService>(Type implementedContract, Binding binding, Uri address, Uri listenUri);
        IServiceBuilder AddServiceEndpoint(Type service, Type implementedContract, Binding binding, Uri address, Uri listenUri);
>>>>>>> master
    }
}
