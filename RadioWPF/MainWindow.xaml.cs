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
        private int channelSelected;

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
            string result = _radio.Play();
            labelChannel.Content = result;
        }
    }
}
