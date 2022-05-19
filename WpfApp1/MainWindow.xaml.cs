using System;
using System.Collections.Generic;
using System.Drawing;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool r = false;

        public MainWindow()
        {
            InitializeComponent();
        }


        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            r = !r;
            V1();
            V2();
        }

        void V1()
        {            
            if (r)
            {
                Image3.Visibility = Visibility.Hidden;
                Image2.Visibility = Visibility.Visible;
            }
            else
            {
                Image3.Visibility = Visibility.Visible;
                Image2.Visibility = Visibility.Hidden;
            }

        }
        void V2()
        { 
            if (r)
            {
                BitmapImage b = new BitmapImage(new Uri("among-us-pngs.png", UriKind.Relative));

                Image1.Source = b;
                Grid1.Background = new ImageBrush { ImageSource = b };
            }
            else
            {
                BitmapImage b = new BitmapImage(new Uri("spider-man.png", UriKind.Relative));

                Image1.Source = b;
                Grid1.Background = new ImageBrush { ImageSource = b };
            }

        }
    }
}
