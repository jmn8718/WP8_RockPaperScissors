using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using RockPaperScissors.Resources;
using System.Windows.Media.Imaging;

namespace RockPaperScissors
{
    public partial class MainPage : PhoneApplicationPage
    {
        RPSGame rps = new RPSGame("piedra", "papel", "tijera");

        int wins = 0, losses = 0, draws = 0;

        string usuario = "";

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }


        private void jugar()
        {
            ButtonsPanel.Visibility = System.Windows.Visibility.Collapsed;

            int resultado = rps.Next(usuario);

            switch (resultado)
            {
                case 1:
                    wins++;
                    textVictoriasValor.Text = wins.ToString();
                    textResultado.Text = AppResources.ResourceManager.GetString("Victoria", AppResources.Culture);
                    break;
                case 0:
                    draws++;
                    textEmpatesValor.Text = draws.ToString();
                    textResultado.Text = AppResources.ResourceManager.GetString("Empate", AppResources.Culture);
                    break;
                case -1:
                    losses++;
                    textDerrotasValor.Text = losses.ToString();
                    textResultado.Text = AppResources.ResourceManager.GetString("Derrota", AppResources.Culture);
                    break;
            }
            actualizarImagenes();
            botonOtraPartida.Visibility = System.Windows.Visibility.Visible;
        }

        private void actualizarImagenes()
        {
            string oponente = rps.LastAIWeapon;
            imagenRival.Source = new BitmapImage(new Uri("/Imagenes/" + oponente + ".png", UriKind.Relative));
            imagenUsuario.Source = new BitmapImage(new Uri("/Imagenes/" + usuario + ".png", UriKind.Relative));
        }
        private void Piedra_Click(object sender, RoutedEventArgs e)
        {
            usuario = "piedra";
            jugar();
        }

        private void Papel_Click(object sender, RoutedEventArgs e)
        {
            usuario = "papel";
            jugar();
        }

        private void Tijera_Click(object sender, RoutedEventArgs e)
        {
            usuario = "tijera";
            jugar();
        }

        private void botonOtraPartida_Click(object sender, RoutedEventArgs e)
        {
            botonOtraPartida.Visibility = System.Windows.Visibility.Collapsed;
            ButtonsPanel.Visibility = System.Windows.Visibility.Visible;

            textResultado.Text = "";

            imagenRival.Source = new BitmapImage(new Uri("/Imagenes/oponente.png", UriKind.Relative));
            imagenUsuario.Source = new BitmapImage(new Uri("/Imagenes/usuario.png", UriKind.Relative));
        }
        
        private void reiniciar_Click(object sender, EventArgs e)
        {
            wins=0;
            textVictoriasValor.Text = wins.ToString();
            draws=0;
            textEmpatesValor.Text = draws.ToString();
            losses=0;
            textDerrotasValor.Text = losses.ToString();
        }

    }
}