using System;
using System.Collections.Generic;
using DojoCards.Models;

namespace DojoCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck d1 = new Deck();
            d1.Shuffle();
            Player p1 = new Player(d1);
            p1.Draw(2);
            p1.Display();
            p1.discard(0);
            p1.Display();
        }
    }
}