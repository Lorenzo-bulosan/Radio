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

        public MainWindow()
        {
            _radio = new Radio();
            InitializeComponent();
        }

        private void BtnOn_Click(object sender, RoutedEventArgs e)
        {
            _radio.TurnOn();
            labelChannel.Content = "Radio ON, select a station";
        }

        private void BtnOff_Click(object sender, RoutedEventArgs e)
        {
            _radio.TurnOff();
            MediaPlayer.Stop();
            labelChannel.Content = "Radio OFF";
        }

        private void BtnPlay_Click(object sender, RoutedEventArgs e)
        {
            // display text
            string result = _radio.Play().text;
            labelChannel.Content = result;

            // play selected channel if on
            if (_radio.Play().toPlay)
            {

                MediaPlayer.Source = new Uri(_radio.channelSources[_radio.Channel], UriKind.RelativeOrAbsolute);
                MediaPlayer.Volume = _radio.Volume;
                MediaPlayer.Play();

                // show buffer message to user
                while (MediaPlayer.IsBuffering)
                {
                    screen.Content = "Buffering...";
                }

                screen.Content =  $"BBC RADIO: {_radio.Channel}";
            }     
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

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            _radio.Volume = SliderVolumeChange.Value;
            MediaPlayer.Volume = _radio.Volume;
            screenVolume.Content = Math.Round(_radio.Volume,2)*100;
        }
    }
}


