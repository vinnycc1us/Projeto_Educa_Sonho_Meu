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

namespace Projeto_Educa_Sonho_Meu.Paginas
{
    /// <summary>
    /// Interação lógica para CadastrarSala.xam
    /// </summary>
    public partial class CadastrarSala : Page
    {
        public CadastrarSala()
        {
            InitializeComponent();
        }

        private void btnCadastrarSala(object sender, RoutedEventArgs e)
        {
            // Instancia a nova janela
            CadastrarSala cadastrarSala = new CadastrarSala();
            // Navega para a nova página
            this.NavigationService.Navigate(cadastrarSala);
        }
    }
}
