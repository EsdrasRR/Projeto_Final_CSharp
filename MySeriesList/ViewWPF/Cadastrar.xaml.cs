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
	public partial class Cadastrar : Window
	{
		public Cadastrar()
		{
			InitializeComponent();
		}

		private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

		}
		private void btnCadastrar_Click(object sender, RoutedEventArgs e)
		{
		try
		{
		Serie serie = new Serie();

		serie.Nome = txtNome.Text;
		serie.status = int.Parse(txtStatus.SelectedValue.ToString());
		serie.Tot_Ep = int.Parse(txtTot_Ep.Text);
		serie.Ep_Atual= int.Parse(txtEp_Atual.Text);
		serie.Genero1 = txtGenero1.Text;
		serie.Genero2 = txtGenero2.Text;
		serie.Genero2 = txtGenero3.Text;
		serie.Nota = int.Parse(txtNota.SelectedValue.ToString());

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
		private void btnSalvar_Click(object sender, RoutedEventArgs e)
		{
			MainWindow main = new MainWindow();
			Cadastrar cadastrar = new Cadastrar();
			main.Close();

		}
		private void btnVoltar_Click(object sender, RoutedEventArgs e)
		{
			MainWindow main = new MainWindow();
			main.Show();
			this.Close();
		}
	}
}
