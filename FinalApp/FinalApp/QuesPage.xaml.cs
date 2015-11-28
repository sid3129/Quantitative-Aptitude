using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media;
using FinalApp.ViewModels;
using FinalApp.Resources;

namespace FinalApp
{
    public partial class QuesPage : PhoneApplicationPage
    {
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            GenerateQuestion();       
            HeaderText.Text = App.data.Id.ToString() + "/" + App.max.ToString();
            reset();
            QuestionText.Text = App.data.Question;
            OptionButton1.Content = App.data.Option1;
            OptionButton2.Content = App.data.Option2;
            OptionButton3.Content = App.data.Option3;
            OptionButton4.Content = App.data.Option4;
        }
        public QuesPage()
        {
          //  App.ctr1 = 1;
            //TitleText.Text=QuesGroup.GenerateTitle(App.lesson);
            App.max = QuesGroup.GenerateMaximum(App.lesson);
            BuildLocalizedApplicationBar();
            InitializeComponent();
            DataContext = App.data;
        }
        
        
        private void GenerateQuestion()
        {
            switch(App.lesson)
            {
                case 1:
                    {
                        App.data = QuesGroup.CreateNumbersQuestion(App.ctr1);
                        break;
                    }
                case 2:
                    {
                        App.data = QuesGroup.CreateHCFandLCMQuestion(App.ctr1);
                        break;
                    }
                case 3:
                    {
                        App.data = QuesGroup.CreateAverageQuestion(App.ctr1);
                        break;
                    }
                case 4:
                    {
                        App.data = QuesGroup.CreateoddOneOutQuestion(App.ctr1);
                        break;
                    }
                case 5:
                    {
                        App.data = QuesGroup.CreatePercentageQuestion(App.ctr1);
                        break;
                    }
            }

        }


        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            if(App.data!=null)
            { 
            int x = 0;

            if (OptionButton1.IsChecked == true)
                x = 1;
            else if (OptionButton2.IsChecked == true)
                x = 2;
            else if (OptionButton3.IsChecked == true)
                x = 3;
            else if (OptionButton4.IsChecked == true)
                x = 4;

            if (OptionButton1.IsChecked == true && App.data.Answer != 1)
                OptionButton1.Foreground = new SolidColorBrush(Colors.Red);
            else if (OptionButton2.IsChecked == true && App.data.Answer != 2)
                OptionButton2.Foreground = new SolidColorBrush(Colors.Red);
            else if (OptionButton3.IsChecked == true && App.data.Answer != 3)
                OptionButton3.Foreground = new SolidColorBrush(Colors.Red);
            else if (OptionButton4.IsChecked == true && App.data.Answer != 4)
                OptionButton4.Foreground = new SolidColorBrush(Colors.Red);

            if (App.data.Answer == 1)
                OptionButton1.Foreground = new SolidColorBrush(Colors.Green);
            else if (App.data.Answer == 2)
                OptionButton2.Foreground = new SolidColorBrush(Colors.Green);
            else if (App.data.Answer == 3)
                OptionButton3.Foreground = new SolidColorBrush(Colors.Green);
            else if (App.data.Answer == 4)
                OptionButton4.Foreground = new SolidColorBrush(Colors.Green);


            if (x == App.data.Answer)
                SubmitButton.Content = "Correct";
            else if (x != 0)
                SubmitButton.Content = "Wrong";
        }
        }

        private void reset()
        {
            SubmitButton.Content = "Submit";
            OptionButton1.IsChecked = false;
            OptionButton2.IsChecked = false;
            OptionButton3.IsChecked = false;
            OptionButton4.IsChecked = false;
            OptionButton1.Foreground = new SolidColorBrush(Colors.White);
            OptionButton2.Foreground = new SolidColorBrush(Colors.White);
            OptionButton3.Foreground = new SolidColorBrush(Colors.White);
            OptionButton4.Foreground = new SolidColorBrush(Colors.White);
        }

        private void BuildLocalizedApplicationBar()
        {
            // Set the page's ApplicationBar to a new instance of ApplicationBar.
            ApplicationBar = new ApplicationBar();

            // Create a new button and set the text value to the localized string from AppResources.

            ApplicationBarIconButton PrevButton = new ApplicationBarIconButton(new Uri("/Assets/icons/prev.png", UriKind.Relative));
            PrevButton.Text = "Previous";
            ApplicationBar.Buttons.Add(PrevButton);
            PrevButton.Click += PrevButton_Click;



            ApplicationBarIconButton HintButton = new ApplicationBarIconButton(new Uri("/Assets/icons/hint.png", UriKind.Relative));
            HintButton.Text = "Hint";
            ApplicationBar.Buttons.Add(HintButton);
            HintButton.Click += HintButton_Click;

            ApplicationBarIconButton JumpButton = new ApplicationBarIconButton(new Uri("/Assets/icons/goto.png", UriKind.Relative));
            JumpButton.Text = "Jump To";
            ApplicationBar.Buttons.Add(JumpButton);
            JumpButton.Click += JumpButton_Click;

            ApplicationBarIconButton NextButton = new ApplicationBarIconButton(new Uri("/Assets/icons/next.png", UriKind.Relative));
            NextButton.Text = "Next";
            ApplicationBar.Buttons.Add(NextButton);
            NextButton.Click += NextButton_Click;

            //ApplicationBarIconButton ResetButton = new ApplicationBarIconButton(new Uri("/Assets/reset.png", UriKind.Relative));
            //ResetButton.Text = "Reset";
            //ApplicationBar.Buttons.Add(ResetButton);
            //ResetButton.Click += ResetButton_Click;
            
            
             //Create a new menu item with the localized string from AppResources.
            ApplicationBarMenuItem appBarMenuReset = new ApplicationBarMenuItem("Reset Question");
            ApplicationBar.MenuItems.Add(appBarMenuReset);
            appBarMenuReset.Click += appBarMenuReset_Click;
        }

        void appBarMenuReset_Click(object sender, EventArgs e)
        {
            reset();
            //throw new NotImplementedException();
        }

        void NextButton_Click(object sender, EventArgs e)
        {
            App.ctr1++;
            GenerateQuestion();
            if (App.data != null)
            {
                reset();
                QuestionText.Text = App.data.Question;
                OptionButton1.Content = App.data.Option1;
                OptionButton2.Content = App.data.Option2;
                OptionButton3.Content = App.data.Option3;
                OptionButton4.Content = App.data.Option4;
                HeaderText.Text = App.data.Id.ToString() + "/" + App.max.ToString();
            }
            else
            {
                App.ctr1--;
                GenerateQuestion();
            }
            //throw new NotImplementedException();
        }
        void PrevButton_Click(object sender, EventArgs e)
        {
            App.ctr1--;
            if (App.ctr1 < 1)
                App.ctr1 = 1;
            GenerateQuestion();
            if (App.data != null)
            {
                reset();
                QuestionText.Text = App.data.Question;
                OptionButton1.Content = App.data.Option1;
                OptionButton2.Content = App.data.Option2;
                OptionButton3.Content = App.data.Option3;
                OptionButton4.Content = App.data.Option4;
                HeaderText.Text = App.data.Id.ToString() + "/" + App.max.ToString();
            }
            else
                App.ctr1++;
           // throw new NotImplementedException();
        }
        void ResetButton_Click(object sender, EventArgs e)
        {
            reset();
            //throw new NotImplementedException();
        }
        void HintButton_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/HintPage.xaml", UriKind.Relative));
            //throw new NotImplementedException();
        }
        void JumpButton_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/GotoPage.xaml", UriKind.Relative));
            //throw new NotImplementedException();
        }


    }
}