using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memorize.Entities
{
    public class Game : Entity
    {
        public string Name { get; set; }
        public string Theme { get; set; }
        public string Size { get; set; }
        public int Timer { get; set; }
    }
}
