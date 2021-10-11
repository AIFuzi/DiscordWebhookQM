using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DiscordWebhookQM.Module;

namespace DiscordWebhookQM
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void B_SendMessage_Click(object sender, RoutedEventArgs e)
        {
            SendMessageWebhook("https://discord.com/api/webhooks/897063901315878912/DdD6cveWeq1lX9QBpLRVI5PO1sBSOASXRXut8T9-UlFiWdLylxxOgxMq4pRmhoQwFewB", TB_TextMessage.Text, "");
        }

        private static void SendMessageWebhook(string Url, string Message, string Username)
        {
            WebhookWorker.Send(Url, new NameValueCollection()
            {
                {
                    "username", Username
                },
                {
                    "content", Message
                }
            });
        }
    }
}
