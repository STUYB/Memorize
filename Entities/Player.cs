using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memorize.Entities
{
    public class Player : Entity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Country { get; set; }
        public int GamesWon { get; set; } // Helper property
    }
}
