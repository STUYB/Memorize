using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memorize.Entities
{
    public class Highscore: Entity
    {
        public string Username { get; set; }
        public string Game { get; set; }
        public int Clicks { get; set; }
    }
}
