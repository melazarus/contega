using System;

namespace tui.net
{
    public class TextPixel : IEquatable<TextPixel>
    {
        public TextPixel(char? character = null, ConsoleColor? backgroundColor = null,
            ConsoleColor? foregroundColor = null)
        {
            BackgroundColor = backgroundColor;
            Character = character;
            ForegroundColor = foregroundColor;
        }

        public char? Character { get; }

        public ConsoleColor? BackgroundColor { get; }

        public ConsoleColor? ForegroundColor { get; }

        public bool Equals(TextPixel obj)
        {
            return (obj.BackgroundColor.Equals(BackgroundColor) &&
                    obj.ForegroundColor.Equals(ForegroundColor) &&
                    obj.Character.Equals(Character));
        }

        public TextPixel Clone()
        {
            return new TextPixel(Character, BackgroundColor, ForegroundColor);
        }
    }
}