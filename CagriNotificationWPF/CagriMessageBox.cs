using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CagriNotificationWPF
{
    public class CagriMessageBox
    {
        int maxcount = 9;
        public static int example = 0;
        public int counter = 0;
        
        public CagriMessageBox()
        {
        }
        public void ShowMessage(string Title)
        {

            counter++;
            example++;
            if (counter <= maxcount)
            {
                MainWindow mw = new MainWindow(Title, example%9+1, this);
                
                mw.Show();
            }
            
        }
        public void ShowMessage(string Title, string Message)
        {
            counter++;
            example++;
            if (counter <= maxcount)
            {
                //MainWindow mw = new MainWindow(Title, Message, example);
                MainWindow mw = new MainWindow(Title, Message, example % 9 + 1, this);
               
                mw.Show();
            }
            
        }

    }
}
