using Echo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EchoTest
{
    class TestHelper
    {
        static public Chat createChat(Game game)
        {
            return new Chat(game);
        }

        static public Character createCharacter()
        {
            return new Character();
        }

        static public Location createLocation()
        {
            return new Location();
        }

        static public Area createArea()
        {
            return new Area(new Polygon());
        }

        static public Story createStory()
        {
            return new Story();
        }

        static public Game createGame()
        {
            return new Game();
        }

        static public Travel createTravel(Location X, Location Y)
        {
            return new Travel(X, Y);
        }
    }
}
