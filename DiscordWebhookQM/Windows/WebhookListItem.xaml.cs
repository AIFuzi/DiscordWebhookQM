using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using DiscordWebhookQM.Modules;

namespace DiscordWebhookQM.Windows
{
    public partial class WebhookListItem : UserControl
    {
        MainWindow MainWindow;

        public WebhookListItem(MainWindow mainWindow, string WebhookName, ImageBrush imageAvatar)
        {
            InitializeComponent();

            MainWindow = mainWindow;
            TB_WebhookName.Text = WebhookName;
            if(imageAvatar != null) IB_Avatar.ImageSource = imageAvatar.ImageSource;
        }

        private void B_DeleteWebhook_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.DialogResult dgRes;
            dgRes = (System.Windows.Forms.DialogResult)MessageBox.Show("Вы уверены что хотите удалить вебхук?", "Подтвердите", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (dgRes == System.Windows.Forms.DialogResult.Yes)
            {
                WebhookDataModule webhookData = new WebhookDataModule();
                webhookData.DeleteWebhookProfile(TB_WebhookName.Text);
                webhookData.RefreshWebhooksList(MainWindow);
                IB_Avatar = null;
            }
        }

        private void B_SelectCurrentWebhook_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SendMessagePage sendMessage = new SendMessagePage(TB_WebhookName.Text);

            MainWindow.SP_MainPage.Children.Clear();
            MainWindow.SP_MainPage.Children.Add(sendMessage);
        }

        private void B_SelectCurrentWebhook_MouseEnter(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            B_SelectCurrentWebhook.Background = (Brush)bc.ConvertFrom("#5d5d5d");
        }

        private void B_SelectCurrentWebhook_MouseLeave(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            B_SelectCurrentWebhook.Background = (Brush)bc.ConvertFrom("#212121");
        }
    }
}
