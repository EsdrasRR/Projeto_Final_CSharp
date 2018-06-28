using ControllerLibrary;
using ModelLibrary;
using System.Windows;
using System.Windows.Controls;


namespace ViewWPF
{
    /// <summary>
    /// Lógica interna para ListaExcluir.xaml
    /// </summary>
    public partial class ListaExcluir : Window
    {
        public ListaExcluir()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            SerieController serieController = new SerieController();
            dgExSerie.ItemsSource = serieController.ListarTodos();

        }

        public void dgExSerie_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = ((DataGrid)sender);

            Serie ser = (Serie)dg.Items[dg.SelectedIndex];

            Excluir excluir = new Excluir(ser);


            excluir.Show();

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
