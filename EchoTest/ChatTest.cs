using Echo;
using Echo.ChatEntries;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EchoTest
{
    [TestFixture()]
    public class ChatTest
    {
        [Test()]
        public void Choose_MultipleChoices_CorrectChoicesAreMade()
        {
            Game game = TestHelper.createGame();

            Chat chat = TestHelper.createChat(game);

            Location forestLocation = TestHelper.createLocation();

            String forestEntryMsg = "Reach forest";
            TextChatEntry forestEntry = new TextChatEntry(forestEntryMsg,
                    game => game.MainCharacter.CurrentLocation = forestEntry);

            String choiceMsg = "You meet wolf";

            String choice1Msg = "Run away";
            TextChatEntry removeHPChatEntry = new TextChatEntry("You took 5 dmg", game => game.MainCharacter.RemoveHP(5));
            TextChatEntry choice1 = new TextChatEntry(choice1Msg, removeHPChatEntry);

            String choice2Msg = "Pet it";
            TextChatEntry petWolf = new TextChatEntry("Wolf liked, He restored your stamina to full",
                    game => game.MainCharacter.RestorHP(), forestEntry);
            TextChatEntry choice2 = new TextChatEntry(choice2Msg, petWolf);
            
            ChoiceChatEntry choiceEntry = new ChoiceChatEntry(choiceMsg, choice1, choice2);

            chat.CurrentChatEntry = choiceEntry;

            // pet wolf
            chat.Choose(2);

            ChatEntry actualChatEntry = chat.CurrentChatEntry;

            Assert.AreEqual(petWolf, actualChatEntry);

            // Reach forest
            chat.Choose(1);

            actualChatEntry = chat.CurrentChatEntry;

            Assert.AreEqual(forestEntry, actualChatEntry);
            Assert.AreEqual(forestLocation, actualChatEntry);
        }
    }
}
