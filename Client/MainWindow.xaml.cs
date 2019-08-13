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

namespace Client
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int[] numbers = { 5, 10, 8, 3, 6, 12 };
            var result = from num in numbers where num % 2 == 0 orderby num select num;
            //IEnumerable<int> result = from num in numbers where num % 2 == 0 orderby num select num;

            //IEnumerable的結果可以用foreach來取出單一個
            foreach (var i in result)
            {
                MessageBox.Show(i + " ");
            }
        }
    }
}
