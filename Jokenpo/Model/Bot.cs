using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokenpo.Model
{
    public class Bot
    {
        public Options Side { get; set; }
        Side = Options.Rock; 
        public void sortSide()
        {
            Random random = new Random();
            int randomSide = random.Next(3);
            Options options = (Options)randomSide;
            Side = options;
        }
    }
}
