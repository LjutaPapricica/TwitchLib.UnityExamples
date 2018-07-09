namespace TwitchLibExamples.PubSubExamples
{
    using System;
    using UnityEngine;

    public class PubSubFollowsExample : PubSubExample
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
            _pubSub.OnFollow += OnFollow;

            // Listening to NAME_NOT_PROVIDED_YET require the SCOPE_NOT_PROVED_YET scope in the OAuth token.
            _pubSub.ListenToFollows("CHANNEL_ID");
        }

        private void OnFollow(object sender, TwitchLib.PubSub.Events.OnFollowArgs e)
        {
            // If the channelId is not the channel id we're trying to listen to in this class, don't continue.
            if (e.FollowedChannelId != _channelId)
                return;

            Debug.Log($"{e.DisplayName} followed channel with Id {e.FollowedChannelId}.");
        }

        protected override void OnPubSubServiceConnected(object sender, EventArgs e)
        {
            _pubSub.SendTopics(_oAuthToken);
        }
    }
}