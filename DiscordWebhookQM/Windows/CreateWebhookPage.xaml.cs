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

namespace DiscordWebhookQM.Windows
{
    public partial class CreateWebhookPage : UserControl
    {
        MainWindow MainWindow;

        public CreateWebhookPage(MainWindow main)
        {
            InitializeComponent();

            MainWindow = main;
        }

        private void B_CreateWebhook_Click(object sender, RoutedEventArgs e)
        {
            WebhookDataModule wDataModule = new WebhookDataModule();
            wDataModule.InitWebhookModule();
            wDataModule.CreateWebhookData(TBx_WebhookName.Text, TBx_WebhoolURL.Text, null);
            wDataModule.RefreshWebhooksList(MainWindow);
        }
    }
}
