using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOLayer
{
    public class Player
    {
        public string Name { get; set; }
        public string PanelName { get; set; }
        public string CardSide { get; set; }
        public int CardWidth { get; set; }
        public int CardHeight { get; set; }
        public int CardLeft { get; set; }
        public Hand Hand { get; set; }
        public int Turn { get; set; }
        public string Tag { get; set; }

        public Player() { }
        public Player(string name, string panelName, string cardSide, int cardWidth, int cardHeight, int cardLeft, string tag)
        {
            Name = name;
            PanelName = panelName;
            CardSide = cardSide;
            CardWidth = cardWidth;
            CardHeight = cardHeight;
            CardLeft = cardLeft;
            Tag = tag;
        }       
    }
}
