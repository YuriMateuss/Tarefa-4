using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace tarefa_3
{
    /// <summary>
    /// Lógica interna para MainWindow2.xaml
    /// </summary>
    public partial class MainWindow2 : Window
    {
        public MainWindow2()
        {
            InitializeComponent();
        }
        private void Aluno_Click(object sender, RoutedEventArgs e)
        {
            Modelo w = new Modelo();
            w.ShowDialog();
        }
        private void Diario_Click(object sender, RoutedEventArgs e)
        {
            Registrados w  = new Registrados();
            w.ShowDialog();
        }
    }
}