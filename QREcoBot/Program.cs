using Telegram.Bot;
using YamlDotNet.Serialization;

namespace QREcoBot
{
    class Program
    {
        public static void Main(string[] args) => new Program().MainAsync(args).GetAwaiter();

        public async Task MainAsync(string[] args)
        {
            try
            {
                Console.WriteLine($"Token is {ConfigManager.Instance.Token}");
                await Task.Delay(100000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}