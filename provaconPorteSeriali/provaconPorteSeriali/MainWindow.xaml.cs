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

namespace provaconPorteSeriali
{
    /// <summary>    
    /// Interaction logic for MainWindow.xaml    
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
            sp.Write("1");
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
                sp.Open();// connect the port 
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
                sp.Close(); // disconnect the serial port
                status.Text = "Disconnected";
            }
            catch (Exception)
            {

                MessageBox.Show("First Connect and then disconnect");
            }
        }

        private void comportno_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}