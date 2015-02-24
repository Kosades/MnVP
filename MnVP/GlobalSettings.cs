using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MnVP
{
    class GlobalSettings
    {
        private string playerColor;

        public GlobalSettings()
        {
 
        }

        ~GlobalSettings()
        {
 
        }

        public void SetPlayerColor(string color)
        {
            playerColor = color;
        }

        public void ApplySettings()
        {
            
        }
    }
}
