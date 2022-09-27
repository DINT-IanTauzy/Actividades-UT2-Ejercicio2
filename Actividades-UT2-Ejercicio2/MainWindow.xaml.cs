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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Actividades_UT2_Ejercicio2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Operador.Text != "")
                Calcular_Button.IsEnabled = true;
            else if (Operador.Text == "")
                Calcular_Button.IsEnabled = false;
        }


        private void Calcular_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (Convert.ToChar(Operador.Text))
                {
                    case '+':
                        Resultado.Text = (int.Parse(Operando1.Text) + int.Parse(Operando2.Text)).ToString();
                        break;
                    case '-':
                        Resultado.Text = (int.Parse(Operando1.Text) - int.Parse(Operando2.Text)).ToString();
                        break;
                    case '/':
                        Resultado.Text = (int.Parse(Operando1.Text) / int.Parse(Operando2.Text)).ToString();
                        break;
                    case '*':
                        Resultado.Text = (int.Parse(Operando1.Text) * int.Parse(Operando2.Text)).ToString();
                        break;
                    default:
                        MessageBox.Show("Operador no permitido \nElige uno de estos operadores: [ + | - | / | * ]");
                        break;
                }
            } catch (Exception) {}
        }
        private void Limpiar_Button_Click(object sender, RoutedEventArgs e)
        {
            Operando1.Text = "";
            Operando2.Text = "";
            Operador.Text = "";
            Resultado.Text = "";
        }
        
    }
}
