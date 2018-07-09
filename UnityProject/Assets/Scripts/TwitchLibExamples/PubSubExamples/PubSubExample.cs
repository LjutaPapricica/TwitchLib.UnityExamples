namespace TwitchLibExamples.PubSubExamples
{
    // If type or namespace TwitchLib could not be found. Make sure you add the latest TwitchLib.Unity.dll to your project folder
    // Download it here: https://github.com/TwitchLib/TwitchLib.Unity/releases
    // Or download the repository at https://github.com/TwitchLib/TwitchLib.Unity, build it, and copy the TwitchLib.Unity.dll from the output directory
    using System;
    using TwitchLib.Unity;
    using UnityEngine;

    public abstract class PubSubExample : MonoBehaviour
    {
        protected PubSub _pubSub;

        protected virtual void Awake()
        {
            // To keep the Unity application active in the background, you can enable "Run In Background" in the player settings:
            // Unity Editor --> Edit --> Project Settings --> Player --> Resolution and Presentation --> Resolution --> Run In Background
            // This option seems to be enabled by default in more recent versions of Unity. An aditional, less recommended option is to set it in code:
            // Application.runInBackground = true;

            // Create new instance of PubSub Client
            _pubSub = new PubSub();

            // Subscribe to Events
            _pubSub.OnPubSubServiceConnected += OnPubSubServiceConnected;
        }

        private void Start()
        {
            // Connect
            _pubSub.Connect();
        }

        protected abstract void OnPubSubServiceConnected(object sender, EventArgs e);
    }
}