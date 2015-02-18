using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo.ChatEntries
{
    public class TextChatEntry : ChatEntry
    {
        private string msg;

        public TextChatEntry(string msg)
        {
            // TODO: Complete member initialization
            this.msg = msg;
        }
    }
}
