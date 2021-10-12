﻿using System;
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

namespace DiscordWebhookQM.Windows
{
    public partial class WebhookListItem : UserControl
    {
        MainWindow MainWindow;

        public WebhookListItem(MainWindow mainWindow)
        {
            InitializeComponent();

            MainWindow = mainWindow;
        }

        private void B_DeleteWebhook_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.SP_WebhooksList.Children.Remove(this);
        }
    }
}