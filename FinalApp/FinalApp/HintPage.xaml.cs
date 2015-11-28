using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace FinalApp
{
    public partial class HintPage : PhoneApplicationPage
    {
        public HintPage()
        {
            InitializeComponent();
               
            DataContext = App.data;
            AnswerText.Text = "Answer is " + App.data.Answer.ToString() + ")";
        }
    }
}