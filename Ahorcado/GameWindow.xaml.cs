using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Ahorcado
{
    /// <summary>
    /// Lógica de interacción para GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        ECCI.ECCI_HolaMundoPortClient client = new ECCI.ECCI_HolaMundoPortClient();
        int intentosRestantes;
        string usuario;
        List<char> usados;

        public GameWindow(String nombreUsuario)
        {
            InitializeComponent();
            usuario = nombreUsuario;
            labelUsuario.Content = "Jugador: " + usuario;
            usados = new List<char>();
            actualizarTodo();
        }

        private void actualizarTodo()
        {
            intentosRestantes = (int)client.obtenerIntentosRestantes();
            labelIntentos.Content = "Intentos restantes: " + intentosRestantes.ToString();
            string p = client.obtenerPalabraParcial();
            textBlock.Text = p;
            labelRespuesta.Content = client.obtenerPalabra() + " (esta fijo no es la respuesta)";
            image.Source = new BitmapImage(new Uri("http://titanic.ecci.ucr.ac.cr/~eb30640/imgphp/i"+intentosRestantes.ToString()+".png", UriKind.Absolute));


            if(intentosRestantes == 0)
            {
                labelFin.Content = "Sorry, ya perdió.";
            }
            else
            {
                if(!p.Contains("_"))
                {
                    labelFin.Content = "Ganó, congrats.";
                    labelTiempo.Content = "Duración: " + client.obtenerTiempo().ToString() + " segundos.";
                }
            }

            labelUsados.Content = "Chars usados: ";
            foreach(var c in usados)
            {
                labelUsados.Content += c + " ";
            }

            textBox.Text = "";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            String letra = textBox.Text;
            if (letra == "")
            {
                labelMensaje.Content = "Give me something man.";
            }
            else
            {
                if (letra.Length > 1)
                {
                    labelMensaje.Content = "One character please.";
                }
                else
                {
                    if(!Char.IsLetter(letra.ElementAt(0)))
                    {
                        labelMensaje.Content = "Come on, I need a letter.";
                    }
                    else
                    {
                        if(usados.Contains(letra.ElementAt(0)))
                        {
                            labelMensaje.Content = "Already used that letter.";
                        }
                        else
                        {
                            button.IsEnabled = false;
                            labelMensaje.Content = "";
                            client.ingresarLetra(letra);
                            usados.Add(letra.ElementAt(0));
                            labelMensaje.Content = "K.";
                            actualizarTodo();
                            button.IsEnabled = true;
                            
                        }
                    }
                }
            }
        }
    }
}
