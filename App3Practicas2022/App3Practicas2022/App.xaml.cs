﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3Practicas2022
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ListaAlumnos();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
