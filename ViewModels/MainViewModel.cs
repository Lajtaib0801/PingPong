using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pingpong.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
            
        }

        [ObservableProperty]
        string playerOneName = "dfghdfgh";

        [ObservableProperty]
        string playerTwoName = "sgdfghdfg";

        [ICommand]
        Task NavigateToGamePage()
        {
            if (!String.IsNullOrWhiteSpace(playerOneName) &&
                !String.IsNullOrWhiteSpace(playerTwoName))
            {
                return Shell.Current.GoToAsync($"{nameof(GamePage)}?PlayerOneName={playerOneName}&PlayerTwoName={PlayerTwoName}");
            }
            return Shell.Current.DisplayAlert("Hiba!", "Mindkét játékos nevét kötelező megadni!", "Ok");
        }
    }
}
