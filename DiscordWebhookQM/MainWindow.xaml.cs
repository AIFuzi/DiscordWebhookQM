using System;
using System.Windows;
using System.Windows.Input;
using DiscordWebhookQM.Windows;
using DiscordWebhookQM.Modules;

namespace DiscordWebhookQM
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            WebhookDataModule webhookData = new WebhookDataModule();
            webhookData.RefreshWebhooksList(this);

            if (SP_WebhooksList.Children.Count <= 0)
            {
                MessageBox.Show("Нет хуков, создайте =)", "Примечание", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            //else RefreshWebhooksList();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) DragMove(); 
        }

        private void B_SendMessage_Click(object sender, RoutedEventArgs e)
        {

        }

 

        private static void ShowError(Exception ErrorMessage)
        {
            System.Windows.MessageBox.Show(ErrorMessage.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void B_Minimaze_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void B_Exit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Environment.Exit(0);
        }

        private void B_CreateNewWebhook_Click(object sender, RoutedEventArgs e)
        {
            CreateWebhookPage createWebhookPage = new CreateWebhookPage(this);

            SP_MainPage.Children.Clear();
            SP_MainPage.Children.Add(createWebhookPage);
            //WebhookListItem webhookItem = new WebhookListItem(this);
            //SP_WebhooksList.Children.Add(webhookItem);
        }
    }
}
