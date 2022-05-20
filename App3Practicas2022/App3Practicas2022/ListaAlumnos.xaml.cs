using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3Practicas2022
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaAlumnos : ContentPage
    {
        public ListaAlumnos()
        {
            InitializeComponent();
        }
        private void PonerEnMayúsculas(object sender, EventArgs args )
        {
            lblTitulo.Text = lblTitulo.Text.ToUpper();
        }
        private void PonerEnMinúsculas(object sender, EventArgs args)
        {
            lblTitulo.Text = lblTitulo.Text.ToLower();
        }
    }
}