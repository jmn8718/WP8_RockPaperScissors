﻿#pragma checksum "C:\Users\JoseMiguel\Documents\Visual Studio 2012\Projects\RockPaperScissors\RockPaperScissors\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "AC90D2CC74B6D7F3FEC8EEC66AC7E2AD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
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


namespace RockPaperScissors {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Grid ScorePanel;
        
        internal System.Windows.Controls.TextBlock textPuntuacion;
        
        internal System.Windows.Controls.Grid Resultados;
        
        internal System.Windows.Controls.TextBlock textVictorias;
        
        internal System.Windows.Controls.TextBlock textVictoriasValor;
        
        internal System.Windows.Controls.TextBlock textEmpates;
        
        internal System.Windows.Controls.TextBlock textEmpatesValor;
        
        internal System.Windows.Controls.TextBlock textDerrotas;
        
        internal System.Windows.Controls.TextBlock textDerrotasValor;
        
        internal System.Windows.Controls.Grid BoardPanel;
        
        internal System.Windows.Controls.Image imagenUsuario;
        
        internal System.Windows.Controls.Image imagenRival;
        
        internal System.Windows.Controls.TextBlock textResultado;
        
        internal System.Windows.Controls.Button botonOtraPartida;
        
        internal System.Windows.Controls.Grid ButtonsPanel;
        
        internal System.Windows.Controls.Button botonPiedra;
        
        internal System.Windows.Controls.Button botonPapel;
        
        internal System.Windows.Controls.Button botonTijera;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton reiniciar;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/RockPaperScissors;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.ScorePanel = ((System.Windows.Controls.Grid)(this.FindName("ScorePanel")));
            this.textPuntuacion = ((System.Windows.Controls.TextBlock)(this.FindName("textPuntuacion")));
            this.Resultados = ((System.Windows.Controls.Grid)(this.FindName("Resultados")));
            this.textVictorias = ((System.Windows.Controls.TextBlock)(this.FindName("textVictorias")));
            this.textVictoriasValor = ((System.Windows.Controls.TextBlock)(this.FindName("textVictoriasValor")));
            this.textEmpates = ((System.Windows.Controls.TextBlock)(this.FindName("textEmpates")));
            this.textEmpatesValor = ((System.Windows.Controls.TextBlock)(this.FindName("textEmpatesValor")));
            this.textDerrotas = ((System.Windows.Controls.TextBlock)(this.FindName("textDerrotas")));
            this.textDerrotasValor = ((System.Windows.Controls.TextBlock)(this.FindName("textDerrotasValor")));
            this.BoardPanel = ((System.Windows.Controls.Grid)(this.FindName("BoardPanel")));
            this.imagenUsuario = ((System.Windows.Controls.Image)(this.FindName("imagenUsuario")));
            this.imagenRival = ((System.Windows.Controls.Image)(this.FindName("imagenRival")));
            this.textResultado = ((System.Windows.Controls.TextBlock)(this.FindName("textResultado")));
            this.botonOtraPartida = ((System.Windows.Controls.Button)(this.FindName("botonOtraPartida")));
            this.ButtonsPanel = ((System.Windows.Controls.Grid)(this.FindName("ButtonsPanel")));
            this.botonPiedra = ((System.Windows.Controls.Button)(this.FindName("botonPiedra")));
            this.botonPapel = ((System.Windows.Controls.Button)(this.FindName("botonPapel")));
            this.botonTijera = ((System.Windows.Controls.Button)(this.FindName("botonTijera")));
            this.reiniciar = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("reiniciar")));
        }
    }
}

