using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Shapes;

namespace Projeto_Educa_Sonho_Meu.Paginas
{
    public partial class PaginaInicial : Window
    {
        public PaginaInicial()
        {
            InitializeComponent();
            Loaded += PaginaInicial_Loaded;
        }

        private void PaginaInicial_Loaded(object sender, RoutedEventArgs e)
        {         
        }

        private void btnConsultarAluno(object sender, RoutedEventArgs e)
        {
            // Instancia a nova janela
            Window window = new Window();
            window.Content = new ConsultarAluno();
            window.ShowDialog();
        }

        private void btnCadastrarAluno(object sender, RoutedEventArgs e)
        {
            // Instancia a nova janela
            Window window = new Window();
            window.Content = new CadastrarAluno();
            window.ShowDialog();
        }
    }
}