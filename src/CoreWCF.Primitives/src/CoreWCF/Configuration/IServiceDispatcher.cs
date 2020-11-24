using CoreWCF.Channels;
using CoreWCF.Dispatcher;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CoreWCF.Configuration
{
    public interface IServiceDispatcher
    {
        Uri BaseAddress { get; }
        Binding Binding { get; }
        IList<Type> SupportedChannelTypes { get; }
        ChannelDispatcher ChannelDispatcher { get; }
        Task<IServiceChannelDispatcher> CreateServiceChannelDispatcherAsync(IChannel channel);
    }
}
