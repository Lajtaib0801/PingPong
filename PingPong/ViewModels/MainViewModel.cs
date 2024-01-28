using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
               
        }

        [ObservableProperty]
        string playerOneName;

        [ObservableProperty]
        string playerTwoName;

        [ICommand]
        Task NavigateToGamePage()
        {
            if(!String.IsNullOrWhiteSpace(playerOneName) && !String.IsNullOrWhiteSpace(playerTwoName))
            {
                return Shell.Current.GoToAsync($"{nameof(GamePage)}?pOneName={playerOneName}&pTwoName={playerTwoName}");
            }
            return Shell.Current.DisplayAlert("Hiba!", "Mindekét játékos nevét kötelező megadni!", "Ok");
        }


    }
}
