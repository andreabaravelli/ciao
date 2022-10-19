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
using System.IO.Ports;

namespace color_picker
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SerialPort sp = new SerialPort();
        public MainWindow()
        {
            InitializeComponent();

        }
        private void on_Click(object sender, RoutedEventArgs e)
        {
           int Red = 0;
            int Green = 0;
            int Blue = 0;
            if (cp.SelectedColor.HasValue)
            {
                Color C = cp.SelectedColor.Value;
                 Red = C.R;
                 Green = C.G;
                 Blue = C.B;
            }
            sp.Write(Red.ToString());
            //sp.Write(Blue.ToString());
           // sp.Write(Green.ToString());

          //  sp.Write("1");

            
        }

        private void Of_Click(object sender, RoutedEventArgs e)
        {
           
            
            sp.Write("0");
           
        }

        private void Connect_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                String portName = comportno.Text;
                sp.PortName = portName;
                sp.BaudRate = 9600;
                sp.Open();
                status.Text = "Connected";
            }
            catch (Exception)
            {

                MessageBox.Show("Please give a valid port number or check your connection");
            }
        }

        private void Disconnect_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                sp.Close();
                status.Text = "Disconnected";
            }
            catch (Exception)
            {

                MessageBox.Show("First Connect and then disconnect");
            }
        }
    

private void cp_SelectedColorChanged_1(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            if (cp.SelectedColor.HasValue)
            {
                Color C = cp.SelectedColor.Value;
               int Red = C.R;
              int  Green = C.G;
               int Blue = C.B;
                long colorVal = Convert.ToInt64(Blue * (Math.Pow(256, 0)) + Green * (Math.Pow(256, 1)) + Red * (Math.Pow(256, 2)));

            }

        }
    }
}
