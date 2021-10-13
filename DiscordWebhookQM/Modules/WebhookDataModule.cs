using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Windows;
using System.Windows.Forms;
using DiscordWebhookQM.Windows;

namespace DiscordWebhookQM.Modules
{
    public class WebhookDataModule
    {
        public string WebhooksPath = @"WebhooksProfiles";
        public string WebhooksAvatars = @"WebhooksAvatars";

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
                webhookUrl = webhookURL,
                webhookName = webhookName
            });

            streamWriter.Write(jsonProfileInfo);
            streamWriter.Flush();
            streamWriter.Close();
        }

        public string LoadWebhookProfiles()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult dgRes = fileDialog.ShowDialog();
            if (dgRes == DialogResult.OK)
            {
                var path = Path.GetFileName(fileDialog.FileName).Split('.');
                return path[0];
            }

            return null;
        }

        public void RefreshWebhooksList(MainWindow main)
        {
            main.SP_WebhooksList.Children.Clear();
            WebhookListItem webhookList;

            foreach (string currentFileName in Directory.GetFiles(WebhooksPath))
            {
                var path = Path.GetFileName(currentFileName).Split('.');
                main.SP_WebhooksList.Children.Add(webhookList = new WebhookListItem(main, path[0]));
            }
        }

        public void DeleteWebhookProfile(string WebhookName)
        {
            File.Delete($"{WebhooksPath}/{WebhookName}.dwm");
        }
    }
}
