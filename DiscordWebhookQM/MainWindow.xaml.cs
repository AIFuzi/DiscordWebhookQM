using System;
using System.Net;
using System.Windows;
using System.Windows.Input;
using System.IO;
using Newtonsoft.Json;

namespace DiscordWebhookQM
{
    public partial class MainWindow : Window
    {
        private string WebhookUrl = "https://discord.com/api/webhooks/897063901315878912/DdD6cveWeq1lX9QBpLRVI5PO1sBSOASXRXut8T9-UlFiWdLylxxOgxMq4pRmhoQwFewB";
        private WebRequest wRequest;

        public MainWindow()
        {
            InitializeComponent();

            
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) DragMove(); 
        }

        private void B_SendMessage_Click(object sender, RoutedEventArgs e)
        {
            InitWebTH();
            SendMessage(TB_TextMessage.Text, TB_ImageUrl.Text);
            ClearWebTH();
        }

        private void SendMessage(string Message, string ImageUrl)
        {
            string hrx = "e67e22";
            int col = Convert.ToInt32(hrx, 16);

            try
            {
                using (var messageWriter = new StreamWriter(wRequest.GetRequestStream()))
                {
                    string jsonMsg = JsonConvert.SerializeObject(new
                    {
                        username = "",
                        content = Message,
                        embeds = new[]
                        {
                            new
                            {
                                title = "",
                                description = "",
                                color = col,
                                image = new { url = TB_ImageUrl.Text }
                            }
                        }
                    });

                    messageWriter.Write(jsonMsg);
                }

                var response = (HttpWebResponse)wRequest.GetResponse();
            }
            catch(Exception e)
            {
                ShowError(e);
            }
        }

        private void ClearWebTH()
        {
            wRequest = null;
        }

        private void InitWebTH()
        {
            wRequest = (HttpWebRequest)WebRequest.Create(WebhookUrl);
            wRequest.ContentType = "application/json";
            wRequest.Method = "POST";
        }

        private static void ShowError(Exception ErrorMessage)
        {
            System.Windows.MessageBox.Show(ErrorMessage.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
