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
using RadioApp;

namespace RadioWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Radio _radio;
        private int _channelSelected;

        public MainWindow()
        {
            _radio = new Radio();
            InitializeComponent();
        }

        private void BtnOn_Click(object sender, RoutedEventArgs e)
        {
            _radio.TurnOn();
        }

        private void BtnOff_Click(object sender, RoutedEventArgs e)
        {
            _radio.TurnOff();
        }

        private void BtnPlay_Click(object sender, RoutedEventArgs e)
        {
            _channelSelected = _radio.Channel;
            string result = _radio.Play();
            labelChannel.Content = result;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var menuItem = sender as MenuItem;
            if (menuItem != null)
            {
                switch (menuItem.Name)
                {
                    case "_1":
                        _radio.Channel = int.Parse(menuItem.Name.Remove(0, 1));
                        break;
                    case "_2":
                        _radio.Channel = int.Parse(menuItem.Name.Remove(0, 1));
                        break;
                    case "_3":
                        _radio.Channel = int.Parse(menuItem.Name.Remove(0, 1));
                        break;
                    case "_4":
                        _radio.Channel = int.Parse(menuItem.Name.Remove(0, 1));
                        break;
                }
        }
    }
    }
}
