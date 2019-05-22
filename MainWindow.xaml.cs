/*Jordan Ross
 * May 22, 2019
 * Numbers to Binary
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

namespace U5_Binary
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

        private void btnConvert_Click(object sender, RoutedEventArgs e)
        {
            string input = txtInput.Text;
            int inputValue = 0;
            int.TryParse(input, out inputValue);
            string binary = Convert.ToString(inputValue, 2);
            lblOutput.Content = binary;
        }
    }
}
