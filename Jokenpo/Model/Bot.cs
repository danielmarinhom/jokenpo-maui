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

        public void sortSide()
        {
            Random random = new Random();
            int randomSide = random.Next(1,4);
            Options options = (Options)randomSide;
            Side = options;
        }
    }
}
