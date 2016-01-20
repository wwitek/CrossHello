using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossHello.Mobile.ViewModels
{
    public class MainWindowViewModel
    {
        public string SayHiText { get; set; }

        public MainWindowViewModel()
        {
            SayHiText = "Hey there!";
        }
    }
}
