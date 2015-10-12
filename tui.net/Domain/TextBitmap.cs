using System;
using System.Linq;

namespace tui.net
{
    public class TextBitmap
    {
        private readonly TextPixel[] _pixels;

        public TextBitmap(int width, int height)
        {
            Width = width;
            Height = height;
            _pixels = new TextPixel[Width*Height];
        }

        public TextPixel this[int x, int y]
        {
            get { return _pixels[y*Width + x]; }
            set { _pixels[y*Width + x] = value; }
        }

        public TextPixel this[int index]
        {
            get { return _pixels[index]; }
            set { _pixels[index] = value; }
        }

        public int Width { get; set; }

        public int Height { get; set; }

        public static TextBitmap GenerateFromString(string text, ConsoleColor? foreground = null,
            ConsoleColor? background = null)
        {
            var lines = SplitToLines(text);
            var height = lines.Length;
            var width = lines.Max(x => x.Length);

            var bitmap = new TextBitmap(width, height);

            for (var y = 0; y < height; y++)
            {
                for (var x = 0; x < width; x++)
                {
                    if (x < lines[y].Length) bitmap[x, y] = new TextPixel(lines[y][x], background, foreground);
                }
            }

            return bitmap;
        }

        private static string[] SplitToLines(string text)
        {
            return text
                .Replace("\r\n", "\n")
                .Replace("\r", "\n")
                .Split('\n');
        }

        internal TextBitmap Clone()
        {
            var newOBject = new TextBitmap(Width, Height);
            for (var i = 0; i < _pixels.Length; i++)
            {
                newOBject[i] = this[i].Clone();
            }

            return newOBject;
        }
    }
}