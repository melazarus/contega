using System;

namespace tui.net
{
    public class TextPixel : IEquatable<TextPixel>
    {
        public char? Character { get; private set; }

        public ConsoleColor? BackgroundColor { get; private set; }

        public ConsoleColor? ForegroundColor { get; private set; }

        public TextPixel(char? character = null, ConsoleColor? backgroundColor = null, ConsoleColor? foregroundColor = null)
        {
            BackgroundColor = backgroundColor;
            Character = character;
            ForegroundColor = foregroundColor;
        }

        public bool Equals(TextPixel obj)
        {
            return (obj.BackgroundColor.Equals(BackgroundColor) &&
                    obj.ForegroundColor.Equals(ForegroundColor) &&
                    obj.Character.Equals(Character));
        }
    }
}
