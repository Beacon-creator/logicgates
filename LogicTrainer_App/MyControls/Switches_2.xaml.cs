using LogicTrainer_App.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LogicTrainer_App.MyControls
{
    /// <summary>
    /// Interaction logic for Switches_2.xaml
    /// </summary>
    public partial class Switches_2 : UserControl
    {
        public Switches_2()
        {
            InitializeComponent();
        }

        public class NotGate
        {

            public string input1 { get; set; }

            public string input2 { get; set; }

            public string output { get; set; }

            public string outputword { get; set; }



        }
        private void Toggle2_Checked(object sender, RoutedEventArgs e)
        {


            NotGate newSelect = new NotGate();

            ((MainWindow)App.Current.MainWindow).dagrid2.Items.Clear();

            newSelect.input2 = "1";


            ((MainWindow)App.Current.MainWindow).dagrid2.Items.Add(newSelect);


            ((MainWindow)App.Current.MainWindow).tt2.Text = newSelect.input2;



        }

        private void Toggle2_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if ((bool)Toggle2.IsChecked)
            {
                Toggle2.IsChecked = false;

            }

            else if ((bool)Toggle2.IsChecked == false)
            {
                ((MainWindow)App.Current.MainWindow).dagrid2.Items.Clear();
                ((MainWindow)App.Current.MainWindow).tt2.Clear();
                ((MainWindow)App.Current.MainWindow).tt3.Clear();
               
               
            }

        }

        private void Toggle2_Unchecked(object sender, RoutedEventArgs e)
        {

            NotGate newSelect = new NotGate();

            ((MainWindow)App.Current.MainWindow).dagrid2.Items.Clear();

            newSelect.input2 = "0";
         

            ((MainWindow)App.Current.MainWindow).dagrid2.Items.Add(newSelect);

            ((MainWindow)App.Current.MainWindow).tt2.Text = newSelect.input2;
        }

        private void Toggle2_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
