using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.EventArgs
{
    public class GameMessageEventArgs : System.EventArgs
    {
        public String Message { get; private set; }

        public GameMessageEventArgs (string message)
        {
            Message = message;
        }
    }
}
