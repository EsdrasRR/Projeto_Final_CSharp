
using System.Windows;

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
+        {
+            MainWindow main = new MainWindow();
+            Adicionar adicionar = new Adicionar();
+            main.Close();
+            cadastro.Show();
+
+        }
}
}