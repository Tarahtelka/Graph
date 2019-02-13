using System.Drawing;

namespace GraphApp.Views.Implementations.Helpers
{
    public static class Constants
    {
        public const int Multiplier = 180;

        public const int PenSize = 2;

        public const int FontSize = 8;

        public const int CircleRadius = 25;

        public const int NumberMargin = 15;

        static Constants()
        {
            Font = new Font("Arial", FontSize);
        }

        public static Font Font { get; }
    }
}