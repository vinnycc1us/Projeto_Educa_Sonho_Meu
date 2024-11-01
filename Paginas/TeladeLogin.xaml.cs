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

namespace Projeto_Educa_Sonho_Meu.Paginas
{
    /// <summary>
    /// Lógica interna para TeladeLogin.xaml
    /// </summary>
    public partial class TeladeLogin : Window
    {    
        public TeladeLogin()
        {
            InitializeComponent();
        }

        private void btnDirecionarPaginaInicial(object sender, RoutedEventArgs e)
        {
            PaginaInicial paginaInicial = new PaginaInicial();
            Window window = new Window();
            window.Content = paginaInicial;
            window.Show();
        }
    }
}
