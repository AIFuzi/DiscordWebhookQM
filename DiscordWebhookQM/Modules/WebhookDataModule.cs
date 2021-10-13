using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Windows;

namespace DiscordWebhookQM.Modules
{
    public class WebhookDataModule
    {
        private static string WebhooksPath = @"WebhooksProfiles";

        public void tts()
        {
            CheckWebhooksDirectory();
        }

        private void CheckWebhooksDirectory()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(WebhooksPath);
            if(!directoryInfo.Exists) directoryInfo.Create();

        }

        public void CreateWebhookData(string WebhookName, string WebhookURL)
        {

        }
    }
}
