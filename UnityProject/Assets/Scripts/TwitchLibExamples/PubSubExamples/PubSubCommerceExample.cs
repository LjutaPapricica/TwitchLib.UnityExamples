namespace TwitchLibExamples.PubSubExamples
{
    using System;
    using UnityEngine;

    public class PubSubCommerceExample : PubSubExample
    {
        // Listening to NAME_NOT_PROVIDED_YET require the SCOPE_NOT_PROVED_YET scope in the OAuth token.
        // You can use the following url to generate one with that specific scope: TODO GENERATE URL --> https://twitchtokengenerator.com/quick/bz4gtqg678
        // You can also manually create a token with more scopes: https://twitchtokengenerator.com
        [SerializeField, Tooltip("The OAuth token ")]
        private string _oAuthToken;
        [SerializeField, Tooltip("The Twitch Id from the channel")]
        private string _channelId;

        protected override void Awake()
        {
            base.Awake();

            // Subscribe to the OnBitsReceived event
            _pubSub.OnChannelCommerceReceived += OnChannelCommerceReceived;

            // Listening to NAME_NOT_PROVIDED_YET require the SCOPE_NOT_PROVED_YET scope in the OAuth token.
            _pubSub.ListenToCommerce("CHANNEL_NAME");
        }

        private void OnChannelCommerceReceived(object sender, TwitchLib.PubSub.Events.OnChannelCommerceReceivedArgs e)
        {
            // If the channelId is not the channel id we're trying to listen to in this class, don't continue.
            if (e.ChannelId != _channelId)
                return;

            throw new System.NotImplementedException();
        }

        protected override void OnPubSubServiceConnected(object sender, EventArgs e)
        {
            _pubSub.SendTopics(_oAuthToken);
        }
    }
}