using System;
using ControllerLibrary;
using ModelLibrary;
using System.Windows;
using System.Windows.Controls;

namespace ViewWPF
{
    public partial class Cadastrar : Window
	{
		public Cadastrar()
		{
			InitializeComponent();
		}

		private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

		}
		private void btnSalvar_Click(object sender, RoutedEventArgs e)
		{
		try
		{
		Serie serie = new Serie();

		serie.Nome = txtNome.Text;
		serie.Status = txtStatus.Text;
		serie.Tot_Ep = txtTot_Ep.Text;
        serie.Ep_Atual = txtEp_Atual.Text;
		serie.Genero1 = txtGenero1.Text;
		serie.Genero2 = txtGenero2.Text;
		serie.Genero2 = txtGenero3.Text;
		serie.Nota = txtNota.Text;

        SerieController serieController = new SerieController();
		serieController.Adicionar(serie);

		MessageBox.Show("Série salva com exito!");
	}
	catch (Exception ex)
	{
		MessageBox.Show("Erro ao salvar a série (" + ex.Message + ")");

	}
}

private void CheckBox_Checked(object sender, RoutedEventArgs e)
{

}
		private void btnVoltar_Click(object sender, RoutedEventArgs e)
		{
			MainWindow main = new MainWindow();
			main.Show();
			this.Close();
		}
	}
}
