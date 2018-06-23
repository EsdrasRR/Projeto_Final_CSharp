using ControllerLibrary;
using ModelLibrary;
using System.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ViewWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            Cadastrar adicionar = new Cadastrar();
            main.Close();
            cadastro.Show();

        }
    }
}
