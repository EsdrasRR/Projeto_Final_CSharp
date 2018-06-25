using ControllerLibrary;
using ModelLibrary;
using System.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ViewWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Cadastrar cadastrar = new Cadastrar();
			cadastrar.Show();
			this.Close();
		}
	}
}
