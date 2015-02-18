using System;

namespace Echo
{
	public class GameEvent
	{
        public static readonly GameEvent NoEvent = new GameEvent();

		public GameEvent ()
		{
		}

        public void AddTrigger(GameTrigger gTrigger)
        {
            throw new NotImplementedException();
        }
    }
}

