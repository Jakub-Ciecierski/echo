using NUnit.Framework;
using System;
using Echo;

namespace EchoTest
{
	[TestFixture ()]
	public class GameMapTest
	{

		private GameMap createMap()
		{
			return new GameMap ();
		}

		[Test ()]
		public void Click_OneArea_ReturnGameEvent()
		{ 
			GameMap gm = createMap ();

			Polygon p = new Polygon ();
			p.AddPoint (0, 0);
			p.AddPoint (0, 6);
			p.AddPoint (6, 0);
			p.AddPoint(6, 6);

			Area area = new Area (p);

            GameTrigger gTrigger = new GameTrigger();

			GameEvent gEvent = new GameEvent();
            gEvent.AddTrigger(gTrigger);

			area.AddEvent (gEvent);

			gm.AddArea (area);

            GameTrigger actualTrigger = gm.Click(2, 5);

			Assert.AreEqual (gTrigger, actualTrigger);
		}

        [Test()]
        public void Click_NoArea_ReturnNoTrigger()
        {
            GameMap gm = createMap();

            GameTrigger actualTrigger = gm.Click(2, 5);

            Assert.AreEqual(GameTrigger.NoTrigger, actualTrigger);
        }



	}
}

