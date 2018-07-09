namespace TwitchLibExamples.PubSubExamples
{
    using System;
    using UnityEngine;

    public class PubSubChatModeratorActionsExample : PubSubExample
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
            _pubSub.OnTimeout += OnTimeout;
            _pubSub.OnUntimeout += _pubSub_OnUntimeout;
            _pubSub.OnBan += OnBan;
            _pubSub.OnUnban += OnUnban;
            _pubSub.OnHost += OnHost;
            _pubSub.OnClear += OnClear;
            _pubSub.OnSubscribersOnly += OnSubscribersOnly;
            _pubSub.OnSubscribersOnlyOff += OnSubscribersOnlyOff;
            _pubSub.OnEmoteOnly += OnEmoteOnly;
            _pubSub.OnEmoteOnlyOff += OnEmoteOnlyOff;
            _pubSub.OnR9kBeta += OnR9kBeta;
            _pubSub.OnR9kBetaOff += OnR9kBetaOff;


            // Listening to NAME_NOT_PROVIDED_YET require the SCOPE_NOT_PROVED_YET scope in the OAuth token.
            _pubSub.ListenToChatModeratorActions("MY_TWITCH_ID", "CHANNEL_TWITCH_ID");
        }

        private void OnR9kBetaOff(object sender, TwitchLib.PubSub.Events.OnR9kBetaOffArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void OnR9kBeta(object sender, TwitchLib.PubSub.Events.OnR9kBetaArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void OnEmoteOnlyOff(object sender, TwitchLib.PubSub.Events.OnEmoteOnlyOffArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void OnEmoteOnly(object sender, TwitchLib.PubSub.Events.OnEmoteOnlyArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void OnClear(object sender, TwitchLib.PubSub.Events.OnClearArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void OnSubscribersOnlyOff(object sender, TwitchLib.PubSub.Events.OnSubscribersOnlyOffArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void OnSubscribersOnly(object sender, TwitchLib.PubSub.Events.OnSubscribersOnlyArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void OnHost(object sender, TwitchLib.PubSub.Events.OnHostArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void _pubSub_OnUntimeout(object sender, TwitchLib.PubSub.Events.OnUntimeoutArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void OnUnban(object sender, TwitchLib.PubSub.Events.OnUnbanArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void OnBan(object sender, TwitchLib.PubSub.Events.OnBanArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void OnTimeout(object sender, TwitchLib.PubSub.Events.OnTimeoutArgs e)
        {
            throw new System.NotImplementedException();
        }

        protected override void OnPubSubServiceConnected(object sender, EventArgs e)
        {
            _pubSub.SendTopics(_oAuthToken);
        }
    }
}