using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace FluorineFx.Net
{
    public interface IProxyClient
    {
        TcpClient CreateConnection(Uri uri);
    }

    public interface IProxyClientFactory
    {
        IProxyClient CreateProxyClient(ProxyType type, Uri uri);
    }
}
