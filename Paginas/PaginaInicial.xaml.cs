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
    /// Interação lógica para PaginaInicial.xam
    /// </summary>
    public partial class PaginaInicial : Page
    {
        public PaginaInicial()
        {
            InitializeComponent();
        }     
        private void PaginaInicial_Loaded(object sender, RoutedEventArgs e)
        {
            framepaginainicial.Navigate(new CadastrarAluno());
        }
        private void btnDirecionarPaginaInicial(object sender, RoutedEventArgs e)
        {
            // Instancia a nova janela
            PaginaInicial paginaInicial = new PaginaInicial();
            // Navega para a nova página
            this.NavigationService.Navigate(paginaInicial);
        }
        private void btnCadastrarAluno(object sender, RoutedEventArgs e)
        {
            // Instancia a nova janela
            Window window = new Window();
            window.Content = new CadastrarAluno();
            framepaginainicial.Navigate(new CadastrarAluno());
        }

        private void btnConsultarAluno(object sender, RoutedEventArgs e)
        {
            // Instancia a nova janela
            Window window = new Window();
            window.Content = new ConsultarAluno();
            framepaginainicial.Navigate(new ConsultarAluno());
        }

        private void btnAluno(object sender, RoutedEventArgs e)
        {
            // Alternar a visibilidade dos botões
            if (nbtnCadastrarAluno.Visibility == Visibility.Collapsed)
            {
                nbtnCadastrarAluno.Visibility = Visibility.Visible;
                nbtnConsultarAluno.Visibility = Visibility.Visible;
            }
            else
            {
                nbtnCadastrarAluno.Visibility = Visibility.Collapsed;
                nbtnConsultarAluno.Visibility = Visibility.Collapsed;
            }
        }


        private void btnCadastrarTurma(object sender, RoutedEventArgs e)
        {
            // Instancia a nova janela
            Window window = new Window();
            window.Content = new CadastroTurma();
            framepaginainicial.Navigate(new CadastroTurma());
        }

        private void btnConsultarTurma(object sender, RoutedEventArgs e)
        {
            // Instancia a nova janela
            Window window = new Window();
            window.Content = new ConsultarTurma();
            framepaginainicial.Navigate(new ConsultarTurma());
        }

        private void btnTurma(object sender, RoutedEventArgs e)
        {
            // Alternar a visibilidade dos botões
            if (nbtnCadastrarTurma.Visibility == Visibility.Collapsed)
            {
                nbtnCadastrarTurma.Visibility = Visibility.Visible;
                nbtnConsultarTurma.Visibility = Visibility.Visible;
            }
            else
            {
                nbtnCadastrarTurma.Visibility = Visibility.Collapsed;
                nbtnConsultarTurma.Visibility = Visibility.Collapsed;
            }
        }

        private void btnCadastrarFuncionario(object sender, RoutedEventArgs e)
        {
            // Instancia a nova janela
            Window window = new Window();
            window.Content = new CadastrarFuncionario();
            framepaginainicial.Navigate(new CadastrarFuncionario());
        }

        private void btnConsultarFuncionario(object sender, RoutedEventArgs e)
        {
            // Instancia a nova janela
            Window window = new Window();
            window.Content = new ConsultarFuncionario();
            framepaginainicial.Navigate(new ConsultarFuncionario());
        }

        private void btnFuncionario(object sender, RoutedEventArgs e)
        {
            // Alternar a visibilidade dos botões
            if (nbtnCadastrarFuncionario.Visibility == Visibility.Collapsed)
            {
                nbtnCadastrarFuncionario.Visibility = Visibility.Visible;
                nbtnConsultarFuncionario.Visibility = Visibility.Visible;
            }
            else
            {
                nbtnCadastrarFuncionario.Visibility = Visibility.Collapsed;
                nbtnConsultarFuncionario.Visibility = Visibility.Collapsed;
            }
        }

        private void btnCadastrarSala(object sender, RoutedEventArgs e)
        {
            // Instancia a nova janela
            Window window = new Window();
            window.Content = new CadastrarSala();
            framepaginainicial.Navigate(new CadastrarSala());
        }

        private void btnConsultarSala(object sender, RoutedEventArgs e)
        {
            // Instancia a nova janela
            Window window = new Window();
            window.Content = new ConsultarSala();
            framepaginainicial.Navigate(new ConsultarSala());
        }

        private void btnSala(object sender, RoutedEventArgs e)
        {
            // Alternar a visibilidade dos botões
            if (nbtnCadastrarSala.Visibility == Visibility.Collapsed)
            {
                nbtnCadastrarSala.Visibility = Visibility.Visible;
                nbtnConsultarSala.Visibility = Visibility.Visible;
            }
            else
            {
                nbtnCadastrarSala.Visibility = Visibility.Collapsed;
                nbtnConsultarSala.Visibility = Visibility.Collapsed;
            }
        }

        private void btnCadastrarSonhoEntrada(object sender, RoutedEventArgs e)
        {
            // Instancia a nova janela
            Window window = new Window();
            window.Content = new CadastroSonhoEntrada();
            framepaginainicial.Navigate(new CadastroSonhoEntrada());
        }

        private void btnCadastrarSonhoSaida(object sender, RoutedEventArgs e)
        {
            // Instancia a nova janela
            Window window = new Window();
            window.Content = new CadastroSonhoSaida();
            framepaginainicial.Navigate(new CadastroSonhoSaida());
        }

        private void btnSonho(object sender, RoutedEventArgs e)
        {
            // Alternar a visibilidade dos botões
            if (nbtnCadastrarSonhoEntrada.Visibility == Visibility.Collapsed)
            {
                nbtnCadastrarSonhoEntrada.Visibility = Visibility.Visible;
                nbtnCadastrarSonhoSaida.Visibility = Visibility.Visible;
            }
            else
            {
                nbtnCadastrarSonhoEntrada.Visibility = Visibility.Collapsed;
                nbtnCadastrarSonhoSaida.Visibility = Visibility.Collapsed;
            }
        }

        private void btnCadastrarEstoquePedagogico(object sender, RoutedEventArgs e)
        {
            // Instancia a nova janela
            //Window window = new Window();
            //window.Content = new CadastrarEstoquePedagogico();
            //framepaginainicial.Navigate(new CadastrarEstoquePedagogico());
        }

        private void btnConsultarEstoquePedagogico(object sender, RoutedEventArgs e)
        {
            // Instancia a nova janela
            //Window window = new Window();
            //window.Content = new ConsultarEstoquePedagogico();
            //framepaginainicial.Navigate(new ConsultarEstoquePedagogico());
        }

        private void btnEstoquePedagogico(object sender, RoutedEventArgs e)
        {
            // Alternar a visibilidade dos botões
            if (nbtnCadastrarEstoquePedagogico.Visibility == Visibility.Collapsed)
            {
                nbtnCadastrarEstoquePedagogico.Visibility = Visibility.Visible;
                nbtnConsultarEstoquePedagogico.Visibility = Visibility.Visible;
            }
            else
            {
                nbtnCadastrarEstoquePedagogico.Visibility = Visibility.Collapsed;
                nbtnConsultarEstoquePedagogico.Visibility = Visibility.Collapsed;
            }
        }

        private void btnCadastrarBiblioteca(object sender, RoutedEventArgs e)
        {
            // Instancia a nova janela
            Window window = new Window();
            window.Content = new CadastrarBiblioteca();
            framepaginainicial.Navigate(new CadastrarBiblioteca());
        }

        private void btnConsultarBiblioteca(object sender, RoutedEventArgs e)
        {
            // Instancia a nova janela
            Window window = new Window();
            window.Content = new ConsultarBiblioteca();
            framepaginainicial.Navigate(new ConsultarBiblioteca());
        }

        private void btnBiblioteca(object sender, RoutedEventArgs e)
        {
            // Alternar a visibilidade dos botões
            if (nbtnCadastrarBiblioteca.Visibility == Visibility.Collapsed)
            {
                nbtnCadastrarBiblioteca.Visibility = Visibility.Visible;
                nbtnConsultarBiblioteca.Visibility = Visibility.Visible;
            }
            else
            {
                nbtnCadastrarBiblioteca.Visibility = Visibility.Collapsed;
                nbtnConsultarBiblioteca.Visibility = Visibility.Collapsed;
            }
        }

        private void btnCadastrarInstrumento(object sender, RoutedEventArgs e)
        {
            // Instancia a nova janela
            Window window = new Window();
            window.Content = new cadastrarInstrumento();
            framepaginainicial.Navigate(new cadastrarInstrumento());
        }

        private void btnConsultarInstrumento(object sender, RoutedEventArgs e)
        {
            // Instancia a nova janela
            Window window = new Window();
            window.Content = new ConsultarInstrumento();
            framepaginainicial.Navigate(new ConsultarInstrumento());
        }

        private void btnInstrumento(object sender, RoutedEventArgs e)
        {
            // Alternar a visibilidade dos botões
            if (nbtnCadastrarInstrumento.Visibility == Visibility.Collapsed)
            {
                nbtnCadastrarInstrumento.Visibility = Visibility.Visible;
                nbtnConsultarInstrumento.Visibility = Visibility.Visible;
            }
            else
            {
                nbtnCadastrarInstrumento.Visibility = Visibility.Collapsed;
                nbtnConsultarInstrumento.Visibility = Visibility.Collapsed;
            }
        }

        private void btnCadastrarProjeto(object sender, RoutedEventArgs e)
        {
            // Instancia a nova janela
            Window window = new Window();
            window.Content = new CadastrarProjeto();
            framepaginainicial.Navigate(new CadastrarProjeto());
        }

        private void btnConsultarProjeto(object sender, RoutedEventArgs e)
        {
            // Instancia a nova janela
            Window window = new Window();
            window.Content = new ConsultarProjeto();
            framepaginainicial.Navigate(new ConsultarProjeto());
        }

        private void btnProjeto(object sender, RoutedEventArgs e)
        {
            // Alternar a visibilidade dos botões
            if (nbtnCadastrarProjeto.Visibility == Visibility.Collapsed)
            {
                nbtnCadastrarProjeto.Visibility = Visibility.Visible;
                nbtnConsultarProjeto.Visibility = Visibility.Visible;
            }
            else
            {
                nbtnCadastrarProjeto.Visibility = Visibility.Collapsed;
                nbtnConsultarProjeto.Visibility = Visibility.Collapsed;
            }
        }


        private void btnCadastrarRecursoFinanceiro(object sender, RoutedEventArgs e)
        {
            // Instancia a nova janela
            Window window = new Window();
            window.Content = new CadastrarRecursoFinanceiro();
            framepaginainicial.Navigate(new CadastrarRecursoFinanceiro());
        }

        private void btnConsultarRecursoFinanceiro(object sender, RoutedEventArgs e)
        {
            // Instancia a nova janela
            Window window = new Window();
            window.Content = new ConsultarRecursoFinanceiro();
            framepaginainicial.Navigate(new ConsultarRecursoFinanceiro());
        }

        private void btnRecursoFinanceiro(object sender, RoutedEventArgs e)
        {
            // Alternar a visibilidade dos botões
            if (nbtnCadastrarRecursoFinanceiro.Visibility == Visibility.Collapsed)
            {
                nbtnCadastrarRecursoFinanceiro.Visibility = Visibility.Visible;
                nbtnConsultarRecursoFinanceiro.Visibility = Visibility.Visible;
            }
            else
            {
                nbtnCadastrarRecursoFinanceiro.Visibility = Visibility.Collapsed;
                nbtnConsultarRecursoFinanceiro.Visibility = Visibility.Collapsed;
            }
        }

        private void btnCadastrarCalendarioAcademico(object sender, RoutedEventArgs e)
        {
            // Instancia a nova janela
            Window window = new Window();
            window.Content = new CadastrarCalendarioAcademico();
            framepaginainicial.Navigate(new CadastrarCalendarioAcademico());
        }

        private void btnConsultarCalendarioAcademico(object sender, RoutedEventArgs e)
        {
            // Instancia a nova janela
            Window window = new Window();
            window.Content = new ConsultarCalendarioAcademico();
            framepaginainicial.Navigate(new ConsultarCalendarioAcademico());
        }

        private void btnCalendarioAcademico(object sender, RoutedEventArgs e)
        {
            // Alternar a visibilidade dos botões
            if (nbtnCadastrarCalendarioAcademico.Visibility == Visibility.Collapsed)
            {
                nbtnCadastrarCalendarioAcademico.Visibility = Visibility.Visible;
                nbtnConsultarCalendarioAcademico.Visibility = Visibility.Visible;
            }
            else
            {
                nbtnCadastrarCalendarioAcademico.Visibility = Visibility.Collapsed;
                nbtnConsultarCalendarioAcademico.Visibility = Visibility.Collapsed;
            }
        }
    }
}
