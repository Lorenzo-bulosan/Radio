using System;
using System.Collections.Generic;

namespace RadioApp
{
    public class Radio
    {
        private int _channel = 1;
        private bool _on = false;
        public Dictionary<int, string> channelSources;

        public Radio()
        {
            Dictionary<int, string> channelDictionary = new Dictionary<int, string>();
            channelDictionary.Add(1, "http://bbcmedia.ic.llnwd.net/stream/bbcmedia_radio1_mf_p");
            channelDictionary.Add(2, "http://bbcmedia.ic.llnwd.net/stream/bbcmedia_radio2_mf_p");
            channelDictionary.Add(3, "http://bbcmedia.ic.llnwd.net/stream/bbcmedia_radio3_mf_p");
            channelDictionary.Add(4, "http://bbcmedia.ic.llnwd.net/stream/bbcmedia_radio4fm_mf_p");

            channelSources = channelDictionary;
        }

        public int Channel 
        { 

            get { return _channel; }

            set
            {
                if(channelSources.ContainsKey(value) && _on){
                    _channel = value;
                }
            } 
        }

        public (string text, bool toPlay) Play()
        {
            return ((_on? $"Playing channel {Channel}" : "Radio is off"), _on);
        }

        public void TurnOff()
        {
            _on = false;
        }
        public void TurnOn()
        {
            _on = true;
        }

    }

}