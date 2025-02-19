﻿using Born.InterviewTest.Network;

namespace Born.InterviewTest.Runtime
{
    /// <summary>
    /// The class for the application.
    /// This needs to instantiate long running systems and can also be the dependency provider to MonoBehaviour classes.
    /// </summary>
    public class App
    {
        public static App Instance { get; private set; }

        public ISessionInfoProvider SessionInfoProvider { get; }
        public ITestMessageReceiver TestMessageReceiver { get; }

        public App()
        {
            Instance = this;

            Session session = new();
            SessionInfoProvider = session;
            TestMessageReceiver = session;
        }
    }
}