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
    /// Interaction logic for Editar.xaml
    /// </summary>
    public partial class Editar : Window
    {
        private Serie _ser;

        public Editar(Serie ser)
        {
            InitializeComponent();
            _ser = ser;
            pegarSer(_ser);
        }

        private void BuscarId_Click(object sender, RoutedEventArgs e)
        {

            Serie serieID = new Serie();

            //clienteId.ID_Cliente = txtBuscarId.Text;
        }

        public void pegarSer(Serie _ser)
        {
            txtNome.Text = _ser.Nome;
            txtStatus.Text = _ser.Login;
            txtEmail.Text = _ser.Email;
            txtSenha.Text = _ser.Senha;

        }

        private void btnAtualizar_Click(object sender, RoutedEventArgs e)
        {

             SerieController serieController = new SerieController();
            _ser.Nome = txtNome.Text;
            _ser.Login = txtLogin.Text;
            _ser.Email = txtEmail.Text;
            _ser.Senha = txtSenha.Text;
            serieController.Atualizar(_ser);

            MessageBox.Show("Usuario editado com exito!");

            this.Close();


        }
    }
}
