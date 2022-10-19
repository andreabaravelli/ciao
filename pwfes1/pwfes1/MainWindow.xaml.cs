using System.Windows;

namespace pwfes1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow 
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void sconto_Click(object sender, RoutedEventArgs e)
        {

            string prezzo;
            prezzo = importo.Text;
            int import = int.Parse(prezzo);


            if (import >= 100)
            {
                MessageBox.Show("il tuo sconto è:");


            }


        }


        private void aliquota_Click(object sender, RoutedEventArgs e)
        {

            string redittoLordo;
            redittoLordo = relor.Text;
            int dirtyIncome = int.Parse(redittoLordo);
            double IVA = 0.0;
            int[] scaglioni = { 15000, 28000, 55000 };
            double[] percentuali = { 0.23, 0.27, 0.38, 0.41 };



            if (dirtyIncome <= scaglioni[0])
            {
                IVA = dirtyIncome * percentuali[0];

                MessageBox.Show($"devipagare {IVA} $ di iva");

            }
            else
            {
                if (dirtyIncome <= scaglioni[1] && dirtyIncome >= scaglioni[0])
                {
                    IVA = scaglioni[0] * percentuali[0] + (dirtyIncome - scaglioni[0]) * percentuali[1];
                    MessageBox.Show($"devipagare {IVA} $ di iva");
                }
                else
                {
                    if (dirtyIncome <= scaglioni[2] && dirtyIncome >= scaglioni[1])
                    {
                        IVA = scaglioni[0] * percentuali[0] + (scaglioni[1] - scaglioni[0]) * percentuali[1] + (dirtyIncome - scaglioni[1]) * percentuali[2];
                        MessageBox.Show($"devipagare {IVA} $ di iva");

                    }
                    else
                    {
                        IVA = scaglioni[0] * percentuali[0] + (scaglioni[1] - scaglioni[0]) * percentuali[1] + (scaglioni[2] - scaglioni[1]) * percentuali[2] + (dirtyIncome - scaglioni[2]) * percentuali[3];
                        MessageBox.Show($"devipagare {IVA} $ di iva");

                    }


                }

            }

        }

        private void importo_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void relor_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
    }
}
