using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Real_Time
{
   public interface ITypedHubClient
    {
        Task BroadcastMessage(string type, string payload);
        Task SendMessage(string user, string message);
    }
}
