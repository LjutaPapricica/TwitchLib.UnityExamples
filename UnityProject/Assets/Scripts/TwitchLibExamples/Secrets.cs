namespace TwitchLibExamples
{
    public static class Secrets
    {
        public const string CLIENT_ID = "CLIENT_ID"; //Your application's client ID, register one at https://dev.twitch.tv/dashboard
        public const string OAUTH_TOKEN = "OAUTH_TOKEN"; //A Twitch OAuth token which can be used to connect to the chat
        public const string USERNAME_FROM_OAUTH_TOKEN = "USERNAME_FROM_OAUTH_TOKEN"; //The username which was used to generate the OAuth token
        public const string CHANNEL_ID_FROM_OAUTH_TOKEN = "CHANNEL_ID_FROM_OAUTH_TOKEN"; //The channel Id from the account which was used to generate the OAuth token
    }
}