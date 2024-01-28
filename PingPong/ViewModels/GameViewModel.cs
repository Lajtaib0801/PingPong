using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.ViewModels
{
    [QueryProperty(nameof(PlayerOneName), "pOneName")]
    [QueryProperty(nameof(PlayerTwoName), "pTwoName")]
    public partial class GameViewModel : ObservableObject
    {
        public GameViewModel()
        {
            
        }

        [ObservableProperty]
        string playerOneName;

        [ObservableProperty]
        string playerTwoName;

    }
}
