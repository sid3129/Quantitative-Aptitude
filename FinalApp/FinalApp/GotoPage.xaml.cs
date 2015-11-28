using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using FinalApp.ViewModels;

namespace FinalApp
{
    public partial class GotoPage : PhoneApplicationPage
    {
        public GotoPage()
        {
            InitializeComponent();
            App.model.items.Clear();
            App.model.Load(App.max);
            
            MyList.DataContext = App.model;  
  
        }

        private void MyList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LongListSelector selector = sender as LongListSelector;
            if(selector==null)
                return;
            GotoQues ob = selector.SelectedItem as GotoQues;
            if(ob==null)
                return;
            App.ctr1 = int.Parse(ob.number);
            if (NavigationService.CanGoBack == true)
                NavigationService.GoBack();
            

        }


    }
}