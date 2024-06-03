using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace LogicTrainer_App.Pages
{
    /// <summary>
    /// Interaction logic for NandGatePage.xaml
    /// </summary>
    public partial class NandGatePage : Page
    {
        public NandGatePage()
        {
            InitializeComponent();
            inSwitch0.IsEnabled = false;
            inSwitch1.IsEnabled = false;
            inSwitch2.IsEnabled = false;
            inSwitch3.IsEnabled = false;
            inSwitch4.IsEnabled = false;
            inSwitch5.IsEnabled = false;
            inSwitch6.IsEnabled = false;
            inSwitch7.IsEnabled = false;

            in2Switch0.IsEnabled = false;
            in2Switch1.IsEnabled = false;
            in2Switch2.IsEnabled = false;
            in2Switch3.IsEnabled = false;
            in2Switch4.IsEnabled = false;
            in2Switch5.IsEnabled = false;
            in2Switch6.IsEnabled = false;
            in2Switch7.IsEnabled = false;

            in2Switch0.Visibility = Visibility.Collapsed;
            in2Switch1.Visibility = Visibility.Collapsed;
            in2Switch2.Visibility = Visibility.Collapsed;
            in2Switch3.Visibility = Visibility.Collapsed;
            in2Switch4.Visibility = Visibility.Collapsed;
            in2Switch5.Visibility = Visibility.Collapsed;
            in2Switch6.Visibility = Visibility.Collapsed;
            in2Switch7.Visibility = Visibility.Collapsed;


            Glight0.Visibility = Visibility.Collapsed;
            Glight1.Visibility = Visibility.Collapsed;
            Glight2.Visibility = Visibility.Collapsed;
            Glight3.Visibility = Visibility.Collapsed;
            Glight4.Visibility = Visibility.Collapsed;
            Glight5.Visibility = Visibility.Collapsed;
            Glight6.Visibility = Visibility.Collapsed;
            Glight7.Visibility = Visibility.Collapsed;

            Rlight0.Visibility = Visibility.Collapsed;
            Rlight1.Visibility = Visibility.Collapsed;
            Rlight2.Visibility = Visibility.Collapsed;
            Rlight3.Visibility = Visibility.Collapsed;
            Rlight4.Visibility = Visibility.Collapsed;
            Rlight5.Visibility = Visibility.Collapsed;
            Rlight6.Visibility = Visibility.Collapsed;
            Rlight7.Visibility = Visibility.Collapsed;


            ((MainWindow)App.Current.MainWindow).tt1.Visibility = Visibility.Collapsed;
            ((MainWindow)App.Current.MainWindow).tt2.Visibility = Visibility.Collapsed;
            ((MainWindow)App.Current.MainWindow).tt3.Visibility = Visibility.Collapsed;
            ((MainWindow)App.Current.MainWindow).dagrid.Visibility = Visibility.Collapsed;
            ((MainWindow)App.Current.MainWindow).dagrid2.Visibility = Visibility.Collapsed;

        }
        public class NotGate
        {

            public string input1 { get; set; }

            public string input2 { get; set; }

            public string output { get; set; }

            public string outputword { get; set; }


        }
        private void G1Switch0_Selected(object sender, RoutedEventArgs e)
        {
            in2Switch0.Visibility = Visibility.Collapsed;
            inSwitch0.Visibility = Visibility.Visible;
            inSwitch0.IsEnabled = true;
            G2Switch0.IsEnabled = false;
            G2Switch1.IsEnabled = true;
            G2Switch2.IsEnabled = true;
            G2Switch3.IsEnabled = true;
            G2Switch4.IsEnabled = true;
            G2Switch5.IsEnabled = true;
            G2Switch6.IsEnabled = true;
            G2Switch7.IsEnabled = true;


        }

        private void G1Switch1_Selected(object sender, RoutedEventArgs e)
        {
            G2Switch1.IsEnabled = false;
            inSwitch1.IsEnabled = true;
            inSwitch1.Visibility = Visibility.Visible;
            in2Switch1.Visibility = Visibility.Collapsed;
            G2Switch0.IsEnabled = true;
            G2Switch2.IsEnabled = true;
            G2Switch3.IsEnabled = true;
            G2Switch4.IsEnabled = true;
            G2Switch5.IsEnabled = true;
            G2Switch6.IsEnabled = true;
            G2Switch7.IsEnabled = true;

        }

        private void G1Switch2_Selected(object sender, RoutedEventArgs e)
        {
            G2Switch2.IsEnabled = false;
            inSwitch2.IsEnabled = true;
            inSwitch2.Visibility = Visibility.Visible;
            in2Switch2.Visibility = Visibility.Collapsed;
            G2Switch1.IsEnabled = true;
            G2Switch0.IsEnabled = true;
            G2Switch3.IsEnabled = true;
            G2Switch4.IsEnabled = true;
            G2Switch5.IsEnabled = true;
            G2Switch6.IsEnabled = true;
            G2Switch7.IsEnabled = true;

        }

        private void G1Switch3_Selected(object sender, RoutedEventArgs e)
        {
            G2Switch3.IsEnabled = false;
            inSwitch3.IsEnabled = true;
            inSwitch3.Visibility = Visibility.Visible;
            in2Switch3.Visibility = Visibility.Collapsed;
            G2Switch1.IsEnabled = true;
            G2Switch2.IsEnabled = true;
            G2Switch0.IsEnabled = true;
            G2Switch4.IsEnabled = true;
            G2Switch5.IsEnabled = true;
            G2Switch6.IsEnabled = true;
            G2Switch7.IsEnabled = true;

        }

        private void G1Switch4_Selected(object sender, RoutedEventArgs e)
        {
            G2Switch4.IsEnabled = false;
            inSwitch4.IsEnabled = true;
            inSwitch4.Visibility = Visibility.Visible;
            in2Switch4.Visibility = Visibility.Collapsed;
            G2Switch1.IsEnabled = true;
            G2Switch2.IsEnabled = true;
            G2Switch3.IsEnabled = true;
            G2Switch0.IsEnabled = true;
            G2Switch5.IsEnabled = true;
            G2Switch6.IsEnabled = true;
            G2Switch7.IsEnabled = true;

        }

        private void G1Switch5_Selected(object sender, RoutedEventArgs e)
        {
            G2Switch5.IsEnabled = false;
            inSwitch5.IsEnabled = true;
            inSwitch5.Visibility = Visibility.Visible;
            in2Switch5.Visibility = Visibility.Collapsed;
            G2Switch1.IsEnabled = true;
            G2Switch2.IsEnabled = true;
            G2Switch3.IsEnabled = true;
            G2Switch4.IsEnabled = true;
            G2Switch0.IsEnabled = true;
            G2Switch6.IsEnabled = true;
            G2Switch7.IsEnabled = true;

        }

        private void G1Switch6_Selected(object sender, RoutedEventArgs e)
        {
            G2Switch6.IsEnabled = false;
            inSwitch6.IsEnabled = true;
            inSwitch6.Visibility = Visibility.Visible;
            in2Switch6.Visibility = Visibility.Collapsed;
            G2Switch1.IsEnabled = true;
            G2Switch2.IsEnabled = true;
            G2Switch3.IsEnabled = true;
            G2Switch4.IsEnabled = true;
            G2Switch5.IsEnabled = true;
            G2Switch0.IsEnabled = true;
            G2Switch7.IsEnabled = true;

        }

        private void G1Switch7_Selected(object sender, RoutedEventArgs e)
        {
            G2Switch7.IsEnabled = false;
            inSwitch7.IsEnabled = true;
            inSwitch7.Visibility = Visibility.Visible;
            in2Switch7.Visibility = Visibility.Collapsed;
            G2Switch1.IsEnabled = true;
            G2Switch2.IsEnabled = true;
            G2Switch3.IsEnabled = true;
            G2Switch4.IsEnabled = true;
            G2Switch5.IsEnabled = true;
            G2Switch6.IsEnabled = true;
            G2Switch0.IsEnabled = true;

        }

        private void G2Switch0_Selected(object sender, RoutedEventArgs e)
        {
            G1Switch0.IsEnabled = false;
            in2Switch0.IsEnabled = true;
            inSwitch0.Visibility = Visibility.Collapsed;
            in2Switch0.Visibility = Visibility.Visible;
            G1Switch1.IsEnabled = true;
            G1Switch2.IsEnabled = true;
            G1Switch3.IsEnabled = true;
            G1Switch4.IsEnabled = true;
            G1Switch5.IsEnabled = true;
            G1Switch6.IsEnabled = true;
            G1Switch7.IsEnabled = true;

        }
        private void G2Switch1_Selected(object sender, RoutedEventArgs e)
        {
            G1Switch1.IsEnabled = false;
            in2Switch1.IsEnabled = true;
            inSwitch1.Visibility = Visibility.Collapsed;
            in2Switch1.Visibility = Visibility.Visible;
            G1Switch0.IsEnabled = true;
            G1Switch2.IsEnabled = true;
            G1Switch3.IsEnabled = true;
            G1Switch4.IsEnabled = true;
            G1Switch5.IsEnabled = true;
            G1Switch6.IsEnabled = true;
            G1Switch7.IsEnabled = true;

        }

        private void G2Switch2_Selected(object sender, RoutedEventArgs e)
        {
            G1Switch2.IsEnabled = false;
            in2Switch2.IsEnabled = true;
            inSwitch2.Visibility = Visibility.Collapsed;
            in2Switch2.Visibility = Visibility.Visible;
            G1Switch1.IsEnabled = true;
            G1Switch0.IsEnabled = true;
            G1Switch3.IsEnabled = true;
            G1Switch4.IsEnabled = true;
            G1Switch5.IsEnabled = true;
            G1Switch6.IsEnabled = true;
            G1Switch7.IsEnabled = true;

        }

        private void G2Switch3_Selected(object sender, RoutedEventArgs e)
        {
            G1Switch3.IsEnabled = false;
            in2Switch3.IsEnabled = true;
            inSwitch3.Visibility = Visibility.Collapsed;
            in2Switch3.Visibility = Visibility.Visible;
            G1Switch1.IsEnabled = true;
            G1Switch2.IsEnabled = true;
            G1Switch0.IsEnabled = true;
            G1Switch4.IsEnabled = true;
            G1Switch5.IsEnabled = true;
            G1Switch6.IsEnabled = true;
            G1Switch7.IsEnabled = true;

        }

        private void G2Switch4_Selected(object sender, RoutedEventArgs e)
        {
            G1Switch4.IsEnabled = false;
            in2Switch4.IsEnabled = true;
            inSwitch4.Visibility = Visibility.Collapsed;
            in2Switch4.Visibility = Visibility.Visible;
            G1Switch1.IsEnabled = true;
            G1Switch2.IsEnabled = true;
            G1Switch3.IsEnabled = true;
            G1Switch0.IsEnabled = true;
            G1Switch5.IsEnabled = true;
            G1Switch6.IsEnabled = true;
            G1Switch7.IsEnabled = true;

        }

        private void G2Switch5_Selected(object sender, RoutedEventArgs e)
        {
            G1Switch5.IsEnabled = false;
            in2Switch5.IsEnabled = true;
            inSwitch5.Visibility = Visibility.Collapsed;
            in2Switch5.Visibility = Visibility.Visible;
            G1Switch1.IsEnabled = true;
            G1Switch2.IsEnabled = true;
            G1Switch3.IsEnabled = true;
            G1Switch4.IsEnabled = true;
            G1Switch0.IsEnabled = true;
            G1Switch6.IsEnabled = true;
            G1Switch7.IsEnabled = true;

        }

        private void G2Switch6_Selected(object sender, RoutedEventArgs e)
        {
            G1Switch6.IsEnabled = false;
            in2Switch6.IsEnabled = true;
            inSwitch6.Visibility = Visibility.Collapsed;
            in2Switch6.Visibility = Visibility.Visible;
            G1Switch1.IsEnabled = true;
            G1Switch2.IsEnabled = true;
            G1Switch3.IsEnabled = true;
            G1Switch4.IsEnabled = true;
            G1Switch5.IsEnabled = true;
            G1Switch0.IsEnabled = true;
            G1Switch7.IsEnabled = true;

        }

        private void G2Switch7_Selected(object sender, RoutedEventArgs e)
        {
            G1Switch7.IsEnabled = false;
            in2Switch7.IsEnabled = true;
            inSwitch7.Visibility = Visibility.Collapsed;
            in2Switch7.Visibility = Visibility.Visible;
            G1Switch1.IsEnabled = true;
            G1Switch2.IsEnabled = true;
            G1Switch3.IsEnabled = true;
            G1Switch4.IsEnabled = true;
            G1Switch5.IsEnabled = true;
            G1Switch6.IsEnabled = true;
            G1Switch0.IsEnabled = true;

        }
        private void G1Switch0_Unselected(object sender, RoutedEventArgs e)
        {
            inSwitch0.IsEnabled = false;
            G2Switch0.IsEnabled = true;
        }

        private void G1Switch1_Unselected(object sender, RoutedEventArgs e)
        {
            inSwitch1.IsEnabled = false;
            G2Switch1.IsEnabled = true;
        }

        private void G1Switch2_Unselected(object sender, RoutedEventArgs e)
        {
            inSwitch2.IsEnabled = false;
            G2Switch2.IsEnabled = true;
        }

        private void G1Switch3_Unselected(object sender, RoutedEventArgs e)
        {
            inSwitch3.IsEnabled = false;
            G2Switch3.IsEnabled = true;
        }

        private void G1Switch4_Unselected(object sender, RoutedEventArgs e)
        {
            inSwitch4.IsEnabled = false;
            G2Switch4.IsEnabled = true;
        }

        private void G1Switch5_Unselected(object sender, RoutedEventArgs e)
        {
            inSwitch5.IsEnabled = false;
            G2Switch5.IsEnabled = true;
        }

        private void G1Switch6_Unselected(object sender, RoutedEventArgs e)
        {
            inSwitch6.IsEnabled = false;
            G2Switch6.IsEnabled = true;
        }

        private void G1Switch7_Unselected(object sender, RoutedEventArgs e)
        {
            inSwitch7.IsEnabled = false;
            G2Switch7.IsEnabled = true;

        }

        private void G2Switch0_Unselected(object sender, RoutedEventArgs e)
        {
            in2Switch0.IsEnabled = false;
            in2Switch0.Visibility = Visibility.Collapsed;
            inSwitch0.Visibility = Visibility.Visible;
            G1Switch0.IsEnabled = true;
        }

        private void G2Switch1_Unselected(object sender, RoutedEventArgs e)
        {
            in2Switch1.IsEnabled = false;
            in2Switch1.Visibility = Visibility.Collapsed;
            in2Switch1.Visibility = Visibility.Visible;
            G1Switch1.IsEnabled = true;
        }

        private void G2Switch2_Unselected(object sender, RoutedEventArgs e)
        {
            in2Switch2.IsEnabled = false;
            in2Switch2.Visibility = Visibility.Collapsed;
            inSwitch2.Visibility = Visibility.Visible;
            G1Switch2.IsEnabled = true;
        }

        private void G2Switch3_Unselected(object sender, RoutedEventArgs e)
        {
            in2Switch3.IsEnabled = false;
            in2Switch3.Visibility = Visibility.Collapsed;
            inSwitch3.Visibility = Visibility.Visible;
            G1Switch3.IsEnabled = true;
        }

        private void G2Switch4_Unselected(object sender, RoutedEventArgs e)
        {
            in2Switch4.IsEnabled = false;
            in2Switch4.Visibility = Visibility.Collapsed;
            inSwitch4.Visibility = Visibility.Visible;
            G1Switch4.IsEnabled = true;
        }

        private void G2Switch5_Unselected(object sender, RoutedEventArgs e)
        {
            in2Switch5.IsEnabled = false;
            in2Switch5.Visibility = Visibility.Collapsed;
            inSwitch5.Visibility = Visibility.Visible;
            G1Switch5.IsEnabled = true;
        }

        private void G2Switch6_Unselected(object sender, RoutedEventArgs e)
        {
            in2Switch6.IsEnabled = false;
            in2Switch6.Visibility = Visibility.Collapsed;
            inSwitch6.Visibility = Visibility.Visible;
            G1Switch6.IsEnabled = true;
        }

        private void G2Switch7_Unselected(object sender, RoutedEventArgs e)
        {
            in2Switch7.IsEnabled = false;
            in2Switch7.Visibility = Visibility.Collapsed;
            inSwitch7.Visibility = Visibility.Visible;
            G1Switch7.IsEnabled = true;
        }
    

        private void butExecuteNand_Click(object sender, RoutedEventArgs e)
        {
            Window MainWindow = Window.GetWindow(this);
            TextBox tt1 = FindChild<TextBox>(MainWindow, "tt1");
            TextBox tt2 = FindChild<TextBox>(MainWindow, "tt2");
            TextBox tt3 = FindChild<TextBox>(MainWindow, "tt3");
            TextBox tt4 = FindChild<TextBox>(MainWindow, "tt4");

            try
            {

                if (ValidateInputs())
                {

                 string input1 = tt1.Text;
                string input2 = tt2.Text;

                string output = NANDGate(input1, input2);
                tt3.Text = output;

            }

                NotGate newSelect = new NotGate();

                newSelect.input1 = tt1.Text;

                newSelect.input2 = tt2.Text;

                newSelect.output = tt3.Text;
          

                if (tt3.Text == "1")
                {
                    tt4.Text = "High";
                }
                else if (tt3.Text == "0")
                {
                    tt4.Text = "Low";
                }

                newSelect.outputword = tt4.Text;

                selview.Items.Add(newSelect);


                if (GoutLed.SelectedIndex == 0)
                {
                    if (tt3.Text == "1")
                    {
                        Glight0.Visibility = Visibility.Visible;
                        //   Glight0.Visibility = Visibility.Collapsed;
                        Glight1.Visibility = Visibility.Collapsed;
                        Glight2.Visibility = Visibility.Collapsed;
                        Glight3.Visibility = Visibility.Collapsed;
                        Glight4.Visibility = Visibility.Collapsed;
                        Glight5.Visibility = Visibility.Collapsed;
                        Glight6.Visibility = Visibility.Collapsed;
                        Glight7.Visibility = Visibility.Collapsed;

                        light0.Visibility = Visibility.Collapsed;
                        light1.Visibility = Visibility.Visible;
                        light2.Visibility = Visibility.Visible;
                        light3.Visibility = Visibility.Visible;
                        light4.Visibility = Visibility.Visible;
                        light5.Visibility = Visibility.Visible;
                        light6.Visibility = Visibility.Visible;
                        light7.Visibility = Visibility.Visible;

                        Rlight0.Visibility = Visibility.Collapsed;
                        Rlight1.Visibility = Visibility.Collapsed;
                        Rlight2.Visibility = Visibility.Collapsed;
                        Rlight3.Visibility = Visibility.Collapsed;
                        Rlight4.Visibility = Visibility.Collapsed;
                        Rlight5.Visibility = Visibility.Collapsed;
                        Rlight6.Visibility = Visibility.Collapsed;
                        Rlight7.Visibility = Visibility.Collapsed;


                    }
                    else
                    {

                        Rlight0.Visibility = Visibility.Visible;
                        //  Rlight0.Visibility = Visibility.Collapsed;
                        Rlight1.Visibility = Visibility.Collapsed;
                        Rlight2.Visibility = Visibility.Collapsed;
                        Rlight3.Visibility = Visibility.Collapsed;
                        Rlight4.Visibility = Visibility.Collapsed;
                        Rlight5.Visibility = Visibility.Collapsed;
                        Rlight6.Visibility = Visibility.Collapsed;
                        Rlight7.Visibility = Visibility.Collapsed;

                        light0.Visibility = Visibility.Visible;
                        light1.Visibility = Visibility.Visible;
                        light2.Visibility = Visibility.Visible;
                        light3.Visibility = Visibility.Visible;
                        light4.Visibility = Visibility.Visible;
                        light5.Visibility = Visibility.Visible;
                        light6.Visibility = Visibility.Visible;
                        light7.Visibility = Visibility.Visible;


                        Glight0.Visibility = Visibility.Collapsed;
                        Glight1.Visibility = Visibility.Collapsed;
                        Glight2.Visibility = Visibility.Collapsed;
                        Glight3.Visibility = Visibility.Collapsed;
                        Glight4.Visibility = Visibility.Collapsed;
                        Glight5.Visibility = Visibility.Collapsed;
                        Glight6.Visibility = Visibility.Collapsed;
                        Glight7.Visibility = Visibility.Collapsed;
                    }
                }
                else if (GoutLed.SelectedIndex == 1)
                {
                    if (tt3.Text == "1")
                    {
                        Glight1.Visibility = Visibility.Visible;
                        Glight0.Visibility = Visibility.Collapsed;
                        // Glight1.Visibility = Visibility.Collapsed;
                        Glight2.Visibility = Visibility.Collapsed;
                        Glight3.Visibility = Visibility.Collapsed;
                        Glight4.Visibility = Visibility.Collapsed;
                        Glight5.Visibility = Visibility.Collapsed;
                        Glight6.Visibility = Visibility.Collapsed;
                        Glight7.Visibility = Visibility.Collapsed;

                        light0.Visibility = Visibility.Visible;
                        light1.Visibility = Visibility.Visible;
                        light2.Visibility = Visibility.Visible;
                        light3.Visibility = Visibility.Visible;
                        light4.Visibility = Visibility.Visible;
                        light5.Visibility = Visibility.Visible;
                        light6.Visibility = Visibility.Visible;
                        light7.Visibility = Visibility.Visible;

                        Rlight0.Visibility = Visibility.Collapsed;
                        Rlight1.Visibility = Visibility.Collapsed;
                        Rlight2.Visibility = Visibility.Collapsed;
                        Rlight3.Visibility = Visibility.Collapsed;
                        Rlight4.Visibility = Visibility.Collapsed;
                        Rlight5.Visibility = Visibility.Collapsed;
                        Rlight6.Visibility = Visibility.Collapsed;
                        Rlight7.Visibility = Visibility.Collapsed;


                    }
                    else
                    {
                        Rlight1.Visibility = Visibility.Visible;
                        Rlight0.Visibility = Visibility.Collapsed;
                        //   Rlight1.Visibility = Visibility.Collapsed;
                        Rlight2.Visibility = Visibility.Collapsed;
                        Rlight3.Visibility = Visibility.Collapsed;
                        Rlight4.Visibility = Visibility.Collapsed;
                        Rlight5.Visibility = Visibility.Collapsed;
                        Rlight6.Visibility = Visibility.Collapsed;
                        Rlight7.Visibility = Visibility.Collapsed;

                        light0.Visibility = Visibility.Visible;
                        light1.Visibility = Visibility.Visible;
                        light2.Visibility = Visibility.Visible;
                        light3.Visibility = Visibility.Visible;
                        light4.Visibility = Visibility.Visible;
                        light5.Visibility = Visibility.Visible;
                        light6.Visibility = Visibility.Visible;
                        light7.Visibility = Visibility.Visible;


                        Glight0.Visibility = Visibility.Collapsed;
                        Glight1.Visibility = Visibility.Collapsed;
                        Glight2.Visibility = Visibility.Collapsed;
                        Glight3.Visibility = Visibility.Collapsed;
                        Glight4.Visibility = Visibility.Collapsed;
                        Glight5.Visibility = Visibility.Collapsed;
                        Glight6.Visibility = Visibility.Collapsed;
                        Glight7.Visibility = Visibility.Collapsed;
                    }
                }
                else if (GoutLed.SelectedIndex == 2)
                {
                    if (tt3.Text == "1")
                    {
                        Glight2.Visibility = Visibility.Visible;
                        Glight0.Visibility = Visibility.Collapsed;
                        Glight1.Visibility = Visibility.Collapsed;
                        // Glight2.Visibility = Visibility.Collapsed;
                        Glight3.Visibility = Visibility.Collapsed;
                        Glight4.Visibility = Visibility.Collapsed;
                        Glight5.Visibility = Visibility.Collapsed;
                        Glight6.Visibility = Visibility.Collapsed;
                        Glight7.Visibility = Visibility.Collapsed;

                        light0.Visibility = Visibility.Visible;
                        light1.Visibility = Visibility.Visible;
                        light2.Visibility = Visibility.Visible;
                        light3.Visibility = Visibility.Visible;
                        light4.Visibility = Visibility.Visible;
                        light5.Visibility = Visibility.Visible;
                        light6.Visibility = Visibility.Visible;
                        light7.Visibility = Visibility.Visible;

                        Rlight0.Visibility = Visibility.Collapsed;
                        Rlight1.Visibility = Visibility.Collapsed;
                        Rlight2.Visibility = Visibility.Collapsed;
                        Rlight3.Visibility = Visibility.Collapsed;
                        Rlight4.Visibility = Visibility.Collapsed;
                        Rlight5.Visibility = Visibility.Collapsed;
                        Rlight6.Visibility = Visibility.Collapsed;
                        Rlight7.Visibility = Visibility.Collapsed;
                    }
                    else
                    {
                        Rlight2.Visibility = Visibility.Visible;
                        Rlight0.Visibility = Visibility.Collapsed;
                        Rlight1.Visibility = Visibility.Collapsed;
                        //  Rlight2.Visibility = Visibility.Collapsed;
                        Rlight3.Visibility = Visibility.Collapsed;
                        Rlight4.Visibility = Visibility.Collapsed;
                        Rlight5.Visibility = Visibility.Collapsed;
                        Rlight6.Visibility = Visibility.Collapsed;
                        Rlight7.Visibility = Visibility.Collapsed;

                        light0.Visibility = Visibility.Visible;
                        light1.Visibility = Visibility.Visible;
                        light2.Visibility = Visibility.Visible;
                        light3.Visibility = Visibility.Visible;
                        light4.Visibility = Visibility.Visible;
                        light5.Visibility = Visibility.Visible;
                        light6.Visibility = Visibility.Visible;
                        light7.Visibility = Visibility.Visible;


                        Glight0.Visibility = Visibility.Collapsed;
                        Glight1.Visibility = Visibility.Collapsed;
                        Glight2.Visibility = Visibility.Collapsed;
                        Glight3.Visibility = Visibility.Collapsed;
                        Glight4.Visibility = Visibility.Collapsed;
                        Glight5.Visibility = Visibility.Collapsed;
                        Glight6.Visibility = Visibility.Collapsed;
                        Glight7.Visibility = Visibility.Collapsed;

                    }
                }
                else if (GoutLed.SelectedIndex == 3)
                {
                    if (tt3.Text == "1")
                    {
                        Glight3.Visibility = Visibility.Visible;
                        Glight0.Visibility = Visibility.Collapsed;
                        Glight1.Visibility = Visibility.Collapsed;
                        Glight2.Visibility = Visibility.Collapsed;
                        // Glight3.Visibility = Visibility.Collapsed;
                        Glight4.Visibility = Visibility.Collapsed;
                        Glight5.Visibility = Visibility.Collapsed;
                        Glight6.Visibility = Visibility.Collapsed;
                        Glight7.Visibility = Visibility.Collapsed;

                        light0.Visibility = Visibility.Visible;
                        light1.Visibility = Visibility.Visible;
                        light2.Visibility = Visibility.Visible;
                        light3.Visibility = Visibility.Visible;
                        light4.Visibility = Visibility.Visible;
                        light5.Visibility = Visibility.Visible;
                        light6.Visibility = Visibility.Visible;
                        light7.Visibility = Visibility.Visible;

                        Rlight0.Visibility = Visibility.Collapsed;
                        Rlight1.Visibility = Visibility.Collapsed;
                        Rlight2.Visibility = Visibility.Collapsed;
                        Rlight3.Visibility = Visibility.Collapsed;
                        Rlight4.Visibility = Visibility.Collapsed;
                        Rlight5.Visibility = Visibility.Collapsed;
                        Rlight6.Visibility = Visibility.Collapsed;
                        Rlight7.Visibility = Visibility.Collapsed;
                    }
                    else
                    {
                        Rlight3.Visibility = Visibility.Visible;
                        Rlight0.Visibility = Visibility.Collapsed;
                        Rlight1.Visibility = Visibility.Collapsed;
                        Rlight2.Visibility = Visibility.Collapsed;
                        //  Rlight3.Visibility = Visibility.Collapsed;
                        Rlight4.Visibility = Visibility.Collapsed;
                        Rlight5.Visibility = Visibility.Collapsed;
                        Rlight6.Visibility = Visibility.Collapsed;
                        Rlight7.Visibility = Visibility.Collapsed;

                        light0.Visibility = Visibility.Visible;
                        light1.Visibility = Visibility.Visible;
                        light2.Visibility = Visibility.Visible;
                        light3.Visibility = Visibility.Visible;
                        light4.Visibility = Visibility.Visible;
                        light5.Visibility = Visibility.Visible;
                        light6.Visibility = Visibility.Visible;
                        light7.Visibility = Visibility.Visible;


                        Glight0.Visibility = Visibility.Collapsed;
                        Glight1.Visibility = Visibility.Collapsed;
                        Glight2.Visibility = Visibility.Collapsed;
                        Glight3.Visibility = Visibility.Collapsed;
                        Glight4.Visibility = Visibility.Collapsed;
                        Glight5.Visibility = Visibility.Collapsed;
                        Glight6.Visibility = Visibility.Collapsed;
                        Glight7.Visibility = Visibility.Collapsed;

                    }
                }
                else if (GoutLed.SelectedIndex == 4)
                {
                    if (tt3.Text == "1")
                    {
                        Glight4.Visibility = Visibility.Visible;
                        Glight0.Visibility = Visibility.Collapsed;
                        Glight1.Visibility = Visibility.Collapsed;
                        Glight2.Visibility = Visibility.Collapsed;
                        Glight3.Visibility = Visibility.Collapsed;
                        //  Glight4.Visibility = Visibility.Collapsed;
                        Glight5.Visibility = Visibility.Collapsed;
                        Glight6.Visibility = Visibility.Collapsed;
                        Glight7.Visibility = Visibility.Collapsed;

                        light0.Visibility = Visibility.Visible;
                        light1.Visibility = Visibility.Visible;
                        light2.Visibility = Visibility.Visible;
                        light3.Visibility = Visibility.Visible;
                        light4.Visibility = Visibility.Visible;
                        light5.Visibility = Visibility.Visible;
                        light6.Visibility = Visibility.Visible;
                        light7.Visibility = Visibility.Visible;

                        Rlight0.Visibility = Visibility.Collapsed;
                        Rlight1.Visibility = Visibility.Collapsed;
                        Rlight2.Visibility = Visibility.Collapsed;
                        Rlight3.Visibility = Visibility.Collapsed;
                        Rlight4.Visibility = Visibility.Collapsed;
                        Rlight5.Visibility = Visibility.Collapsed;
                        Rlight6.Visibility = Visibility.Collapsed;
                        Rlight7.Visibility = Visibility.Collapsed;
                    }
                    else
                    {
                        Rlight4.Visibility = Visibility.Visible;
                        Rlight0.Visibility = Visibility.Collapsed;
                        Rlight1.Visibility = Visibility.Collapsed;
                        Rlight2.Visibility = Visibility.Collapsed;
                        Rlight3.Visibility = Visibility.Collapsed;
                        // Rlight4.Visibility = Visibility.Collapsed;
                        Rlight5.Visibility = Visibility.Collapsed;
                        Rlight6.Visibility = Visibility.Collapsed;
                        Rlight7.Visibility = Visibility.Collapsed;

                        light0.Visibility = Visibility.Visible;
                        light1.Visibility = Visibility.Visible;
                        light2.Visibility = Visibility.Visible;
                        light3.Visibility = Visibility.Visible;
                        light4.Visibility = Visibility.Visible;
                        light5.Visibility = Visibility.Visible;
                        light6.Visibility = Visibility.Visible;
                        light7.Visibility = Visibility.Visible;

                        Glight0.Visibility = Visibility.Collapsed;
                        Glight1.Visibility = Visibility.Collapsed;
                        Glight2.Visibility = Visibility.Collapsed;
                        Glight3.Visibility = Visibility.Collapsed;
                        Glight4.Visibility = Visibility.Collapsed;
                        Glight5.Visibility = Visibility.Collapsed;
                        Glight6.Visibility = Visibility.Collapsed;
                        Glight7.Visibility = Visibility.Collapsed;

                    }
                }
                else if (GoutLed.SelectedIndex == 5)
                {
                    if (tt3.Text == "1")
                    {
                        Glight5.Visibility = Visibility.Visible;
                        Glight0.Visibility = Visibility.Collapsed;
                        Glight1.Visibility = Visibility.Collapsed;
                        Glight2.Visibility = Visibility.Collapsed;
                        Glight3.Visibility = Visibility.Collapsed;
                        Glight4.Visibility = Visibility.Collapsed;
                        //   Glight5.Visibility = Visibility.Collapsed;
                        Glight6.Visibility = Visibility.Collapsed;
                        Glight7.Visibility = Visibility.Collapsed;

                        light0.Visibility = Visibility.Visible;
                        light1.Visibility = Visibility.Visible;
                        light2.Visibility = Visibility.Visible;
                        light3.Visibility = Visibility.Visible;
                        light4.Visibility = Visibility.Visible;
                        light5.Visibility = Visibility.Visible;
                        light6.Visibility = Visibility.Visible;
                        light7.Visibility = Visibility.Visible;

                        Rlight0.Visibility = Visibility.Collapsed;
                        Rlight1.Visibility = Visibility.Collapsed;
                        Rlight2.Visibility = Visibility.Collapsed;
                        Rlight3.Visibility = Visibility.Collapsed;
                        Rlight4.Visibility = Visibility.Collapsed;
                        Rlight5.Visibility = Visibility.Collapsed;
                        Rlight6.Visibility = Visibility.Collapsed;
                        Rlight7.Visibility = Visibility.Collapsed;
                    }
                    else
                    {
                        Rlight5.Visibility = Visibility.Visible;
                        Rlight0.Visibility = Visibility.Collapsed;
                        Rlight1.Visibility = Visibility.Collapsed;
                        Rlight2.Visibility = Visibility.Collapsed;
                        Rlight3.Visibility = Visibility.Collapsed;
                        Rlight4.Visibility = Visibility.Collapsed;
                        //  Rlight5.Visibility = Visibility.Collapsed;
                        Rlight6.Visibility = Visibility.Collapsed;
                        Rlight7.Visibility = Visibility.Collapsed;

                        light0.Visibility = Visibility.Visible;
                        light1.Visibility = Visibility.Visible;
                        light2.Visibility = Visibility.Visible;
                        light3.Visibility = Visibility.Visible;
                        light4.Visibility = Visibility.Visible;
                        light5.Visibility = Visibility.Visible;
                        light6.Visibility = Visibility.Visible;
                        light7.Visibility = Visibility.Visible;

                        Glight0.Visibility = Visibility.Collapsed;
                        Glight1.Visibility = Visibility.Collapsed;
                        Glight2.Visibility = Visibility.Collapsed;
                        Glight3.Visibility = Visibility.Collapsed;
                        Glight4.Visibility = Visibility.Collapsed;
                        Glight5.Visibility = Visibility.Collapsed;
                        Glight6.Visibility = Visibility.Collapsed;
                        Glight7.Visibility = Visibility.Collapsed;
                    }
                }
                else if (GoutLed.SelectedIndex == 6)
                {
                    if (tt3.Text == "1")
                    {
                        Glight6.Visibility = Visibility.Visible;
                        Glight0.Visibility = Visibility.Collapsed;
                        Glight1.Visibility = Visibility.Collapsed;
                        Glight2.Visibility = Visibility.Collapsed;
                        Glight3.Visibility = Visibility.Collapsed;
                        Glight4.Visibility = Visibility.Collapsed;
                        Glight5.Visibility = Visibility.Collapsed;
                        // Glight6.Visibility = Visibility.Collapsed;
                        Glight7.Visibility = Visibility.Collapsed;

                        light0.Visibility = Visibility.Visible;
                        light1.Visibility = Visibility.Visible;
                        light2.Visibility = Visibility.Visible;
                        light3.Visibility = Visibility.Visible;
                        light4.Visibility = Visibility.Visible;
                        light5.Visibility = Visibility.Visible;
                        light6.Visibility = Visibility.Visible;
                        light7.Visibility = Visibility.Visible;

                        Rlight0.Visibility = Visibility.Collapsed;
                        Rlight1.Visibility = Visibility.Collapsed;
                        Rlight2.Visibility = Visibility.Collapsed;
                        Rlight3.Visibility = Visibility.Collapsed;
                        Rlight4.Visibility = Visibility.Collapsed;
                        Rlight5.Visibility = Visibility.Collapsed;
                        Rlight6.Visibility = Visibility.Collapsed;
                        Rlight7.Visibility = Visibility.Collapsed;
                    }
                    else
                    {
                        Rlight6.Visibility = Visibility.Visible;
                        Rlight0.Visibility = Visibility.Collapsed;
                        Rlight1.Visibility = Visibility.Collapsed;
                        Rlight2.Visibility = Visibility.Collapsed;
                        Rlight3.Visibility = Visibility.Collapsed;
                        Rlight4.Visibility = Visibility.Collapsed;
                        Rlight5.Visibility = Visibility.Collapsed;
                        // Rlight6.Visibility = Visibility.Collapsed;
                        Rlight7.Visibility = Visibility.Collapsed;

                        light0.Visibility = Visibility.Visible;
                        light1.Visibility = Visibility.Visible;
                        light2.Visibility = Visibility.Visible;
                        light3.Visibility = Visibility.Visible;
                        light4.Visibility = Visibility.Visible;
                        light5.Visibility = Visibility.Visible;
                        light6.Visibility = Visibility.Visible;
                        light7.Visibility = Visibility.Visible;
                        Glight0.Visibility = Visibility.Collapsed;
                        Glight1.Visibility = Visibility.Collapsed;
                        Glight2.Visibility = Visibility.Collapsed;
                        Glight3.Visibility = Visibility.Collapsed;
                        Glight4.Visibility = Visibility.Collapsed;
                        Glight5.Visibility = Visibility.Collapsed;
                        Glight6.Visibility = Visibility.Collapsed;
                        Glight7.Visibility = Visibility.Collapsed;

                    }
                }
                else if (GoutLed.SelectedIndex == 7)
                {
                    if (tt3.Text == "1")
                    {
                        Glight7.Visibility = Visibility.Visible;
                        Glight0.Visibility = Visibility.Collapsed;
                        Glight1.Visibility = Visibility.Collapsed;
                        Glight2.Visibility = Visibility.Collapsed;
                        Glight3.Visibility = Visibility.Collapsed;
                        Glight4.Visibility = Visibility.Collapsed;
                        Glight5.Visibility = Visibility.Collapsed;
                        Glight6.Visibility = Visibility.Collapsed;
                        //  Glight7.Visibility = Visibility.Collapsed;

                        light0.Visibility = Visibility.Visible;
                        light1.Visibility = Visibility.Visible;
                        light2.Visibility = Visibility.Visible;
                        light3.Visibility = Visibility.Visible;
                        light4.Visibility = Visibility.Visible;
                        light5.Visibility = Visibility.Visible;
                        light6.Visibility = Visibility.Visible;
                        light7.Visibility = Visibility.Visible;

                        Rlight0.Visibility = Visibility.Collapsed;
                        Rlight1.Visibility = Visibility.Collapsed;
                        Rlight2.Visibility = Visibility.Collapsed;
                        Rlight3.Visibility = Visibility.Collapsed;
                        Rlight4.Visibility = Visibility.Collapsed;
                        Rlight5.Visibility = Visibility.Collapsed;
                        Rlight6.Visibility = Visibility.Collapsed;
                        Rlight7.Visibility = Visibility.Collapsed;
                    }
                    else
                    {
                        Rlight7.Visibility = Visibility.Visible;
                        Rlight0.Visibility = Visibility.Collapsed;
                        Rlight1.Visibility = Visibility.Collapsed;
                        Rlight2.Visibility = Visibility.Collapsed;
                        Rlight3.Visibility = Visibility.Collapsed;
                        Rlight4.Visibility = Visibility.Collapsed;
                        Rlight5.Visibility = Visibility.Collapsed;
                        Rlight6.Visibility = Visibility.Collapsed;
                        //   Rlight7.Visibility = Visibility.Collapsed;

                        light0.Visibility = Visibility.Visible;
                        light1.Visibility = Visibility.Visible;
                        light2.Visibility = Visibility.Visible;
                        light3.Visibility = Visibility.Visible;
                        light4.Visibility = Visibility.Visible;
                        light5.Visibility = Visibility.Visible;
                        light6.Visibility = Visibility.Visible;
                        light7.Visibility = Visibility.Visible;

                        Glight0.Visibility = Visibility.Collapsed;
                        Glight1.Visibility = Visibility.Collapsed;
                        Glight2.Visibility = Visibility.Collapsed;
                        Glight3.Visibility = Visibility.Collapsed;
                        Glight4.Visibility = Visibility.Collapsed;
                        Glight5.Visibility = Visibility.Collapsed;
                        Glight6.Visibility = Visibility.Collapsed;
                        Glight7.Visibility = Visibility.Collapsed;

                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Select Value for Switch 1 and Switch 2", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Select Value for Switch 1 and Switch 2", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType() + " : " + ex.Message);
            }




        }

        private string NANDGate(string input1, string input2)
        {
            if (input1 == "1" && input2 == "1")
                return "0";
            else
                return "1";
        }

        private bool ValidateInputs()
        {
            Window MainWindow = Window.GetWindow(this);
            TextBox tt1 = FindChild<TextBox>(MainWindow, "tt1");
            TextBox tt2 = FindChild<TextBox>(MainWindow, "tt2");
            TextBox tt3 = FindChild<TextBox>(MainWindow, "tt3");
            TextBox tt4 = FindChild<TextBox>(MainWindow, "tt4");


            if (!IsValidBinary(tt1.Text) || !IsValidBinary(tt2.Text))
            {
                MessageBox.Show("Invalid input! Please enter a valid binary value (0 or 1) in both textboxes.");
                return false;
            }

            return true;
        }

        private bool IsValidBinary(string input)
        {
            return input == "0" || input == "1";
        }

        public static T FindChild<T>(DependencyObject parent, string name) where T : DependencyObject
        {
            if (parent == null) return null;

            int childrenCount = VisualTreeHelper.GetChildrenCount(parent);
            for (int i = 0; i < childrenCount; i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);
                string childName = child.GetValue(FrameworkElement.NameProperty) as string;
                if (child is T && childName == name)
                {
                    return (T)child;
                }
                else
                {
                    var result = FindChild<T>(child, name);
                    if (result != null) return result;
                }
            }

            return null;
        }

        private void GoutLed_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (GoutLed.SelectedIndex < 0)
            {
                if (GoutLed.SelectedIndex == 0)
                {   
                    light0.IsEnabled = true;
                }
                if (GoutLed.SelectedIndex == 1)
                {
                    light1.IsEnabled = true;
                }
                if (GoutLed.SelectedIndex == 2)
                {
                    light2.IsEnabled = true;
                }
                if (GoutLed.SelectedIndex == 3)
                {
                    light3.IsEnabled = true;
                }
                if (GoutLed.SelectedIndex == 4)
                {
                    light4.IsEnabled = true;
                }
                if (GoutLed.SelectedIndex == 5)
                {
                    light5.IsEnabled = true;
                }
                if (GoutLed.SelectedIndex == 6)
                {
                    light6.IsEnabled = true;
                }
                if (GoutLed.SelectedIndex == 7)
                {
                    light7.IsEnabled = true;
                }

            }

        }
        private void ClearBut_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you want to proceed?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                if (selview.SelectedItem != null)
                {
                    selview.Items.Remove(selview.SelectedItem);
                }
                else
                {
                    selview.Items.Clear();
                    selview.SelectedIndex = -1;
                    selview.SelectedItem = null;
                }

            }
            else
            {
                return;
            }


        }
    }
}
