namespace TwitchLibExamples.PubSubExamples
{
    using System;
    using UnityEngine;

    public class PubSubWhispersExample : PubSubExample
    {
        // Listening to Whispers require the chat_login scope in the OAuth token.
        // You can use the following url to generate one with that specific scope: TODO GENERATE URL --> https://twitchtokengenerator.com/quick/qyRp65ijkh
        // You can also manually create a token with more scopes: https://twitchtokengenerator.com
        [SerializeField, Tooltip("The OAuth token ")]
        private string _oAuthToken;
        [SerializeField, Tooltip("The Twitch Id from the channel")]
        private string _channelId;

        protected override void Awake()
        {
            base.Awake();

            // Subscribe to the OnWhisper event
            _pubSub.OnWhisper += OnWhisper;

            // Please note that listening to the whisper events requires the SCOPE_NOT_PROVED_YET scope in the OAuth token.
            _pubSub.ListenToWhispers(_channelId);
        }

        private void OnWhisper(object sender, TwitchLib.PubSub.Events.OnWhisperArgs e)
        {
            // If the channelId is not the channel id we're trying to listen to in this class, don't continue.
            if (e.RecipientId != _channelId)
                return;

            Debug.Log($"{e.Body}");
        }

        protected override void OnPubSubServiceConnected(object sender, EventArgs e)
        {
            _pubSub.SendTopics(_oAuthToken);
        }
    }
}