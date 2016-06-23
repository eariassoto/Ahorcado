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
    /// Lógica de interacción para TopWindow.xaml
    /// </summary>
    public partial class TopWindow : Window
    {
        ECCI.ECCI_HolaMundoPortClient c = new ECCI.ECCI_HolaMundoPortClient();
        public TopWindow()
        {
            InitializeComponent();
            textBlock.Text = c.obtenerTop();
        }
    }
}
