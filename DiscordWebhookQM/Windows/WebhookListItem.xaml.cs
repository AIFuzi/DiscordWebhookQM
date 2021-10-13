using System;
using System.Collections.Generic;
using System.Linq;
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
using DiscordWebhookQM.Modules;
//using System.Windows.Forms;

namespace DiscordWebhookQM.Windows
{
    public partial class WebhookListItem : UserControl
    {
        MainWindow MainWindow;

        public WebhookListItem(MainWindow mainWindow, string WebhookName)
        {
            InitializeComponent();

            MainWindow = mainWindow;
            TB_WebhookName.Text = WebhookName;
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
            }
        }
    }
}
