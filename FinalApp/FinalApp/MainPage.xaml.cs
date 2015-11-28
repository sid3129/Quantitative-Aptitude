using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using FinalApp.Resources;
using FinalApp.ViewModels;
using Coding4Fun.Toolkit.Controls;

namespace FinalApp
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            BuildLocalizedApplicationBar();
        }

        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        //    if (!App.ViewModel.IsDataLoaded)
        //    {
        //        App.ViewModel.LoadData();
        //    }
        }


        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            App.lesson = 1;
            NavigationService.Navigate(new Uri("/QuesPage.xaml", UriKind.Relative));
            App.ctr1 = 1;
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            App.lesson = 2;
            NavigationService.Navigate(new Uri("/QuesPage.xaml", UriKind.Relative));
            App.ctr1 = 1;
        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            App.lesson = 3;
            NavigationService.Navigate(new Uri("/QuesPage.xaml", UriKind.Relative));
            App.ctr1 = 1;
        }
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            App.lesson = 4;
            NavigationService.Navigate(new Uri("/QuesPage.xaml", UriKind.Relative));
            App.ctr1 = 1;
        }
        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            App.lesson = 5;
            NavigationService.Navigate(new Uri("/QuesPage.xaml", UriKind.Relative));
            App.ctr1 = 1;
        }
        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            App.lesson = 6;
            NavigationService.Navigate(new Uri("/QuesPage.xaml", UriKind.Relative));
            App.ctr1 = 1;
        }
        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            App.lesson = 7;
            NavigationService.Navigate(new Uri("/QuesPage.xaml", UriKind.Relative));
            App.ctr1 = 1;
        }
        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            App.lesson = 8;
            NavigationService.Navigate(new Uri("/QuesPage.xaml", UriKind.Relative));
            App.ctr1 = 1;
        }
        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            App.lesson = 9;
            NavigationService.Navigate(new Uri("/QuesPage.xaml", UriKind.Relative));
            App.ctr1 = 1;
        } 
        private void Button10_Click(object sender, RoutedEventArgs e)
        {
            App.lesson = 10;
            
            NavigationService.Navigate(new Uri("/QuesPage.xaml", UriKind.Relative));
            App.ctr1 = 1;
        }




         //Sample code for building a localized ApplicationBar
        private void BuildLocalizedApplicationBar()
        {
            // Set the page's ApplicationBar to a new instance of ApplicationBar.
            ApplicationBar = new ApplicationBar();
            ApplicationBar.Mode = ApplicationBarMode.Minimized;
            // Create a new button and set the text value to the localized string from AppResources.
            //ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
            //appBarButton.Text = AppResources.AppBarButtonText;
            //ApplicationBar.Buttons.Add(appBarButton);

             //Create a new menu item with the localized string from AppResources.
            ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem("About Developer");
            ApplicationBar.MenuItems.Add(appBarMenuItem);
            appBarMenuItem.Click += appBarMenuItem_Click;
        }

        void appBarMenuItem_Click(object sender, EventArgs e)
        {
            AboutPrompt AboutMe = new AboutPrompt();
            AboutMe.Show(AppResources.DeveloperName,"",AppResources.DeveloperEmail,AppResources.WindowsStoreLink);

            //AboutPrompt p = new AboutPrompt();
            //p.Title = "Contact Me";
            //AboutPromptItem item = new AboutPromptItem();
            //item.AuthorName = "Siddarth Goyal";
            //item.EmailAddress = @"sid3129@gmail.com";
            //item.Role = "windows phone dev";
            //item.WebSiteUrl = @"www.windowsphonegeek.com";
            //p.Show(item);
            
            //throw new NotImplementedException();
        }
    }
}