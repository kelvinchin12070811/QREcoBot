/***********************************************************************************************************************
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 **********************************************************************************************************************/
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