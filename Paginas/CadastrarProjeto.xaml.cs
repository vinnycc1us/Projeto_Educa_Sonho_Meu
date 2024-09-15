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
    /// Interação lógica para CadastrarProjeto.xam
    /// </summary>
    public partial class CadastrarProjeto : Page
    {
        public CadastrarProjeto()
        {
            InitializeComponent();
        }

        private void btnConsultarProjeto(object sender, RoutedEventArgs e)
        {
            // Instancia a nova janela
            ConsultarProjeto consultarProjeto = new ConsultarProjeto();
            // Navega para a nova página
            this.NavigationService.Navigate(consultarProjeto);
        }
    }
}
