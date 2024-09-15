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
            framepaginainicial.Navigate(new CadastrarAluno());
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

        private void btnCadastrarEstoquePedagogico(object sender, RoutedEventArgs e)
        {
            // Instancia a nova janela
            Window window = new Window();
            window.Content = new CadastrarEstoquePedagogico();
            framepaginainicial.Navigate(new CadastrarEstoquePedagogico());
        }

        private void btnConsultarEstoquePedagogico(object sender, RoutedEventArgs e)
        {
            // Instancia a nova janela
            Window window = new Window();
            window.Content = new ConsultarEstoquePedagogico();
            framepaginainicial.Navigate(new ConsultarEstoquePedagogico());
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
    }

}
