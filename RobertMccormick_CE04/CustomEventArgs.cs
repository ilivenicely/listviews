using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformTutorial.Models;

namespace WinformTutorial
{
    public class CustomEventArgs : EventArgs
    {
        public InputModel Model { get; set; }

        public CustomEventArgs(InputModel model)
        {
            Model = model;
        }
    }
}
