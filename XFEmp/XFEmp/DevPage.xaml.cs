﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFEmp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DevPage : ContentPage
    {
        public DevPage()
        {
            InitializeComponent();
            // Content in code:
            //Content = new Label()
            //{
            //    HorizontalOptions = LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.Center,
            //    Text = "Hello"
            //};
        }
        
    }
}