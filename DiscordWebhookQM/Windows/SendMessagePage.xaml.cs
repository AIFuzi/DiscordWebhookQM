using System;
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
            webhookMessage.SendMessage(TBx_Message.Text, TBx_WebhookURL.Text, TBx_ImageUrl.Text, TBx_HexColor.Text);
        }

        private void TBx_Message_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                int index = TBx_Message.SelectionStart;
                TBx_Message.Text = TBx_Message.Text.Substring(0, TBx_Message.SelectionStart) + Environment.NewLine
                    + TBx_Message.Text.Substring(TBx_Message.SelectionStart);
                TBx_Message.SelectionStart = TBx_Message.Text.Length;
            }
        }
    }
}
