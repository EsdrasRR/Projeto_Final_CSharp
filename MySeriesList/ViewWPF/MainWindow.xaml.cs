using System.Windows;

namespace ViewWPF
{
	public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

		private void ButtonCadastrar_Click(object sender, RoutedEventArgs e)
		{
			Cadastrar cadastrar = new Cadastrar();
			cadastrar.Show();
			this.Close();
		}
		private void ButtonListar_Click(object sender, RoutedEventArgs e)
		{
			Listar listar = new Listar();
			listar.Show();
			this.Close();
		}
		private void ButtonEditar_Click(object sender, RoutedEventArgs e)
		{
			Editar editar = new Editar();
			editar.Show();
			this.Close();
		}
		private void ButtonExcluir_Click(object sender, RoutedEventArgs e)
		{
			ListaExcluir listaexcluir = new ListaExcluir();
			listaexcluir.Show();
			this.Close();
		}
	}
}
