/*Andrea Bonafini
 * 2/8/19
 * While Example
 * 
 */
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

namespace _319481WhileExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            System.IO.StreamReader reader = new System.IO.StreamReader("myFile.txt");
            try {
                string output = "";
                    while (!reader.EndOfStream)
                {
                    output += reader.ReadLine()
                        + Environment.NewLine;
                }
                lblOutput.Content = output;
                output = output.Trim();
            }catch (Exception ex) { }
        }
    }
}
