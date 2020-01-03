using System;
using System.Collections.Generic;
using System.IO;
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

namespace Voti
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string testo = "voti.txt";
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Riempi_Click(object sender, RoutedEventArgs e)
        {
            if (File.Exists(testo))
            {
                StreamReader r = new StreamReader(testo, Encoding.UTF8);
                var Line = "";
                while (Line != null)
                {
                    Line = r.ReadLine();
                    if (Line != null)
                    {
                        if (Lista.Items.Contains(Line))
                        {
                            Lista.Items.Add(Line);
                        }
                    }
                    
                }
                r.Close();

                
            }
        }
    }
}
