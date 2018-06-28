using ControllerLibrary;
using ModelLibrary;
using System.Windows;

namespace ViewWPF
{

    public partial class Editar : Window
    {
        private Serie _ser;

        public Editar(Serie ser)
        {
            InitializeComponent();
            _ser = ser;
            pegarSer(_ser);
        }

        public Editar()
        {
            InitializeComponent();
        }

        private void BuscarId_Click(object sender, RoutedEventArgs e)
        {

            Serie serieID = new Serie();

            //clienteId.ID_Cliente = txtBuscarId.Text;
        }

        public void pegarSer(Serie _ser)
        {

            txtNome.Text = _ser.Nome;
            txtStatus.Text = _ser.Status;
            txtTot_Ep.Text = _ser.Tot_Ep;
            txtEp_Atual.Text = _ser.Ep_Atual;
            txtGenero1.Text = _ser.Genero1;
            txtGenero2.Text = _ser.Genero2;
            txtGenero3.Text = _ser.Genero3;
            txtNota.Text = _ser.Nota;

        }

        private void btnAtualizar_Click(object sender, RoutedEventArgs e)
        {

             SerieController serieController = new SerieController();
            _ser.Nome = txtNome.Text;
            _ser.Status = txtStatus.Text;
            _ser.Tot_Ep = txtTot_Ep.Text;
            _ser.Ep_Atual = txtEp_Atual.Text;
            _ser.Genero1 = txtGenero1.Text;
            _ser.Genero2 = txtGenero2.Text;
            _ser.Genero3 = txtGenero3.Text;
            _ser.Nota = txtNota.Text;

            serieController.Atualizar(_ser);

            MessageBox.Show("Usuario editado com exito!");

            this.Close();


        }
        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
