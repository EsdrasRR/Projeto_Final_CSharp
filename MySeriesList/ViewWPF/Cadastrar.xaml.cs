using System;
using System.Collections.Generic;
using System.Linq;
using ControllerLibrary;
using ModelLibrary;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ViewWPF
{
    /// <summary>
    /// Interação lógica para Cadastrar.xam
    /// </summary>
    public partial class Cadastrar : Page
    {
        public Cadastrar()
        {
            InitializeComponent();
        }
        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
             try
             {
                Serie serie = new Serie();

                serie.Nome = txtNome.Text;
                serie.status = txtLogin.Text;
                serie.Tot_Ep = txtEmail.Text;
                serie.Ep_Atual = txtSenha.Text;
                serie.Genero1 =
                serie.Genero2 =
                serie.Genero2 =
                serie.Nota = 
                serie.Observacao = 

                SerieController serieController = new SerieController();
                serieController.Adicionar(serie);

                MessageBox.Show("Série salva com exito!");
             }
             catch (Exception ex)
             {
                MessageBox.Show("Erro ao salvar o série (" + ex.Message + ")");
                
             }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
