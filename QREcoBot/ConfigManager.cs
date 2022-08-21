using YamlDotNet.Serialization;

namespace QREcoBot
{
    /// <summary>
    /// Singletone instance that manage the configurations of the bot.
    /// </summary>
    class ConfigManager
    {
        public static ConfigManager Instance { get; private set; } = new ConfigManager();

        /// <summary>
        /// Token of the bot to login to Telegram server.
        /// </summary>
        public string Token { get; private set; } = "";

        public ConfigManager()
        {
            const string path = "./config.yaml";

            var document = new StreamReader(File.OpenRead(path));
            var configs = new Deserializer().Deserialize(document);

            if (configs == null) throw new FileNotFoundException("Configuration file not found.");

            Token = ReadNode(configs, "token") as string ?? "";
        }

        /// <summary>
        /// Parse and return values in a specified node.
        /// </summary>
        /// <param name="node">Node to parse.</param>
        /// <param name="key">Key to search</param>
        /// <returns>Children nodes associated to node or null if not found.</returns>
        private object? ReadNode(object node, string key)
        {
            return (from itr in node as IDictionary<object, object>
                    where itr.Key as string == key
                    select itr.Value).FirstOrDefault();
        }
    }
}