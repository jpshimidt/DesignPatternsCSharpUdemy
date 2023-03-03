using Bridge.Platforms;
using Bridge.Transmissions;
using System;

namespace Bridge
{
    class Program
    {
        static void StartLive(IPlatform platform)
        {
            Console.WriteLine("Aguarde...");

            Live live = new Live(platform);

            live.Broadcasting();
            live.Result();
        }

        static void StartLiveAdvanced(IPlatform platform)
        {
            Console.WriteLine("Aguarde...");

            AdvancedLive live = new AdvancedLive(platform);

            live.Broadcasting();
            live.Subtitle();
            live.Comments();
            live.Result();
        }

        static void StartLiveAdvancedWithRecord(IPlatform platform)
        {
            Console.WriteLine("Aguarde...");

            AdvancedLive live = new AdvancedLive(platform);

            live.Broadcasting();
            live.Subtitle();
            live.Comments();
            live.Record();
            live.Result();
        }

        static void Main(string[] args)
        {
            StartLive(new Youtube());
            StartLiveAdvanced(new Facebook());
            StartLive(new TwitchTv());
            StartLiveAdvancedWithRecord(new DLive());

            Console.ReadLine();
        }
    }
}
