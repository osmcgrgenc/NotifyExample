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

namespace CagriNotificationWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        int counter = 0;
        double _left = 0;
        double _top = 0;
        CagriMessageBox cmb;
        public MainWindow()//top-right
        {
            _left = System.Windows.SystemParameters.PrimaryScreenWidth - 270;
            InitializeComponent();
            CreateTimer();
            this.Left = _left;
        }
        public MainWindow(string Title, string Message, int index)
        {
            _left = System.Windows.SystemParameters.PrimaryScreenWidth - 270;
            _top = System.Windows.SystemParameters.PrimaryScreenHeight - (index * 100);

            InitializeComponent();

            if (Message.Length > 28)
            {
                Message.Insert(27, Environment.NewLine);
                this.Height += 25;
            }

            lblTitle.Content = Title;
            lblMessage.Content = Message;

            CreateTimer();

            this.Left = _left;
            this.Top = _top;
        }
        public MainWindow(string Title, string Message, int index, CagriMessageBox parent)
        {
            _left = System.Windows.SystemParameters.PrimaryScreenWidth - 270;
            _top = System.Windows.SystemParameters.PrimaryScreenHeight - (index * 100);
            cmb = parent;
            InitializeComponent();

            if (Message.Length > 28)
            {
                Message = Message.Insert(27, Environment.NewLine);
                this.Height += 25;
            }

            lblTitle.Content = Title;
            lblMessage.Content = Message;

            CreateTimer();

            this.Left = _left;
            this.Top = _top;
        }
        public MainWindow(string Message, int index, CagriMessageBox parent)
        {
            _left = System.Windows.SystemParameters.PrimaryScreenWidth - 270;
            _top = System.Windows.SystemParameters.PrimaryScreenHeight - (index * 100);
            cmb = parent;
            InitializeComponent();

            if (Message.Length > 28)
            {
                Message = Message.Insert(27, Environment.NewLine);
                this.Height += 25;
            }

            lblTitle.Content = "Bilgilendirme Kutusu";
            lblMessage.Content = Message;

            CreateTimer();

            this.Left = _left;
            this.Top = _top;
        }
        void CreateTimer()
        {
            counter = 0;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Start();
        }
        void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            if (counter == 10)
            {
                cmb.counter--;
                this.Close();
            }
            counter++;
        }
        private void Window_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {

            counter = 5;
        }
    }
}
