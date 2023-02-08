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

namespace XO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            But1.IsEnabled = false;
            But2.IsEnabled = false;
            But3.IsEnabled = false;
            But4.IsEnabled = false;
            But5.IsEnabled = false;
            But6.IsEnabled = false;
            But7.IsEnabled = false;
            But8.IsEnabled = false;
            But9.IsEnabled = false;

        }
        string check;
        int user;

        private void Click(object sender, RoutedEventArgs e)
        {
            Button senderr = (Button)sender;
                    if (user == 0)
                    {
                        senderr.Content = "O";
                        senderr.IsEnabled = false;
                    }
                    else
                    {
                        senderr.Content = "X";
                        senderr.IsEnabled = false;
                    }
                    Check();
                     robot();

        }

        private void Nach_Click(object sender, RoutedEventArgs e)
        {
            ttext.Text = " ";
            Nach.IsEnabled= false;
            But1.Content = " "; But2.Content = " "; But3.Content = " "; But4.Content = " "; But5.Content = " "; But6.Content = " "; But7.Content = " "; But8.Content = " "; But9.Content = " "; 
            But1.IsEnabled = true; But2.IsEnabled=true; But3.IsEnabled=true; But4.IsEnabled=true; But5.IsEnabled=true; But6.IsEnabled=true; But7.IsEnabled = true; But8.IsEnabled = true; But9.IsEnabled = true;
            if (user == 0)
            {
                user = 1;
            }
            else
            {
                user = 0;
            }
        }

        public void Check()
        {
            if ((But1.Content == "X" && But5.Content == "X" && But9.Content == "X") || (But1.Content == "X" && But4.Content == "X" && But7.Content == "X") || (But1.Content == "X" && But2.Content == "X" && But3.Content == "X") || (But4.Content == "X" && But5.Content == "X" && But6.Content == "X") || (But7.Content == "X" && But8.Content == "X" && But9.Content == "X") || (But3.Content == "X" && But5.Content == "X" && But7.Content == "X") || (But3.Content == "X" && But6.Content == "X" && But9.Content == "X") || (But2.Content == "X" && But5.Content == "X" && But3.Content == "X"))
            {
                ttext.Text = "Выиграли крестики";
                Nach.IsEnabled = true;

                But1.IsEnabled = false;
                But2.IsEnabled = false;
                But3.IsEnabled = false;
                But4.IsEnabled = false;
                But5.IsEnabled = false;
                But6.IsEnabled = false;
                But7.IsEnabled = false;
                But8.IsEnabled = false;
                But9.IsEnabled = false;
            }
            else if ((But1.Content == "O" && But5.Content == "O" && But9.Content == "O") || (But1.Content == "O" && But4.Content == "O" && But7.Content == "O") || (But1.Content == "O" && But2.Content == "O" && But3.Content == "O") || (But4.Content == "O" && But5.Content == "O" && But6.Content == "O") || (But7.Content == "O" && But8.Content == "O" && But9.Content == "O") || (But3.Content == "O" && But5.Content == "O" && But7.Content == "O") || (But3.Content == "O" && But6.Content == "O" && But9.Content == "O") || (But2.Content == "O" && But5.Content == "O" && But3.Content == "O"))
            {
                ttext.Text = "Выиграли нолики";
                Nach.IsEnabled = true;

                But1.IsEnabled = false;
                But2.IsEnabled = false;
                But3.IsEnabled = false;
                But4.IsEnabled = false;
                But5.IsEnabled = false;
                But6.IsEnabled = false;
                But7.IsEnabled = false;
                But8.IsEnabled = false;
                But9.IsEnabled = false;
            }
            else if (But1.IsEnabled != true && But2.IsEnabled != true && But3.IsEnabled != true && But4.IsEnabled != true && But5.IsEnabled != true && But6.IsEnabled != true && But7.IsEnabled != true && But8.IsEnabled != true && But9.IsEnabled != true)
            {
                ttext.Text = "Ничья";
                Nach.IsEnabled = true;
            }
        }
        private void robot()
        { 
            if (But1.IsEnabled == true || But2.IsEnabled == true || But3.IsEnabled == true || But4.IsEnabled == true || But5.IsEnabled == true || But6.IsEnabled == true || But7.IsEnabled == true || But8.IsEnabled == true || But9.IsEnabled == true)
            {
                Random random = new Random();
                int rand = random.Next(1, 9);
                switch (rand)
                {
                    case 1:
                        {
                            if (But1.IsEnabled == false)
                            {
                                robot();
                            }
                            else
                            {
                                if (user == 0)
                                {
                                    But1.Content = "X";
                                }
                                else
                                {
                                    But1.Content = "O";
                                }
                                But1.IsEnabled = false;
                            }
                            break;
                        }
                    case 2:
                        {
                            if (But2.IsEnabled == false)
                            {
                                robot();
                            }
                            else
                            {
                                if (user == 0)
                                {
                                    But2.Content = "X";
                                }
                                else
                                {
                                    But2.Content = "O";
                                }
                                But2.IsEnabled = false;
                            }
                            break;
                        }
                    case 3:
                        {
                            if (But3.IsEnabled == false)
                            {
                                robot();
                            }
                            else
                            {
                                if (user == 0)
                                {
                                    But3.Content = "X";
                                }
                                else
                                {
                                    But3.Content = "O";
                                }
                                But3.IsEnabled = false;
                            }
                            break;
                        }
                    case 4:
                        {
                            if (But4.IsEnabled == false)
                            {
                                robot();
                            }
                            else
                            {
                                if (user == 0)
                                {
                                    But4.Content = "X";
                                }
                                else
                                {
                                    But4.Content = "O";
                                }
                                But4.IsEnabled = false;
                            }
                            break;
                        }
                    case 5:
                        {
                            if (But5.IsEnabled == false)
                            {
                                robot();
                            }
                            else
                            {
                                if (user == 0)
                                {
                                    But5.Content = "X";
                                }
                                else
                                {
                                    But5.Content = "O";
                                }
                                But5.IsEnabled = false;
                            }
                            break;
                        }
                    case 6:
                        {
                            if (But6.IsEnabled == false)
                            {
                                robot();
                            }
                            else
                            {
                                if (user == 0)
                                {
                                    But6.Content = "X";
                                }
                                else
                                {
                                    But6.Content = "O";
                                }
                                But6.IsEnabled = false;
                            }
                            break;
                        }
                    case 7:
                        {
                            if (But7.IsEnabled == false)
                            {
                                robot();
                            }
                            else
                            {
                                if (user == 0)
                                {
                                    But7.Content = "X";
                                }
                                else
                                {
                                    But7.Content = "O";
                                }
                                But7.IsEnabled = false;
                            }
                            break;
                        }
                    case 8:
                        {
                            if (But8.IsEnabled == false)
                            {
                                robot();
                            }
                            else
                            {
                                if (user == 0)
                                {
                                    But8.Content = "X";
                                }
                                else
                                {
                                    But8.Content = "O";
                                }
                                But8.IsEnabled = false;
                            }
                            break;
                        }
                    case 9:
                        {
                            if (But9.IsEnabled == false)
                            {
                                robot();
                            }
                            else
                            {
                                if (user == 0)
                                {
                                    But9.Content = "X";
                                }
                                else
                                {
                                    But9.Content = "O";
                                }
                                But9.IsEnabled = false;
                            }
                            break;
                        }
                }
                Check();
            }
        }
    }
}
