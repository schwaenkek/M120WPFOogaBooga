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

namespace M120WPFOogaBooga
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();

            txt_output.Text = "";
            try
            {
                for (int i = 0; i < Convert.ToUInt16(txt_Numba_Amount.Text); i++)
                {
                    txt_output.Text += rnd.Next(/*Lowest Numba*/Convert.ToInt32(txt_Lowest_Numba.Text), /*Highest numba*/Convert.ToInt32(txt_Highest_Numba.Text)) + ", ";
                }
            }
            catch
            {
                Console.WriteLine("euou. numba prolly incowekt");
            }

        }
    }
}
