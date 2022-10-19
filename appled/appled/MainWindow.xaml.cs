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

namespace appled
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
        
        
        }

        private void ColourSelection_Click(object sender, RoutedEventArgs e)
        {
            //Byte Red = 0;
            //Byte Green = 0;  
            //Byte Blue = 0;
            //ColourSelection.Background = new SolidColorBrush(Color.FromArgb(255, Red, Green, Blue));

            string rosso = rosso1.Text;
            Byte Red = Byte.Parse(rosso);

            string verde1 = verde.Text;
            Byte Green = Byte.Parse(verde1);

            string Blu1 = blue.Text;

            Byte Blue = Byte.Parse(Blu1);

      
      
            
            bool[] statoLed = new bool[4];
            for (int i = 0; i < 4; i++)
            {

                statoLed[i]= 

            }      
       

        }

        private void led_Click(object sender, RoutedEventArgs e)
        {
            bool turnOn = true;
            //string rosso = rosso1.Text ;
            //Byte Red = Byte.Parse(rosso);
           
            //string verde1 = verde.Text ;
            //Byte Green= Byte .Parse(verde1);

            //string Blu1 = blue.Text;

            //Byte Blue = Byte.Parse(Blu1); 
            
            
            
            //led.Background = new SolidColorBrush(Color.FromArgb(255, Red, Green, Blue));
        }

        private void led1_Click(object sender, RoutedEventArgs e)
        {

             bool turnOn = true;

            //string rosso = rosso1.Text;
            //Byte Red = Byte.Parse(rosso);

            //string verde1 = verde.Text;
            //Byte Green = Byte.Parse(verde1);

            //string Blu1 = blue.Text;

            ////Byte Blue = Byte.Parse(Blu1);
            ////led1.Background = new SolidColorBrush(Color.FromArgb(255, Red, Green, Blue));
        }
    }
}
