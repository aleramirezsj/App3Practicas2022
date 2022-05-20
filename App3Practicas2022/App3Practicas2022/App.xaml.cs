using System;
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
        //método que se ejecuta cuando la app inicia
        protected override void OnStart()
        {
        }
        //método que se ejecuta cuando nos vamos de la App, pero la dejamos corriendo en segundo plano(en memoria)
        protected override void OnSleep()
        {
        }
        //método que se ejecuta cuando volvemos a la App luego de haberla dejado en segundo plano
        protected override void OnResume()
        {
        }
    }
}
