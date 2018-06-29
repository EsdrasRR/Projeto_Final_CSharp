using System;
using ControllerLibrary;
using ModelLibrary;
using System.Windows;
using System.Windows.Controls;


namespace ViewWPF
{
	/// <summary>
	/// Interaction logic for Excluir.xaml
	/// </summary>
	public partial class Excluir : Window
	{
		public Excluir(Serie ser)
		{
            _ser = ser;

            InitializeComponent();
		}
        private Serie _ser;

        public Excluir()
        {
        }

        public void btnExcluir_Click(object sender, RoutedEventArgs e)
        {
            SerieController excluirSerie = new SerieController();

            excluirSerie.Excluir(_ser.ID_Serie);


            MessageBox.Show("Usuario excluido com exito!");

            MainWindow main = new MainWindow();
            main.Show();
            this.Close();

        }
    }
}
