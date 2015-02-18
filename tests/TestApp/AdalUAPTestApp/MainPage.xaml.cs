﻿using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TestApp.PCL;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AdalUAPTestApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private TokenBroker tokenBroker;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            this.AccessToken.Text = string.Empty;
            string token = await tokenBroker.GetTokenInteractiveAsync(new AuthorizationParameters(PromptBehavior.Auto, false));
            this.AccessToken.Text = token;
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.AccessToken.Text = string.Empty;
            string token = await tokenBroker.GetTokenWithUsernamePasswordAsync();
            this.AccessToken.Text = token;
        }

        private async void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.AccessToken.Text = string.Empty;
            string token = await tokenBroker.GetTokenInteractiveWithMsAppAsync(new AuthorizationParameters(PromptBehavior.Auto, false));
            this.AccessToken.Text = token;
        }

        private async void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.AccessToken.Text = string.Empty;
            string token = await tokenBroker.GetTokenWithClientCredentialAsync();
            this.AccessToken.Text = token;
        }
    }
}