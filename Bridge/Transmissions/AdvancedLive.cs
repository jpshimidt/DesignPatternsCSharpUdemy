using Bridge.Platforms;
using System;

namespace Bridge.Transmissions
{
    class AdvancedLive : Live
    {
        public AdvancedLive(IPlatform platform) : base(platform)
        {

        }

        public void Subtitle()
        {
            Console.WriteLine("Legendas ativadas na transmissão!");
        }

        public void Comments()
        {
            Console.WriteLine("Comentários ativados na transmissão!");
        }

        public void Record()
        {
            Console.WriteLine("Gravando a transmissão!");
        }
    }
}
