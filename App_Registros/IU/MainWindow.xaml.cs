using App_Registros.DAO;
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

namespace App_Registros
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Patron Singleton
        private static MainWindow Instancia;
        public static MainWindow ObtenerInstancia()
        {
            if (Instancia == null)
            {
                Instancia = new MainWindow();
            }
            return Instancia;
        }
        private MainWindow()
        {
            InitializeComponent();
        }
        //Fin Singleton
        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            VerRegistros(txtCondicion.Text);
        }

        //Metodo Ver Registros
        private void VerRegistros(string condicion)
        {
            ClienteDao DAO = new ClienteDao();
            dgClientes.ItemsSource = DAO.VerRegistros(condicion);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            VerRegistros("");
        }

        private void txtCondicion_TextChanged(object sender, TextChangedEventArgs e)
        {
            VerRegistros(txtCondicion.Text);
        }
    }
}
