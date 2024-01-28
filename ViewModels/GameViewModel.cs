using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pingpong.ViewModels
{
    [QueryProperty(nameof(PlayerOneName), "playerOneName")]
    [QueryProperty(nameof(PlayerTwoName), "playerTwoName")]
    public partial class GameViewModel : ObservableObject
    {
        public GameViewModel() { }

        [ObservableProperty]
        string playerOneName = "hsdfgfdghbjdfsghbjk";

        [ObservableProperty]
        string playerTwoName = "a";
    }
}
