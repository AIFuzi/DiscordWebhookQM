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
        private static string WebhooksAvatars = @"WebhooksAvatars";

        public void InitWebhookModule()
        {
            CheckWebhooksDirectory(WebhooksPath);
            CheckWebhooksDirectory(WebhooksAvatars);
        }

        private void CheckWebhooksDirectory(string directoryPath)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);
            if(!directoryInfo.Exists) directoryInfo.Create();

        }

        public void CreateWebhookData(string webhookName, string webhookURL, string webhookAvatarPath)
        {
            StreamWriter streamWriter = new StreamWriter($"{WebhooksPath}/{webhookName}.dwm");
            streamWriter.Write("adad");
            streamWriter.Close();
        }
    }
}
