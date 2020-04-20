using System;
using System.Threading.Tasks;

namespace facebookBot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var accessToken = "YOUR_GRAPH_API_ACCESS_TOKEN";
            var facebookClient = new FacebookClient();
            var facebookService = new FacebookService(facebookClient);
            var getAccountTask = facebookService.GetAccountAsync(accessToken);

            Task.WaitAll(getAccountTask);
            var account = getAccountTask.Result;
            Console.WriteLine($"{account.Id} {account.Name}");

            var postOnWallTask = facebookService.PostOnWallAsync(accessToken, "Hello from C# .NET Core!");
            Task.WaitAll(postOnWallTask);
        }
    }  
}
