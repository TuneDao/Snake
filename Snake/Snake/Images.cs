using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Snake
{
    public static class Images
    {
        public readonly static ImageSource Empty = LoadImage("Empty.png");
        public readonly static ImageSource DeadBody = LoadImage("deadbody.png");
        public readonly static ImageSource DeadHead = LoadImage("deadhead.png");
        public readonly static ImageSource Food = LoadImage("Food.png");
        public readonly static ImageSource Head = LoadImage("head.png");
        public readonly static ImageSource Body = LoadImage("body.png");

        private static ImageSource LoadImage(string fileName)
        {
            return new BitmapImage(new Uri($"Assets/{fileName}",UriKind.Relative));
        }
    }
}
