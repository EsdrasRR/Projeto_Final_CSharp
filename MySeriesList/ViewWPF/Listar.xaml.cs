using ControllerLibrary;
using ModelLibrary;
using System.Windows;
using System.Windows.Controls;

namespace ViewWPF
{
    public partial class Listar : Window
	{
		public Listar()
		{
			InitializeComponent();
		}

        private void Windows_Loaded(object sender, RoutedEventArgs e)
        {

            SerieController serieController = new SerieController();
            dgSeries.ItemsSource = serieController.ListarTodos();

        }

        public void dgSeries_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = ((DataGrid)sender);

            Serie ser = (Serie)dg.Items[dg.SelectedIndex];

            Editar editar = new Editar(ser);


            editar.Show();

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
