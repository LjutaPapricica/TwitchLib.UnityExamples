namespace TwitchLibExamples.PubSubExamples
{
    using System;
    using UnityEngine;

    public class PubSubBitsEventsExample : PubSubExample
    {
        // Listening to BitsEvents require the bits:read scope in the OAuth token.
        // You can use the following url to generate one with that specific scope: https://twitchtokengenerator.com/quick/bz4gtqg678
        // You can also manually create a token with more scopes: https://twitchtokengenerator.com
        [SerializeField, Tooltip("The OAuth token ")]
        private string _oAuthToken;
        [SerializeField, Tooltip("The Twitch Id from the channel")]
        private string _channelId;

        protected override void Awake()
        {
            base.Awake();

            // Subscribe to the OnBitsReceived event
            _pubSub.OnBitsReceived += OnBitsReceived;

            // Listening to NAME_NOT_PROVIDED_YET require the SCOPE_NOT_PROVED_YET scope in the OAuth token.
            _pubSub.ListenToBitsEvents(Secrets.CHANNEL_ID_FROM_OAUTH_TOKEN);
        }

        private void OnBitsReceived(object sender, TwitchLib.PubSub.Events.OnBitsReceivedArgs e)
        {
            // If the channelId is not the channel id we're trying to listen to in this class, don't continue.
            if (e.ChannelId != _channelId)
                return;

            Debug.Log($"{e.Username} cheered {e.BitsUsed} bits.");
        }

        protected override void OnPubSubServiceConnected(object sender, EventArgs e)
        {
            _pubSub.SendTopics(_oAuthToken);
        }
    }
}