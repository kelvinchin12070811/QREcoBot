using Telegram.Bot;
using YamlDotNet.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace QREcoBot
{
    class Program
    {
        public static void Main(string[] args) => new Program().MainAsync(args).GetAwaiter();

        public async Task MainAsync(string[] args)
        {
            using var config = new StreamReader(File.OpenRead("./config.yaml"));
            var document = new Deserializer().Deserialize(config);

            if (document == null)
            {
                Console.WriteLine($"Error cannot open config file.");
                return;
            }

            var token = (from key in document as IDictionary<object, object>
                         where key.Key as string == "token"
                         select key.Value).FirstOrDefault() as string ?? "";

            Console.WriteLine($"Token is {token}");
        }
    }
}