namespace TwitchLibExamples.PubSubExamples
{
    using System;
    using UnityEngine;

    public class PubSubChannelExtensionBroadcastExample : PubSubExample
    {
        // Listening to ChannelExtensionBroadcast require the SCOPE_NOT_PROVED_YET scope in the OAuth token.
        // You can use the following url to generate one with that specific scope: TODO GENERATE URL --> https://twitchtokengenerator.com/quick/bz4gtqg678
        // You can also manually create a token with more scopes: https://twitchtokengenerator.com
        [SerializeField, Tooltip("The OAuth token ")]
        private string _oAuthToken;
        [SerializeField, Tooltip("The Twitch Id from the channel")]
        private string _channelId;
        [SerializeField, Tooltip("The id from the extension used in the channel")]
        private string _extensionId;

        protected override void Awake()
        {
            base.Awake();

            // Subscribe to the OnBitsReceived event
            _pubSub.OnChannelExtensionBroadcast += OnChannelExtensionBroadcast;

            // Listening to NAME_NOT_PROVIDED_YET require the SCOPE_NOT_PROVED_YET scope in the OAuth token.
            _pubSub.ListenToChannelExtensionBroadcast(_channelId, _extensionId);
        }

        private void OnChannelExtensionBroadcast(object sender, TwitchLib.PubSub.Events.OnChannelExtensionBroadcastArgs e)
        {
            throw new System.NotImplementedException();
            
            Debug.Log($"Messages: {string.Join(", ", e.Messages)}.");
        }

        protected override void OnPubSubServiceConnected(object sender, EventArgs e)
        {
            _pubSub.SendTopics(_oAuthToken);
        }
    }
}