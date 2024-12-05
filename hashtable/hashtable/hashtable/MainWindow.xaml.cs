using System.Collections;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace hashtable
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hashtable hashtable;
        public MainWindow()
        {
            InitializeComponent();
            hashtable = new Hashtable();
        }   

        private void Button_add(object sender, RoutedEventArgs e)
        {
            hashtable.Add(txt1.Text, txt2.Text);
        }

        private void Button_remove(object sender, RoutedEventArgs e)
        {
            hashtable.Remove(txt1.Text);
        }

        private void Button_showall(object sender, RoutedEventArgs e)
        {
            ICollection collection = hashtable.Keys;
            foreach (string item in collection)
            {
                MessageBox.Show(hashtable[item].ToString());
            }
        }
    }
}