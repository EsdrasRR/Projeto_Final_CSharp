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
        private void btnExcluir_Click(object sender, RoutedEventArgs e)
        {
            ListaExcluir excluir = new ListaExcluir();
            excluir.Show();
            this.Close();
        }
    }
}
