using NUnit.Framework;
using System;
using Echo;

namespace EchoTest
{
	[TestFixture ()]
	public class MapTest
	{


        [Test()]
        public void Travel_LocationsAreConnected_AddStoryToChat()
        {
            Game game = (Game)TestHelper.createGame();
            Chat chat = TestHelper.createChat(game);

            Character character = TestHelper.createCharacter();

            Story story = TestHelper.createStory();

            Location currentLocation = character.Location;

            Location destLocation = TestHelper.createLocation();

            ChoiceChatEntry chatEntry = new ChoiceChatEntry();
            story.AddEntry(chatEntry);

            Travel travel = TestHelper.createTravel(currentLocation, destLocation);

            travel.AddStory(story);

            game.AddTravel(travel);

            game.Travel(character, destLocation);

            Location actualLocation = character.Location;

            Assert.AreEqual(destLocation, actualLocation);
            Assert.AreEqual(story, chat.CurrentStory);
        }

        [Test()]
        public void Travel_LocationsAreNotConnected_NoChangesToChat()
        {
            Game game = (Game)TestHelper.createGame();
            Chat chat = TestHelper.createChat(game);

            Character character = TestHelper.createCharacter();

            Location currentLocation = character.Location;

            Location destLocation = TestHelper.createLocation();

            Story expectedStory = chat.CurrentStory;

            // returns null if failed
            game.Travel(character, destLocation);

            Story actualStory = chat.CurrentStory;

            Location actualLocation = character.Location;

            Assert.AreEqual(expectedStory, actualStory);
            Assert.AreEqual(currentLocation, actualLocation);
        }
	}
}

