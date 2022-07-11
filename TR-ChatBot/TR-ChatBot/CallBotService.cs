using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Bot.Connector.DirectLine;

namespace TR_ChatBot
{
    class CallBotService
    {
        string directLineSecret;
        string botId;
        string fromUser;
        Microsoft.Bot.Connector.DirectLine.DirectLineClient _directLineInterface;
        Conversation _conversation;
        string _watermark;

        public CallBotService()
        {
            directLineSecret = "riTZZ4HuoJI.F_WMKsaC9fEKb77W_5wk1v8LZo12ZQa_5GlkIv9P5BE";
            botId = "testbotqatr-bot";
            fromUser = "testuser";
            _directLineInterface = new Microsoft.Bot.Connector.DirectLine.DirectLineClient(directLineSecret);
        }

        public  List<string> SayHello(String message) // Make sure this is public
        {
            _conversation =  _directLineInterface.Conversations.StartConversation();
            var fromProperty = new ChannelAccount(fromUser);
            var activity = new Activity(text: message, fromProperty: fromProperty, type: "message");
            _directLineInterface.Conversations.PostActivity(_conversation.ConversationId, activity);
            var response = _directLineInterface.Conversations.GetActivities(_conversation.ConversationId, _watermark);
            _watermark = response.Watermark;
            List<string> messages = new List<string>();
            foreach (Activity a in response.Activities)
            {
                messages.Add(a.Text);
            }
            return messages;
        }

    }
}
