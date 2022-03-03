using System;

namespace _Root.Scripts.Services.Ads
{
    internal interface IAdPlayer
    {
        event Action Started;
        event Action Finished;
        event Action Failed;
        event Action Skipped;
        event Action BecomeReady;

        void Play();
    }
}