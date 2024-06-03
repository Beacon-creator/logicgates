using LogicTrainer_App.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Interaction logic for Switches.xaml
    /// </summary>
    public partial class Switches : UserControl
    {
        public Switches()
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

        private void Toggle1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Toggle1_Checked(object sender, RoutedEventArgs e)
        {        

            NotGate newSelect = new NotGate();

          ((MainWindow)App.Current.MainWindow).dagrid.Items.Clear();


           newSelect.input1 = "1";

           ((MainWindow)App.Current.MainWindow).dagrid.Items.Add(newSelect);

            ((MainWindow)App.Current.MainWindow).tt1.Text = newSelect.input1;


        }

        private void Toggle1_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if ((bool)Toggle1.IsChecked)
            {
                Toggle1.IsChecked = false;

            }

            else if ((bool)Toggle1.IsChecked == false)
            {
                ((MainWindow)App.Current.MainWindow).dagrid.Items.Clear();
                ((MainWindow)App.Current.MainWindow).tt1.Clear();
                ((MainWindow)App.Current.MainWindow).tt3.Clear();

            }

        }

        private void Toggle1_Unchecked(object sender, RoutedEventArgs e)
        {

            NotGate newSelect = new NotGate();

          
            ((MainWindow)App.Current.MainWindow).dagrid.Items.Clear();
         

            newSelect.input1 = "0";

             ((MainWindow)App.Current.MainWindow).dagrid.Items.Add(newSelect);

            ((MainWindow)App.Current.MainWindow).tt1.Text = newSelect.input1;

        }

    
    }
}
