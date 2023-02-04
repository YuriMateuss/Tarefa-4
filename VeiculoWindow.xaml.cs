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
    /// Lógica interna para Veiculo.xaml
    /// </summary>
    public partial class Veiculo : Window
    {
        public Veiculo()
        {
            InitializeComponent();
        }

        private int id;

        public object IdFabricante { get; internal set; }
        public object Nome { get; internal set; }

        public int GetId()
        {
            return id;
        }

        internal void SetId(int value)
        {
            id = value;
        }
    }
}
