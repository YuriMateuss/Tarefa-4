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
    public partial class Cadastro_Modelo_No_Veículo : Window
    {
        public Cadastro_Modelo_No_Veículo()
        {
            InitializeComponent();
        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listTurmas.ItemsSource = null;
            listTurmas.ItemsSource = NFabricante.Listar();
            listAlunos.ItemsSource = null;
            listAlunos.ItemsSource = NModelo.Listar();
        }'

        private void MatricularClick(object sender, RoutedEventArgs e)
        {
            if (listTurmas.SelectedItem != null &&
                listAlunos.SelectedItem != null)
            {
                Modelo a = (Modelo)listAlunos.SelectedItem;
                Fabricante t = (Fabricante)listTurmas.SelectedItem;
                NModelo.Matricular(a, t);
                ListarClick(sender, e);
            }
            else
            {
                MessageBox.Show("É preciso selecionar um modelo e um fabricante");
            }
        }
    }
}
