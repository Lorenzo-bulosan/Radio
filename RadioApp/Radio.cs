using System;
using System.Collections.Generic;

namespace RadioApp
{
    public class Radio
    {
        private int _channel = 1;
        private bool _on = false;

        public int Channel 
        { 

            get { return _channel; }

            set
            {
                List<int> possibleChannels = new List<int> { 1, 2, 3, 4 };    
                
                if(possibleChannels.Contains(value) && _on){
                    _channel = value;
                }
            } 
        }

        public string Play()
        {
            return _on? $"Playing channel {Channel}" : "Radio is off";
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