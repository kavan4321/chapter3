using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter3.Model
{
    class Page1Model
    {
        public string QuoteDisplay { get; set; }

        public string[] Quotes = 
            
                {"You’re braver than you believe, and stronger than you seem, and smarter than you think. -A.A. Mine",
                "Keep your face to the sunshine and you cannot see a shadow. - Helen Keller",
                "In every day, there are 1,440 minutes. That means we have 1,440 daily opportunities to make a positive impact. -Les Browen",
                "The only time you fail is when you fall down and stay down. -Stephen Richards",
                "Optimism is a happiness magnet. If you stay positive good things and good people will be drawn to you. -Mery Lou",
                "Happiness is an attitude. We either make ourselves miserable, or happy and strong. The amount of work is the same -Francesca Reigler",
                "Winning doesn’t always mean being first. Winning means you’re doing better than you’ve done before. -Bonnie Blair",
                "Wherever you go, no matter what the weather, always bring your own sunshine. -Anthony J. D’Angelo",
                "When we are open to new possibilities, we find them. Be open and skeptical of everything.-Todd Kashdan",
                "The sun himself is weak when he first rises, and gathers strength and courage as the day gets on. -Charles Dickens",
                "If opportunity doesn’t knock, build a door. -Milton Berle"};
        public void QuoteList()
        {
            Random select = new();         
            QuoteDisplay= Quotes.ElementAt(select.Next(0, Quotes.Length));//select element at random selected item

        }
    }
}
