﻿#pragma checksum "C:\Users\siddarth\documents\visual studio 2013\Projects\FinalApp\FinalApp\QuesPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "88E5846427B27522AECA84FF5D39B919"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.33440
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace FinalApp {
    
    
    public partial class QuesPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.StackPanel Contentstack;
        
        internal System.Windows.Controls.TextBlock HeaderText;
        
        internal System.Windows.Controls.TextBlock QuestionText;
        
        internal System.Windows.Controls.RadioButton OptionButton1;
        
        internal System.Windows.Controls.RadioButton OptionButton2;
        
        internal System.Windows.Controls.RadioButton OptionButton3;
        
        internal System.Windows.Controls.RadioButton OptionButton4;
        
        internal System.Windows.Controls.Button SubmitButton;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/FinalApp;component/QuesPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.Contentstack = ((System.Windows.Controls.StackPanel)(this.FindName("Contentstack")));
            this.HeaderText = ((System.Windows.Controls.TextBlock)(this.FindName("HeaderText")));
            this.QuestionText = ((System.Windows.Controls.TextBlock)(this.FindName("QuestionText")));
            this.OptionButton1 = ((System.Windows.Controls.RadioButton)(this.FindName("OptionButton1")));
            this.OptionButton2 = ((System.Windows.Controls.RadioButton)(this.FindName("OptionButton2")));
            this.OptionButton3 = ((System.Windows.Controls.RadioButton)(this.FindName("OptionButton3")));
            this.OptionButton4 = ((System.Windows.Controls.RadioButton)(this.FindName("OptionButton4")));
            this.SubmitButton = ((System.Windows.Controls.Button)(this.FindName("SubmitButton")));
        }
    }
}

