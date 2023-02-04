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
    /// Lógica interna para Modelo.xaml
    /// </summary>
    public partial class Modelo : Window
    {
        internal object modelo;

        public Modelo()
        {
            InitializeComponent();
        }

        public int Id { get; internal set; }
        public object Preco { get; internal set; }
        public object IdVeiculo { get; internal set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
