using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalRCore2
{
    public class Chat : Hub
    {
        public Task Send(string data)
        {
            return Clients.All.InvokeAsync("AddMessage", data);
        }
    }
}