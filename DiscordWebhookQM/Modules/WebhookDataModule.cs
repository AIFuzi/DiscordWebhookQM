using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Windows;
using System.Windows.Forms;

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

            string jsonProfileInfo = JsonConvert.SerializeObject(new
            {
                webhookUrl = webhookURL
            });

            streamWriter.Write(jsonProfileInfo);
            streamWriter.Flush();
            streamWriter.Close();
        }

        public string LoadWebhookProfiles()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult dgRes = fileDialog.ShowDialog();
            if(dgRes == DialogResult.OK)
            {
                var path = Path.GetFileName(fileDialog.FileName).Split('.');
                return path[0];
            }

            return null;
        }
    }
}
