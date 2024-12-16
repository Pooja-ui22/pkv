using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_paper_scissors
{
    public class Player
    {
        public string Name { get; set; }
        public string Choice { get; set; }


        public Player(string name)
        {
            Name = name;
        }

        public void SetChoice(string choice)
        {
            Choice = choice;
        }
    }
}
