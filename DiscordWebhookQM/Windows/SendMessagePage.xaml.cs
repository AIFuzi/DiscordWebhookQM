using System.Windows;
using System.Windows.Controls;
using DiscordWebhookQM.Modules;

namespace DiscordWebhookQM.Windows
{
    public partial class SendMessagePage : UserControl
    {
        public SendMessagePage(string webhookName)
        {
            InitializeComponent();

            TB_WebhookNameTitle.Text = webhookName;
        }

        private void SendMessagePage_Loaded(object sender, RoutedEventArgs e)
        {
            WebhookDataModule webhookData = new WebhookDataModule();
            TBx_WebhookURL.Text = webhookData.GetWebhookURLByName(TB_WebhookNameTitle.Text);
        }

        private void B_SendMessage_Click(object sender, RoutedEventArgs e)
        {
            WebhookMessageModule webhookMessage = new WebhookMessageModule();
            webhookMessage.SendMessage(TBx_Message.Text, TBx_WebhookURL.Text, TBx_ImageUrl.Text);
        }
    }
}
