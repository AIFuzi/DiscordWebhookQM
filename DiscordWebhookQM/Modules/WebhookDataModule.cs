using System;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;
using DiscordWebhookQM.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using Newtonsoft.Json.Linq;

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
                var avatarBitmap = new BitmapImage();

                if (File.Exists($"{WebhooksAvatars}/{path[0]}.jpg"))
                {
                    avatarBitmap.BeginInit();
                    avatarBitmap.UriSource = new Uri($"{WebhooksAvatars}/{path[0]}.jpg", UriKind.RelativeOrAbsolute);
                    avatarBitmap.CacheOption = BitmapCacheOption.OnLoad;
                    avatarBitmap.EndInit();
                }

                var avatarImage = new ImageBrush(avatarBitmap);
                main.SP_WebhooksList.Children.Add(webhookList = new WebhookListItem(main, path[0], avatarImage));
            }
        }

        public void DeleteWebhookProfile(string WebhookName)
        {
            File.Delete($"{WebhooksAvatars}/{WebhookName}.jpg");
            File.Delete($"{WebhooksPath}/{WebhookName}.dwm");
        }
        
        public void SaveAvatar(ImageBrush AvatarImage, string WebhookName)
        {
            BitmapSource avatarImg = (BitmapSource)AvatarImage.ImageSource;
            string avatarPath = $"{WebhooksAvatars}/{WebhookName}.jpg";
            using (FileStream fileStream = new FileStream(avatarPath, FileMode.OpenOrCreate))
            {
                BitmapFrame frame = BitmapFrame.Create(avatarImg);

                JpegBitmapEncoder jpegAvatar = new JpegBitmapEncoder();
                jpegAvatar.Frames.Add(frame);
                jpegAvatar.Save(fileStream);
            }
        }

        public string GetWebhookURLByName(string WebhookName)
        {
            var webhookPath = File.ReadAllText($"{WebhooksPath}/{WebhookName}.dwm"); 
            var jObj = JObject.Parse(webhookPath);
            var res = jObj["webhookUrl"];

            return res.ToString();
        }
    }
}
