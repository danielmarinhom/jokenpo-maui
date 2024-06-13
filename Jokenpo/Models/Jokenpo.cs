using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokenpo.Models
{
    public class Jokenpo
    {

        public Options Side { get; set; }

        public void randomChoice()
        {
            Random random = new Random();
            int randomSide = random.Next(3);
            Options options = (Options)randomSide;
            Side = options;
        }
    }
}
