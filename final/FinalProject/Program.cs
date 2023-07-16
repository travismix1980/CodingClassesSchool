/*
So because of the outside temps and the lack of air conditioning in my house It has been
averaging temps of 110 degrees at my desk where my computer is so I had limited time to
work on this project and had to cut several features.  These cut features to make the timeline
are listed under the read rules option in the game menu but consist of the following
    1. Saving and Loading game
    2. Multiplayer
    3. Insurance
    4. Spliting
    5. Natural Blackjack vs Normal Blackjack
    6. Hidden first dealer card
    7. Better Blackjack interface

There may be a few bugs left but I am pretty sure I squashed them all but without
further testing I cannot be 100% on that.  Anyway I figured some grade was better
than no grade so enjoy and I am sad you will not get to experience the full product
that was planned.  To answer the question of why not make money a part of the player
I wanted to keep money seperate so it would be more modular and reusable in other
projects.

The code gets a little messy in parts as I was rushing to get things to work in
the end up to the deadline sorry.
*/

class Program
{
    static void Main(string[] args)
    {
        Controller _controller = new();
        _controller.RunBlackJack();
    }
}
