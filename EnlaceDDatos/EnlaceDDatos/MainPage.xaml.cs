﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EnlaceDDatos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCliked(object sender, EventArgs e)
        {
            var datos1 = Resources["Datos1"] as Datos;
            datos1.Discos.Add(new Disco(){Banda = "Nirvana", Titulo = "Nevermind"});
        }
    }
}
