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

namespace conversione_assegno
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
   


     
class negativeNumberException : Exception
{
    public negativeNumberException() { }

    public negativeNumberException(double cifra)
        : base(String.Format("inserisci un valore diverso da zero e positivo"))
    {

    }
}
    public partial class MainWindow : Window

    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void convertitore_Click(object sender, RoutedEventArgs e)
        {
            const string cento = "cento";

            string[] decineEEccezioni = {"dieci","undici","dodici","tredici","quattordici","quindici","sedici"
                    ,"diciassette","diciotto","diciannove","venti","trenta","quaranta","cinquanta","sessanta","settanta","ottanta","novanta" };
          
            string[] unita = { "uno", "due", "tre", "quattro", "cinque", "sei", "sette", "otto","nove" };
            string rimborso = importo.Text;
            // divisione della parte intera da quella decimale
            string[] interoEDecimale= rimborso.Split(',');
            string parteIntera= interoEDecimale[0];
            string parteDecimale= interoEDecimale[1];

            int nEccezioni = 10;
            string versamento = "";
            bool stop = false;

            int pos = 0;

            // controllo se la tarte intera è maggiore di zero
            double cifra = double.Parse(rimborso);
           
            
            if (cifra <= 0)
            {
                throw new negativeNumberException(cifra);
                
            }


            // controllo il numero di cifre della parte intera

            switch (parteIntera.Length)
            {
                case 3:
                   
                    for (int i = 0; i < parteIntera.Length && stop == false; i++)
                    {
                        if (parteIntera[i] == '0')
                        {

                        }
                        else
                        {
                            if (i == 0)
                            {
                                pos = int.Parse(parteIntera[i].ToString());// utilizzando l'indice di una stringa e non un metodo substring mi prende solo un carattere che non può essere 
                                                                            // convertito direttamente in tipo int, ma prima deve essere convertito in stringa e poi in intero

                                versamento = unita[pos - 1] + cento;

                            }

                            if (i == 1)
                            {
                                if (parteIntera[i] == '1')
                                {
                                    int t = 2;

                                    string stringaTemporanea = parteIntera[t].ToString();

                                    pos = int.Parse(stringaTemporanea);

                                    versamento += decineEEccezioni[pos];



                                    pos = 0;

                                    stop = true;
                                }
                                else
                                {
                                    // per trovare la posizione del valore delle decine ho preso il valore iesimo della stringa parte intera
                                    // questo è un char non una stringa quindi prima di poterlo convertire in un int ho dovuto convertirlo in stringa
                                        pos = int.Parse(parteIntera[i].ToString());

                                        versamento += decineEEccezioni[nEccezioni + pos - 2];
                                    
                                }

                            }
                          
                          
                                if (i == 2)
                                {
                                    pos = int.Parse(parteIntera[i].ToString());
                                    versamento += unita[pos - 1];

                                }
                            
                        }
                    }
            
                    lettere.Content = $"{versamento}/{parteDecimale}";


                    break;


                    case 2:
                    for (int i = 0; i<parteIntera.Length && stop==false ;i++)
                    {
                       if (i == 0)
                        {
                            if(parteIntera[i] == '1')
                            {
                                int t = 1;

                                string stringaTemporanea = parteIntera[t].ToString();

                                 pos = int.Parse(stringaTemporanea);

                                versamento = decineEEccezioni[pos];

                              
                                
                                pos = 0;
                               
                                stop= true;
                            }
                            else
                            {
                                // per trovare la posizione del valore delle decine ho preso il valore iesimo della stringa parte intera
                                // questo è un char non una stringa quindi prima di poterlo convertire in un int ho dovuto convertirlo in stringa

                                pos= int.Parse(parteIntera[i].ToString());  

                                versamento = decineEEccezioni[nEccezioni+pos-2] ;

                            }

                        }

                       if (i == 1) 
                        {
                            pos = int.Parse(parteIntera[i].ToString());
                            versamento += unita[pos-1];

                        }
                    }
                   

                    lettere.Content = $"{versamento}/{parteDecimale}";
                    break;

                case 1:

                    pos = int.Parse(parteIntera);

                    versamento = unita[pos-1];

                    lettere.Content = $"{versamento}/{parteDecimale}";
                    break;

            }
             

        }

        private void importo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
