using System;
using EchoBot.Models;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.Dialogs;

namespace EchoBot.Services
{
    public class BotStateService
    {
        public ConversationState ConversationState { get; }

        public UserState UserState { get; }

        public static string UserProfileId { get; } = $"{nameof(BotStateService)}.UserProfile";

        public static string ConversationId { get; set; } = $"{nameof(BotStateService)}.ConversationData";

        public static string DialogStateId { get; } = $"{nameof(BotStateService)}.DialogState";

        public IStatePropertyAccessor<UserProfile> UserProfileAccessor { get; set; }

        public IStatePropertyAccessor<ConversationData> ConversationDataAccessor { get; set; }

        public IStatePropertyAccessor<DialogState> DialogStateAccessor { get; set; }

        public BotStateService(UserState userState, ConversationState conversationState)
        {
            ConversationState = conversationState ?? throw new ArgumentNullException(nameof(conversationState));
            UserState = userState ?? throw new ArgumentNullException(nameof(userState));

            InitializeAccessors();
        }

        public void  InitializeAccessors()
        {
            ConversationDataAccessor = ConversationState.CreateProperty<ConversationData>(ConversationId);
            DialogStateAccessor = ConversationState.CreateProperty<DialogState>(DialogStateId);
            UserProfileAccessor = UserState.CreateProperty<UserProfile>(UserProfileId);
           
        }
    }
}
