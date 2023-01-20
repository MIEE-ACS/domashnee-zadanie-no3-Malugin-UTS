using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace дз3
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

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            string str = Convert.ToString(tb1.Text);
            int count = 0;
            int n = 0, startIndex = -1;
            while ((startIndex = str.IndexOf(".", ++startIndex)) >= 0)
                ++n;
            while ((startIndex = str.IndexOf("!", ++startIndex)) >= 0)
                ++n;
            while ((startIndex = str.IndexOf("?", ++startIndex)) >= 0)
                ++n;


            tb2.Text = n.ToString();



                



            
        }

        private void tb1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tb2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
