using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
using System.Xml;

namespace WpfXML
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        XmlDocument xmlDoc = new XmlDocument();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog apri = new OpenFileDialog();

            if (apri.ShowDialog() == true) // il pannello riamane visibile fiche mom si fa apri 
            {

                string nomeFile = apri.FileName;

                // dichiarazione documento  

                // caricamento in memoria 

                xmlDoc.Load(nomeFile);


                // determinare il nome della radice
                XmlElement radice = xmlDoc.DocumentElement;


                XmlNodeList elenco = radice.ChildNodes;

                lstDati.Items.Clear();

                foreach (XmlNode node in elenco)
                {
                    XmlNodeList elencoInfo = node.ChildNodes;

                    lstDati.Items.Add(elencoInfo[1].InnerText);
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog apri = new OpenFileDialog();

            if (apri.ShowDialog() == true) // il pannello riamane visibile fiche mom si fa apri 
            {

                string nomeFile = apri.FileName;

                // dichiarazione documento  


                // caricamento in memoria 

                xmlDoc.Load(nomeFile);


                // determinare il nome della radice
                XmlElement radice = xmlDoc.DocumentElement;

                XmlNodeList elenco = radice.ChildNodes;

                treeDati.Items.Clear();

                TreeViewItem elementoRoot = new TreeViewItem();
                elementoRoot.Header = radice.Name;

                foreach (XmlNode node in elenco)                    // formazione del treeview
                {

                    TreeViewItem treeViewItem = new TreeViewItem();

                    treeViewItem.Header = node.Name;
                    XmlNodeList elencoInfo = node.ChildNodes;

                    foreach (XmlNode nodoInfo in elencoInfo)   // ciclo  che permette di aggiungere gli oggetti alla treeview
                    {

                        treeViewItem.Items.Add((XmlElement)nodoInfo);

                    }

                    treeViewItem.IsExpanded = true;
                    elementoRoot.Items.Add(treeViewItem);
                }

                treeDati.Items.Add(elementoRoot);
            }
        }

        private void informazioni_Click(object sender, RoutedEventArgs e)
        {

            XmlElement nuovoNodo = xmlDoc.CreateElement("CD");

            XmlElement title = xmlDoc.CreateElement("title");

            title.InnerText = txtTitle.Text;

            XmlElement artist = xmlDoc.CreateElement("artist");

            artist.InnerText = txtArtist.Text;

            XmlElement country = xmlDoc.CreateElement("country");


            country.InnerText = txtCountry.Text;


            nuovoNodo.AppendChild(title);
            nuovoNodo.AppendChild(artist);
            nuovoNodo.AppendChild(country);

            XmlElement radice = xmlDoc.DocumentElement;

            radice.AppendChild(nuovoNodo);

            xmlDoc.Save("C:/Users/andrea.baravelli/Desktop/cd_catalog.xml");


        }

        private void ricerca_Click(object sender, RoutedEventArgs e) // metodo che permette di ricercare l'artista
        {
            XmlNodeList risultato = xmlDoc.SelectNodes("/CATALOG/CD/ARTIST");

            string artistaCercato = ARicercato.Text;

            bool esistenza = true;



            foreach (XmlNode artist in risultato)
            {

                string artista = artist.InnerText;

                // istruzione che permette di inserire i nomi degli artisti all'interno di una listbox basta togliere i due slash nella riga successiva a questa per avere anche quella opzione
                //RicercaDati.Items.Add(artista); (ho cambiato il nome della listbox quindi non funziona più)


                // selezione che permette di controllare l'esistenza dell'oggetto cercato

                if (artista == artistaCercato)
                {
                    esistenza = true;


                }

            }

            if (esistenza == true)
            {
                MessageBox.Show("l'artista che hai cercato esiste");

            }
            else
            {

                MessageBox.Show("l'artista che hai cercato non esiste");
            }

        }

       

        private void CercaPrezzo_Click_1(object sender, RoutedEventArgs e)
        {
            int valoreLimite = 10;

            XmlNodeList risultato = xmlDoc.SelectNodes("/CATALOG/CD/PRICE");

            XmlNodeList nomi = xmlDoc.SelectNodes("/CATALOG/CD/TITLE");

            foreach (XmlNode prezzo in risultato)
            {
                int price = int.Parse(prezzo.InnerText);

                if (price < 10)
                {

                    foreach (XmlNode nome in nomi)

                       

                    RicercaDati.Items.Add(nome.InnerText);


                    MessageBox.Show("fin qui ci siamo arrivati");
                }

            }
        }
    }
}

