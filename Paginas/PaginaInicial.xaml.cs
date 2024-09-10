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
            framePage.Navigate(new CadastrarAluno());
        }
    }
}