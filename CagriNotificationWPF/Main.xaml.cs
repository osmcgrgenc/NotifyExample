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
using System.Windows.Shapes;

namespace CagriNotificationWPF
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        CagriMessageBox mb = new CagriMessageBox();
        public Main()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mb.ShowMessage("Bu bir deneme mesajıdır. Lütfen itibar etmeyiniz!");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            mb.ShowMessage("Uyarı", "Bu bir deneme mesajıdır. Lütfen itibar etmeyiniz!");
        }
    }
}
