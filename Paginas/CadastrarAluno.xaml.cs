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
    /// Interação lógica para CadastrarAluno.xam
    /// </summary>
    public partial class CadastrarAluno : Page
    {
        public CadastrarAluno()
        {
            InitializeComponent();
        }

        private void InitializeComponente()
        {
            // Create the main grid.
            Grid mainGrid = new Grid();
            mainGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(0.2, GridUnitType.Star) });
            mainGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(0.8, GridUnitType.Star) });

            // Left side (Menu)
            Grid leftMenu = new Grid();
            leftMenu.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
            leftMenu.Background = new SolidColorBrush(Color.FromRgb(0, 128, 255)); // Blue background
            leftMenu.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            leftMenu.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

            // Logo
            Image logoImage = new Image();
            logoImage.Source = new BitmapImage(new Uri("pack://application:,,,/Images/educa.png"));
            logoImage.Margin = new Thickness(10);
            Grid.SetRow(logoImage, 0);
            leftMenu.Children.Add(logoImage);

            // Menu Items
            Label menuItemsLabel = new Label();
            menuItemsLabel.Content = "ADMIM A\nMarcus Vinycius...\nInicio\nAlunos\nCadastrar Alunos\nConsultar Alunos Cadastrados\nMatricular Alunos\nConsultar Alunos Matriculados\nRelatório de Alunos Cadastrados\nRelatórios de Alunos Matriculados\nTurmas\nFuncionário\nSalas\nSonhos\nEstoque Pedagógico\nBiblioteca\nInstrumentos\nProjetos\nRecursos Financeiros";
            menuItemsLabel.Margin = new Thickness(10);
            menuItemsLabel.Foreground = Brushes.White; // White text
            menuItemsLabel.FontSize = 14;
            Grid.SetRow(menuItemsLabel, 1);
            leftMenu.Children.Add(menuItemsLabel);

            // Right side (Form)
            Grid rightForm = new Grid();
            rightForm.Background = Brushes.White;
            rightForm.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            rightForm.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            rightForm.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            rightForm.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

            // Title
            Label titleLabel = new Label();
            titleLabel.Content = "PROJETO\nSONHO MEU\nTRANSFORMANDO VIDAS E FORMANDO CIDADÃOS";
            titleLabel.FontSize = 24;
            titleLabel.FontWeight = FontWeights.Bold;
            titleLabel.HorizontalAlignment = HorizontalAlignment.Center;
            titleLabel.Margin = new Thickness(0, 10, 0, 10);
            Grid.SetRow(titleLabel, 0);
            rightForm.Children.Add(titleLabel);

            // Form Fields
            Grid formFields = new Grid();
            formFields.Margin = new Thickness(10);
            formFields.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            formFields.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            formFields.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            formFields.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            formFields.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            formFields.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            formFields.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            formFields.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            formFields.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            formFields.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            formFields.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            formFields.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            formFields.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            formFields.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            formFields.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            formFields.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            formFields.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            formFields.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

            formFields.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
            formFields.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
            formFields.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });

            // Label and TextBox pairs
            AddFormField("Cadastrar de Aluno", 0, 0, formFields);
            AddFormField("Prioridade", 1, 0, formFields, new ComboBox { ItemsSource = new string[] { "High", "Medium", "Low" } });
            AddFormField("Nome", 2, 0, formFields);
            AddFormField("RG", 3, 0, formFields);
            AddFormField("CPF", 3, 1, formFields);
            AddFormField("Data Nascimento", 3, 2, formFields);
            AddFormField("Sexo", 4, 0, formFields);
            AddFormField("Doença", 4, 1, formFields);
            AddFormField("Beneficio", 4, 2, formFields);
            AddFormField("Nis", 5, 2, formFields);
            AddFormField("Masculino", 5, 0, formFields, new RadioButton { IsChecked = true });
            AddFormField("Diabetico", 5, 1, formFields);
            AddFormField("Bolsa Família", 6, 2, formFields);
            AddFormField("Nacionalidade", 6, 0, formFields);
            AddFormField("Naturalidade", 6, 1, formFields);
            AddFormField("Cidade", 7, 1, formFields);
            AddFormField("Cep", 7, 2, formFields);
            AddFormField("Brasileiro", 7, 0, formFields, new RadioButton { IsChecked = true });
            AddFormField("Parana", 8, 1, formFields);
            AddFormField("Estado", 9, 0, formFields);
            AddFormField("Bairro", 9, 1, formFields);
            AddFormField("Logradouro", 10, 1, formFields);
            AddFormField("Numero", 10, 2, formFields);
            AddFormField("Rondinia", 10, 0, formFields);
            AddFormField("Caselasso", 11, 1, formFields);
            AddFormField("Rua Jose Pedro", 12, 1, formFields);
            AddFormField("Escola", 12, 0, formFields);
            AddFormField("Serie", 12, 1, formFields);
            AddFormField("Período", 13, 1, formFields);
            AddFormField("E.E.E.F.M Aulio Ferrei", 13, 0, formFields);
            AddFormField("Sitima", 14, 1, formFields);
            AddFormField("Matutino", 15, 1, formFields);
            AddFormField("Parecer Social:", 16, 0, formFields, new Label { FontStyle = FontStyles.Italic });

            // Add long text area for Parecer Social
            TextBox parecerSocialTextBox = new TextBox();
            parecerSocialTextBox.Text = "Asdramdomaksmcksmacklasmckismadckisdmacki maskom sakiLorem Asdramdcmaksmcksmacklasmckismadcklisdmacki maskom\nsakiLorem Asdramdomaksmcksmacklasmckismadcksdmacki maskom sakiLorem Asdramdcmaksmdksmacklasmckismadcklsdmacki\nmaskcm saklAadramdcmakimcksmacklasmcklamackisdmacki maskcm sakiLorem Asdramdcmaksmcksmacklanmcklamadckismack!\nmaskcm sakiLorem Asdramdomaksmcksmacklasmckismadcksdmacki maskom saklorem";
            parecerSocialTextBox.Height = 100;
            parecerSocialTextBox.TextWrapping = TextWrapping.Wrap;
            parecerSocialTextBox.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;
            Grid.SetRow(parecerSocialTextBox, 17);
            Grid.SetColumn(parecerSocialTextBox, 0);
            Grid.SetColumnSpan(parecerSocialTextBox, 3);
            formFields.Children.Add(parecerSocialTextBox);

            // Responsavel pelo Aluno
            AddFormField("Responsável pelo Aluno", 18, 0, formFields);
            AddFormField("Nome", 19, 0, formFields);
            AddFormField("RG", 20, 0, formFields);
            AddFormField("CPF", 20, 1, formFields);
            AddFormField("Telefone", 20, 2, formFields);
            AddFormField("Marcas Vinylus de Jesus Silva", 21, 0, formFields);
            AddFormField("121212-2", 22, 0, formFields);
            AddFormField("121.121.121.12", 22, 1, formFields);
            AddFormField("65-9-9999-9999", 22, 2, formFields);
            AddFormField("Telefone Alternativo", 23, 0, formFields);
            AddFormField("Telefone Fixo", 23, 1, formFields);
            AddFormField("Telefone para Recado", 23, 2, formFields);
            AddFormField("69-8-9999-9999", 24, 0, formFields);
            AddFormField("69-3411-9999", 25, 1, formFields);
            AddFormField("69-9-9999-9999", 26, 2, formFields);

            // Save button
            Button saveButton = new Button();
            saveButton.Content = "Salvar";
            saveButton.Margin = new Thickness(10);
            saveButton.Background = new SolidColorBrush(Color.FromRgb(0, 128, 255)); // Blue background
            saveButton.Foreground = Brushes.White; // White text
            saveButton.FontSize = 14;
            Grid.SetRow(saveButton, 27);
            Grid.SetColumn(saveButton, 2);
            rightForm.Children.Add(saveButton);

            Grid.SetRow(formFields, 1);
            Grid.SetColumnSpan(formFields, 3);
            rightForm.Children.Add(formFields);

            Grid.SetColumn(leftMenu, 0);
            Grid.SetColumn(rightForm, 1);
            mainGrid.Children.Add(leftMenu);
            mainGrid.Children.Add(rightForm);

            Content = mainGrid;
        }

        private void AddFormField(string labelText, int row, int column, Grid formFields, object control = null)
        {
            Label label = new Label();
            label.Content = labelText;
            Grid.SetRow(label, row);
            Grid.SetColumn(label, column);
            formFields.Children.Add(label);

            if (control != null)
            {
                Control fieldControl = (Control)control;
                fieldControl.Margin = new Thickness(5);
                Grid.SetRow(fieldControl, row);
                Grid.SetColumn(fieldControl, column + 1);
                formFields.Children.Add(fieldControl);
            }
        }
    }
}
