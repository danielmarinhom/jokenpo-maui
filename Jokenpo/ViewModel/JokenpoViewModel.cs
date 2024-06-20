using CommunityToolkit.Mvvm.ComponentModel;
using Jokenpo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokenpo.ViewModel
{
    public partial class JokenpoViewModel : ObservableObject
    {

        int ScorePlayer { get; set; }
        int ScoreBot { get; set; }
        string lastWinner { get; set; }

        [ObservableProperty]
        private string sourcePlayer;
        [ObservableProperty]
        private string sourceBot;
        [ObservableProperty]
        private Options indexPicker;

        Bot bot = new Bot();



        public void getWinner()
        {
            bot.sortSide();

            SourceBot = bot.Side +".jpeg" ;
            SourcePlayer =  IndexPicker+ ".jpeg";

            //if (bot.Side == (Options)indexPicker)
            if (bot.Side == (Options)1 && IndexPicker == (Options)3 ||
               bot.Side == (Options)2 && IndexPicker == (Options)1 ||
               bot.Side == (Options)3 && IndexPicker == (Options)2
                )
            {
                ScoreBot += 1;
                lastWinner = "bot";
            }
            else if(
               IndexPicker == (Options)1 && bot.Side == (Options)3 ||
               IndexPicker == (Options)2 && bot.Side == (Options)1 ||
               IndexPicker == (Options)3 && bot.Side == (Options)2
                )
            {
                ScorePlayer += 1;
                lastWinner = "player";
            }

        }

    }
}
