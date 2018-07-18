using Microsoft.AspNet.WebHooks;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class GitHubWebHookHandler : WebHookHandler
    {
        public GitHubWebHookHandler()
        {
            this.Receiver = GitHubWebHookReceiver.ReceiverName;
        }
        public override Task ExecuteAsync(string receiver, WebHookHandlerContext context)
        {
            string action = context.Actions.First();
            JObject data = context.GetDataOrDefault<JObject>();

            return Task.FromResult(true);
        }


    }
}


