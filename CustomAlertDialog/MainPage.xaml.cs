﻿using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CustomAlertDialog
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btnalert.Clicked += Btnalert_Clicked;
        }

        private async void Btnalert_Clicked(object sender, EventArgs e)
        {
            var alert = DependencyService.Get<IDialogs>();
            alert.Show("Soy un alert dialogs");
            await Task.Delay(TimeSpan.FromSeconds(10));
            alert.Hide();
        }
    }
}
