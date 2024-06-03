using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace LogicTrainer_App.Pages
{
    /// <summary>
    /// Interaction logic for NotGatePage.xaml
    /// </summary>
    public partial class NotGatePage : Page
    {
        public NotGatePage()
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

          //  light0.IsEnabled = false;
            light1.IsEnabled = false;
            light2.IsEnabled = false;
            light3.IsEnabled = false;
            light4.IsEnabled = false;
            light5.IsEnabled = false;
            light6.IsEnabled = false;
            light7.IsEnabled = false;

        }

        public class NotGate
        {

            public string inputnot { get; set; }
            public string outputnot { get; set; }
            public string outputword { get; set; }


        }
        private void G1Switch0_Selected(object sender, RoutedEventArgs e)
        {
            inSwitch0.IsEnabled = true;
           
        }

        private void G1Switch1_Selected(object sender, RoutedEventArgs e)
        {
           
            inSwitch1.IsEnabled = true;
        }

        private void G1Switch2_Selected(object sender, RoutedEventArgs e)
        {
  
            inSwitch2.IsEnabled = true;
        }

        private void G1Switch3_Selected(object sender, RoutedEventArgs e)
        {
            inSwitch3.IsEnabled = true;
        }

        private void G1Switch4_Selected(object sender, RoutedEventArgs e)
        {
            inSwitch4.IsEnabled = true;
        }

        private void G1Switch5_Selected(object sender, RoutedEventArgs e)
        {
            inSwitch5.IsEnabled = true;
        }

        private void G1Switch6_Selected(object sender, RoutedEventArgs e)
        {
            inSwitch6.IsEnabled = true;
        }

        private void G1Switch7_Selected(object sender, RoutedEventArgs e)
        {
            inSwitch7.IsEnabled = true;
        }
  
        private void G1Switch0_Unselected(object sender, RoutedEventArgs e)
        {
            inSwitch0.IsEnabled = false;
            
        }

        private void G1Switch1_Unselected(object sender, RoutedEventArgs e)
        {
            inSwitch1.IsEnabled = false;
        
        }

        private void G1Switch2_Unselected(object sender, RoutedEventArgs e)
        {
            inSwitch2.IsEnabled = false;
            
        }

        private void G1Switch3_Unselected(object sender, RoutedEventArgs e)
        {
            inSwitch3.IsEnabled = false;
        }

        private void G1Switch4_Unselected(object sender, RoutedEventArgs e)
        {
            inSwitch4.IsEnabled = false;
        }

        private void G1Switch5_Unselected(object sender, RoutedEventArgs e)
        {
            inSwitch5.IsEnabled = false;
        }

        private void G1Switch6_Unselected(object sender, RoutedEventArgs e)
        {
            inSwitch6.IsEnabled = false;
        }

        private void G1Switch7_Unselected(object sender, RoutedEventArgs e)
        {
            inSwitch7.IsEnabled = false;

        }

        private void butExecuteNot_Click(object sender, RoutedEventArgs e)
        {
            Window MainWindow = Window.GetWindow(this);
            TextBox tt1 = FindChild<TextBox>(MainWindow, "tt1");
            TextBox tt3 = FindChild<TextBox>(MainWindow, "tt3");
            TextBox tt4 = FindChild<TextBox>(MainWindow, "tt4");

            try
            {
                //calculate not gate
                int input = Convert.ToInt32(tt1.Text);

                bool inputBool = (input != 0);

                bool output = !inputBool;

                int result = (output ? 1 : 0);

                tt3.Text = result.ToString();

                // read to listview
                NotGate newSelect = new NotGate();

                newSelect.inputnot = tt1.Text;

                newSelect.outputnot = tt3.Text;

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
                MessageBox.Show("Select Value for input Switch", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Select Value for input Switch", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType() + " : " + ex.Message);
            }




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
