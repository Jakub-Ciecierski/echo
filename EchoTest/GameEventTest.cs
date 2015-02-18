using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Echo;
using Echo.ChatEntries;

namespace EchoTest
{
    [TestFixture ()]
    class GameEventTest
    {
        private GameChat createChat()
        {
            return new GameChat();
        }

        private Character createCharacter()
        {
            return new Character();
        }
        [Test()]
        public void TriggerEvent_SomeChat_AddToChat()
        {
            GameChat gChat = createChat();

            GameAction<GameChat> cAction = new GameAction<GameChat>();

            string expectedChat = "Test chat entry";

            cAction.AddOperation(chat => chat.AddEntry(new TextChatEntry(expectedChat)));

            cAction.Activate(gChat);

            ChatEntry actualChatEntry = gChat.LastEntry;
            string actualChatEntryStr = actualChatEntry.ToString();

            Assert.AreEqual(expectedChat,actualChatEntryStr);
        }

        // TODO 
        public void TriggerEvent_CharacterAtXArea_CharacterMovedToYArea()
        { 
            Character character = createCharacter();

        }
    }
}
