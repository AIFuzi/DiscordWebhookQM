using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DiscordWebhookQM.Module
{
    class WebhookWorker
    {
        public static byte[] Send(string Url, NameValueCollection Pairs)
        {
            try
            {
                WebClient webClient = new WebClient();
                return webClient.UploadValues(Url, Pairs);
            }
            catch (Exception e)
            {
                ShowError(e);
                return null;
            }
        }

        private static void ShowError(Exception ErrorMessage)
        {
            MessageBox.Show("Error", ErrorMessage.Message, MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
