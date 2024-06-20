using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Jokenpo.Model;
using System.Windows.Input;

namespace Jokenpo.ViewModel
{
    public partial class JokenpoViewModel : ObservableObject
    {
        [ObservableProperty]
        private int scorePlayer;

        [ObservableProperty]
        private int scoreBot;

        [ObservableProperty]
        private string lastWinner;

        [ObservableProperty]
        private string sourcePlayer;

        [ObservableProperty]
        private string sourceBot;

        [ObservableProperty]
        private int indexPicker;

        [ObservableProperty]
        private string winner;

        private Bot bot = new Bot();

        public ICommand FlipCommand { get; }

        public JokenpoViewModel()
        {
            FlipCommand = new RelayCommand(GetWinner);
        }

        public void GetWinner()
        {

            bot.sortSide();
            Options selectedOption = (Options)(IndexPicker + 1);

            SourceBot = $"{bot.Side.ToString().ToLower()}.jpeg";

            SourcePlayer = $"{selectedOption.ToString().ToLower()}.jpeg";
            if(VerifyWinner() != "") {
                Winner = VerifyWinner();
                ScoreBot = 0;
                ScorePlayer = 0;
                return;
            }if(ScoreBot != 0 || ScorePlayer != 0)
            {
                Winner = "";
            }
            if (bot.Side == Options.Rock && selectedOption == Options.Scissors ||
                bot.Side == Options.Paper && selectedOption == Options.Rock ||
                bot.Side == Options.Scissors && selectedOption == Options.Paper)
            {
                ScoreBot++;
                LastWinner = "bot";
            }
            else if (
                selectedOption == Options.Rock && bot.Side == Options.Scissors ||
                selectedOption == Options.Paper && bot.Side == Options.Rock ||
                selectedOption == Options.Scissors && bot.Side == Options.Paper)
            {
                ScorePlayer++;
                LastWinner = "player";
            }
            else
            {
                LastWinner = "draw";
            }
        }
        public string VerifyWinner()
        {
            if(ScorePlayer >= 10)
            {
                return "Player Won";
            }
            else if(ScoreBot >= 10)
            {
                return "Bot Won";
            }
            else
            {
                return "";
            }
        }
    }
}
